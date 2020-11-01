using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// UC 4 Use Reflection to create Mood Analyser with default constructor
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
            }
        }

        /// <summary>
        /// UC5 Use Reflection to create Mood Analyser with Parameterized constructor
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message1)
        {
            Type type = typeof(MoodAnalyserMain);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { message1 });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }

        /// <summary>
        /// UC6 Use Reflection to Invoke Method
        /// </summary>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string InvokeMethod(string className, string methodName, string message)
        {
            Type type1 = typeof(MoodAnalyserMain);
            try
            {
                ConstructorInfo constructor = type1.GetConstructor(new[] { typeof(string) });
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor(className, methodName, message);
                Assembly excutingAssambly = Assembly.GetExecutingAssembly();
                Type type = excutingAssambly.GetType(className);
                MethodInfo getMoodMethod = type.GetMethod(methodName);
                string msg = (string)getMoodMethod.Invoke(obj, null);
                return msg;
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_A_VALID_INPUT, "No Such Method");
            }
        }
    }
}