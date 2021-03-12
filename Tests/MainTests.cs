using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WDLT.Clients.POE;
using WDLT.Clients.POE.Enums;
using WDLT.Clients.POE.Models;
using Xunit;

namespace Tests
{
    public class MainTests
    {
        private const string UA =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36";

        private readonly POEClient _client = new POEClient(UA);

        [Fact]
        public async Task LeaguesTest()
        {
            var leagues = await _client.Leagues();
            Assert.NotEmpty(leagues.Result);
        }

        [Fact]
        public async Task SearchTest()
        {
            var search = await _client.Search("Ritual", new POESearchPayload{ Query = { Type = "Exalted Orb" } });
            Assert.NotEmpty(search.Result);
            Assert.Equal("NV6ofp", search.Id);
        }

        [Fact]
        public async Task FetchTest()
        {
            var search = await _client.Search("Ritual", new POESearchPayload { Query = { Type = "Exalted Orb" }, Sort = new POESearchSort
            {
                StackSize = EPOESort.Desc
            }});

            var fetch = await _client.Fetch(search.Id, search.Result.Take(10));

            Assert.NotEmpty(fetch.Result);
        }

        [Fact]
        public async Task SpyTest()
        {
            var search = await _client.Search("Ritual", new POESearchPayload
            {
                Query = { Type = "Exalted Orb" },
                Sort = new POESearchSort
                {
                    StackSize = EPOESort.Desc
                }
            });

            var fetch = await _client.Fetch(search.Id, search.Result.Take(10));

            Assert.NotEmpty(fetch.Result);
        }
    }
}
