using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserMain
    {
        readonly string message;

        /// <summary>
        /// Refactor the code to take the mood message in default constructor
        /// </summary>
        public MoodAnalyserMain()
        {
        }

        /// <summary>
        /// Refactor the code to take the mood message in parameterized constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyserMain(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// UC 1 Ability to analyse and respond Sad or Happy Mood
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood(string message)
        {
            try
            {
                ///UC 3 Inform user if entered Invalid Mood
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERD_EMPTY, "Mood should not be Empty");
                }
                if (message.Contains("I am in SAD Mood"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERD_NULL, "Mood should not be NULL");
            }
        }
        public string AnalyseMood()
        {
            return AnalyseMood(this.message);
        }
    }
}