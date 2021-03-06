using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Base.Exceptions;
using WDLT.Clients.POE.Enums;
using WDLT.Clients.POE.Exception;
using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE
{
    public class POEClient : BaseClient
    {
        public static string CDN { get; } = "https://web.poecdn.com";
        public static string BASE { get; } = "https://www.pathofexile.com";

        public string POESESSID { get; set; }

        public POEClient(string userAgent) : base(BASE, userAgent)
        {
        }

        public Task<POEResult<List<POELeague>>> TradeLeaguesAsync()
        {
            return POERequestAsync<POEResult<List<POELeague>>>(new RestRequest("/api/trade/data/leagues"));
        }

        public Task<POEAccountName> AccountNameByCharacter(string character)
        {
            return POERequestAsync<POEAccountName>(new RestRequest($"/character-window/get-account-name-by-character?character={character}"));
        }

        public Task<List<POECharacter>> Characters(string account, EPOERealm realm = EPOERealm.PC)
        {
            var request = new RestRequest("/character-window/get-characters", Method.POST);
            request.AddParameter("realm", realm.ToString().ToLower());
            request.AddParameter("accountName", account);

            return POERequestAsync<List<POECharacter>>(request);
        }

        public Task<POEAccountPins> AccountPinsAsync(string account, int limit = 10, int offset = 0, EPOERealm realm = EPOERealm.PC)
        {
            var request = new RestRequest("/api/account/showcase-pins");
            request.AddQueryParameter("offset", offset.ToString());
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("account", account);
            request.AddQueryParameter("realm", realm.ToString().ToLower());
            request.AddQueryParameter("_", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString());

            return POERequestAsync<POEAccountPins>(request);
        }

        public Task<POEResult<List<POEStatic>>> TradeStaticAsync()
        {
            return POERequestAsync<POEResult<List<POEStatic>>>(new RestRequest("/api/trade/data/static"));
        }

        public Task<POESearchResult> TradeSearchAsync(string league, POESearchPayload payload)
        {
            var request = new RestRequest($"/api/trade/search/{league}", Method.POST);

            request.AddParameter("application/json", JsonConvert.SerializeObject(payload), ParameterType.RequestBody);

            return POERequestAsync<POESearchResult>(request);
        }

        public Task<POEResult<List<POEFetchResult>>> TradeFetchAsync(IEnumerable<string> pageIds)
        {
            var pages = string.Join(",", pageIds);

            var request = new RestRequest($"/api/trade/fetch/{pages}");

            return POERequestAsync<POEResult<List<POEFetchResult>>>(request);
        }

        public static Uri TradeUri(string league, string id)
        {
            return new Uri(BASE + $"/trade/search/{league}/{id}");
        }

        protected override void OnBeforeRequest(RestClient client, IRestRequest request, Proxy proxy = null)
        {
            if (!string.IsNullOrWhiteSpace(POESESSID)) request.AddCookie("POESESSID", POESESSID);
        }

        private async Task<T> POERequestAsync<T>(IRestRequest request, Proxy proxy = null)
        {
            try
            {
                return await RequestAsync<T>(request, proxy);
            }
            catch (ClientRequestException e)
            {
                if (TryDeserialize<POEErrorResponse>(e.Response.Content, out var errorDes))
                {
                    if (errorDes.Error.Code == 3)
                    {
                        var exRateLimit = new POERateLimitException(errorDes.Error);

                        var accountState = e.Response.Headers.FirstOrDefault(f => string.Equals(f.Name, "x-rate-limit-account-state", StringComparison.OrdinalIgnoreCase));

                        if (accountState != null)
                        {
                            var accountLimits = ParseRateLimit(accountState, EPOERateLimitType.Account).Where(w => w.Ban != 0);
                            exRateLimit.RateLimits.AddRange(accountLimits);
                        }
                        else
                        {
                            var ipState = e.Response.Headers.First(f => string.Equals(f.Name, "x-rate-limit-ip-state", StringComparison.OrdinalIgnoreCase));
                            var ipLimits = ParseRateLimit(ipState, EPOERateLimitType.IP).Where(w => w.Ban != 0);
                            exRateLimit.RateLimits.AddRange(ipLimits);
                        }

                        throw exRateLimit;
                    }
                    else
                    {
                        throw new POEException(errorDes.Error);
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        private static IEnumerable<POERateLimit> ParseRateLimit(Parameter parameter, EPOERateLimitType type)
        {
            foreach (var coma in parameter.Value.ToString().Split(","))
            {
                var split = coma.Split(":");
                yield return new POERateLimit(int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]), type);
            }
        }
    }
}
