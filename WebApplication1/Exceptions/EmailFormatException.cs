using System;
using System.Runtime.Serialization;

namespace WebApplication1.Models
{
    [Serializable]
    internal class EmailFormatException : Exception
    {
        public EmailFormatException()
        {
        }

        public EmailFormatException(string message) : base(message)
        {
        }

        public EmailFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmailFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}