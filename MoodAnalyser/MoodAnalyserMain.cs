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
                ///TC 3.2 Given Empty Mood should throw MoodAnalyserException indicating Empty Mood
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERD_EMPTY, "Mood should not be Empty");
                }
                ///TC 1.1 Given "I am in Sad Mood" message should return SAD
                if (message.Contains("I am in SAD Mood"))
                {
                    return "SAD";
                }
                ///TC 1.2 Check AnalyseMood method for SAD or else return HAPPY
                else
                {
                    return "HAPPY";
                }
            }
            ///TC 3.1 Given NULL Mood should throw MoodAnalyserException indicating NULL Mood
            catch (MoodAnalyserException e)
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