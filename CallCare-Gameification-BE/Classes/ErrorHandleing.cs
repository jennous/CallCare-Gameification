using System.Net;

namespace CallCare_Gameification_BE.Classes
{
    public class ErrorHandleing
    {
        public HttpStatusCode _Status { get; set; }

        public string _Message { get; set; }

        public ErrorHandleing(HttpStatusCode status, string error) { 
            
            _Status = status;
            _Message = error;
        }
    }
}
