using System.Runtime.Serialization;

namespace SnakeGame.exception
{
    [Serializable]
    public class NonExistingBonusPositionException : Exception
    {
        public NonExistingBonusPositionException()
        {
        }

        public NonExistingBonusPositionException(string? message) : base(message)
        {
        }

        public NonExistingBonusPositionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NonExistingBonusPositionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}