using System;
using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE
{
    public class POEException : Exception
    {
        public POEException(POEError error)
        {
            Error = error;
        }

        public POEError Error { get; }
    }
}