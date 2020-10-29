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
        /// Refactor the code to take the mood message in constructor
        /// </summary>
        public MoodAnalyserMain() 
        {
        }

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
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException("HAPPY");
            }   
        }
        public string AnalyseMood()
        {
            return AnalyseMood(this.message);
        }
    }
}
