

namespace BookApi.Application.Common.Exceptions
{
    public class AlreadyExistingException : Exception
    {
        public AlreadyExistingException() : base("Already exciting record!")
        {
        }

        public AlreadyExistingException(string? message) : base(message)
        {
        }

        public AlreadyExistingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
