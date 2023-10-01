namespace webapi.Exceptions
{
    public class IdLookupException : DbLookupException
    {
        public IdLookupException(string objectName, long objectId) : base(objectName, "Id", objectId.ToString())
        { }
    }
}
