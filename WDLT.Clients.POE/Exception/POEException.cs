using WDLT.Clients.POE.Models;

namespace WDLT.Clients.POE.Exception
{
    public class POEException : System.Exception
    {
        public POEException()
        {

        }

        public POEException(POEError error)
        {
            Error = error;
        }

        public POEError Error { get; }
    }
}