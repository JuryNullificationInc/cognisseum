namespace webapi.Exceptions
{
    public class UnsuccessfulConversionException : Exception
    {
        public UnsuccessfulConversionException(string convertedObject, string callingObject, long callingId, string reason) 
            : base($"Error converting ${convertedObject} for {callingObject} with ID {callingId} for reason: {reason}")
        {
        }
    }
}
