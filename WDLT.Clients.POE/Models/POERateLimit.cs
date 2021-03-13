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
        }

        public EPOERateLimitType Type { get; }
        public int Requests { get; }
        public int Window { get; }
        public int Ban { get; }
    }
}