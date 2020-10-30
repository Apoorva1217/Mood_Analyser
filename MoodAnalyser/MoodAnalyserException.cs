using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
        /// <summary>
        /// Enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            ENTERD_NULL,ENTERD_EMPTY,NO_SUCH_METHOD_NO_SUCH_FIELD,NO_A_VALID_INPUT
        }

        /// <summary>
        /// Creating 'type' variable of type ExceptionType
        /// </summary>
        ExceptionType type;
        readonly string message;

        /// <summary>
        /// Parameterized constructor sets the exception type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MoodAnalyserException(ExceptionType type,string message):base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}