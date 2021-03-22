using System;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POERateLimit
    {
        public POERateLimit(int requests, int window, int ban, EPOERateLimitType type)
        {
            Requests = requests;
            Window = window;
            Ban = ban;
            Type = type;
            BanUntil = DateTimeOffset.Now.AddSeconds(ban);
        }

        public EPOERateLimitType Type { get; }
        public int Requests { get; }
        public int Window { get; }
        public int Ban { get; }
        public DateTimeOffset BanUntil { get; }
    }
}