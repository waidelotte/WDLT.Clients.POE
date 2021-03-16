using System.Collections.Generic;
using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE.Exception
{
    public class POERateLimitException : POEException
    {
        public List<POERateLimit> RateLimits { get; }

        public POERateLimitException(POEError error) : base(error)
        {
            RateLimits = new List<POERateLimit>();
        }
    }
}