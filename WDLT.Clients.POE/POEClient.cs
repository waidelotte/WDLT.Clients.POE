using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE
{
    public class POEClient : BaseClient
    {
        public POEClient(string userAgent) : base("https://www.pathofexile.com", userAgent)
        {
        }

        public Task<POEResult<List<POELeague>>> LeaguesAsync()
        {
            return POERequestAsync<POEResult<List<POELeague>>>(new RestRequest("/api/trade/data/leagues"));
        }

        public Task<POEResult<List<POEStatic>>> StaticAsync()
        {
            return POERequestAsync<POEResult<List<POEStatic>>>(new RestRequest("/api/trade/data/static"));
        }

        public Task<POESearchResult> SearchAsync(string league, POESearchPayload payload)
        {
            var request = new RestRequest($"/api/trade/search/{league}", Method.POST);

            request.AddParameter("application/json", JsonConvert.SerializeObject(payload), ParameterType.RequestBody);

            return POERequestAsync<POESearchResult>(request);
        }

        public Task<POEResult<List<POEFetchResult>>> FetchAsync(string query, IEnumerable<string> pageIds)
        {
            var pages = string.Join(",", pageIds);

            var request = new RestRequest($"/api/trade/fetch/{pages}");

            request.AddQueryParameter("query", query);

            return POERequestAsync<POEResult<List<POEFetchResult>>>(request);
        }

        private Task<T> POERequestAsync<T>(IRestRequest request, Proxy proxy = null)
        {
            try
            {
                return RequestAsync<T>(request, proxy);
            }
            catch (ClientRequestException e)
            {
                var errorDes = JsonConvert.DeserializeObject<POEErrorResponse>(e.Response.Content);
                throw new POEException(errorDes.Error);
            }
        }
    }
}
