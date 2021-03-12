using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serialization.Json;
using WDLT.Clients.Base;
using WDLT.Clients.POE.Enums;
using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE
{
    public class POEClient : BaseClient
    {
        public POEClient(string userAgent) : base("https://www.pathofexile.com", userAgent)
        {
        }

        public Task<POEResult<List<POELeague>>> Leagues()
        {
            return RequestAsync<POEResult<List<POELeague>>>(new RestRequest("/api/trade/data/leagues"));
        }

        public Task<POESearchResult> Search(string league, POESearchPayload payload)
        {
            var request = new RestRequest($"/api/trade/search/{league}", Method.POST);

            request.AddParameter("application/json", JsonConvert.SerializeObject(payload), ParameterType.RequestBody);

            return POERequest<POESearchResult>(request);
        }

        public Task<POEResult<List<POEFetchResult>>> Fetch(string query, IEnumerable<string> pageIds)
        {
            var pages = string.Join(",", pageIds);

            var request = new RestRequest($"/api/trade/fetch/{pages}");

            request.AddQueryParameter("query", query);

            return POERequest<POEResult<List<POEFetchResult>>>(request);
        }

        private Task<T> POERequest<T>(IRestRequest request, Proxy proxy = null)
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
