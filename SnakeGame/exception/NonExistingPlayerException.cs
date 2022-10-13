using System.Runtime.Serialization;

namespace SnakeGame.exception
{
    [Serializable]
    public class NonExistingPlayerException : Exception
    {
        public NonExistingPlayerException()
        {
        }

        public NonExistingPlayerException(string? message) : base(message)
        {
        }

        public NonExistingPlayerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NonExistingPlayerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}