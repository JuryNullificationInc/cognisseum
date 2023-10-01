using System.Net;

namespace webapi.Exceptions.ExceptionBases
{
    public class BadRequestExceptionBase : Exception, IServiceExceptionBase
    {
        public HttpStatusCode StatusCode { get; set; }

        public BadRequestExceptionBase(string message) : base(message)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
    }
}
