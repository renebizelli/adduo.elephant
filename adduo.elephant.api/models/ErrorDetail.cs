using System.Net;
using System.Text.Json;

namespace adduo.elephant.api.models
{
    public class ErrorDetail
    {
        public HttpStatusCode StatusCode { get; private set; }
        public string Message { get; private set; }

        public ErrorDetail(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
