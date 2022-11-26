using System.Collections.Generic;
using System.Net;

namespace BuildingMaterialEStore.Messages.Response.Product
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Messages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Messages { get; set; }
    }
}
