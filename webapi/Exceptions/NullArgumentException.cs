using System.Net;
using webapi.Exceptions.ExceptionBases;

namespace webapi.Exceptions
{
    public class NullArgumentException : BadRequestExceptionBase
    {
        public NullArgumentException(string fileName, string funcName, string funcArg) : base($"{funcName} in {fileName} was not expecting null value for {funcArg}")
        {

        }
    }
}
