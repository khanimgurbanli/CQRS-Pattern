

namespace BookApi.Application.Common.Exceptions
{
    public class NotFoundRecordException : Exception
    {
        public NotFoundRecordException() : base("No result was found in accordance with the search! ")
        {
        }

        public NotFoundRecordException(string? message) : base(message)
        {
        }

        public NotFoundRecordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
