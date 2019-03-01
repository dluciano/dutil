using System;
using System.Runtime.Serialization;

namespace Dutil.Core.Exceptions
{
    /// <summary>
    ///     This exception is thrown when trying to execute an invalid transition
    /// </summary>
    [Serializable]
    public class InvalidChangeTransition : Exception
    {
        public InvalidChangeTransition()
        {
        }

        public InvalidChangeTransition(string message) : base(message)
        {
        }

        public InvalidChangeTransition(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidChangeTransition(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}