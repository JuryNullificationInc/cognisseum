using System.Net;

namespace webapi.Exceptions.ExceptionBases
{
    public interface IServiceExceptionBase
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
