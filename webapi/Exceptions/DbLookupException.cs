using System.Net;
using webapi.Exceptions.ExceptionBases;

namespace webapi.Exceptions
{
    public class DbLookupException : BadRequestExceptionBase
    {
        public DbLookupException(string objectName, string columnName, string columnValue) : base($"Error finding {objectName} by lookup on {columnName} with {columnValue}")
        { 
        }
    }
}
