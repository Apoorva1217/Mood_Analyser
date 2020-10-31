using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Case 1.1 Given "I am in Sad Mood" message should return SAD
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenSadMessage_ShouldReturnSAD()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain("I am in SAD Mood");
            //Act
            string mood = moodAnalyserMain.AnalyseMood();
            //Assert
            Assert.AreEqual("SAD", mood);
        }

        /// <summary>
        /// Test Case 1.2 Given "I am in Any Mood" message should return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenAnyMessage_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain("I am in ANY Mood");
            //Act
            string mood = moodAnalyserMain.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }

        /// <summary>
        /// Repeat Test Case 1.1 Given "I am in Sad Mood" message in constructor should return SAD
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenSadMessageWithConstructor_ShouldReturnSAD()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
            //Act
            string mood = moodAnalyserMain.AnalyseMood("I am in SAD Mood");
            //Assert
            Assert.AreEqual("SAD", mood);
        }

        /// <summary>
        /// Repeat Test Case 1.2 Given "I am in Any Mood" message in constructor should return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenAnyMessageWithConstructor_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
            //Act
            string mood = moodAnalyserMain.AnalyseMood("I am in ANY Mood");
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }

        /// <summary>
        /// Test Case 2.1 Given NULL Mood should return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenNullMessage_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
            //Act
            string mood = moodAnalyserMain.AnalyseMood("NULL");
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }

        /// <summary>
        /// Test Case 3.1 Given NULL Mood should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenNullMessage_ShouldThrowException()
        {
            try
            {
                MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
                string mood = moodAnalyserMain.AnalyseMood("NULL");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        /// <summary>
        /// Test Case 3.2 Given Empty Mood should throw MoodAnalyserException indicating Empty Mood
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenEmptyMessage_ShouldThrowException()
        {
            try
            {
                MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
                string mood = moodAnalyserMain.AnalyseMood(" ");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

        /// <summary>
        /// Test Case 4.1 Given MoodAnalyserMain class should return MoodAnalyserMain object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyserMain("NULL");
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserMain", "MoodAnalyserMain");
            expected.Equals(obj);
        }

        /// <summary>
        /// Test Case 4.2 Given Improper class name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.sampleClass", "MoodAnalyserMain");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        // <summary>
        /// Test Case 4.3 Given class when construcor not proper should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenClass_WhenConstructorNotProper_ShouldThrowMoodAnalyserException()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserMain", "sampleClass");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// <summary>
        /// Test Case 5.1 Given MoodAnalyser when proper message pass to parameterized constructor then return Mood Analyser object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyser_WhenProper_ReturnMoodAnalyseMainObject()
        {
            object expected = new MoodAnalyserMain("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyserMain", "MoodAnalyserMain","HAPPY");
            expected.Equals(obj);
        }

        // <summary>
        /// Test Case 5.2 Given Improper class name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserException_UsingParameterizedConstructor()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.sampleClass", "MoodAnalyserMain", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        // <summary>
        /// Test Case 5.3 Given Improper construcort name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalyserException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyserMain", "sampleClass", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}