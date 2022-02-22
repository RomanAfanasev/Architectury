using System.Runtime.Serialization;

namespace AbstractModels
{
    [Serializable]
    internal class InitException : Exception
    {
        public InitException()
        {
        }

        public InitException(string? message) : base(message)
        {
        }

        public InitException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}