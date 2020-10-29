using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
        readonly string message;
        public MoodAnalyserException(string message)
        {
            this.message = message;
        }
    }
}
