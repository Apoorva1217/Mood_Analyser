using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Method for SAD Mood
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
        /// Test Method for HAPPY Mood
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
        /// Test Method for SAD Message constructor
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
        /// Test Method for HAPPY Message constructor
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
        /// Test Method to Handle Null Exception
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
        /// Test Method to Handle Exception for Null Message
        /// </summary>
        [TestMethod]
        public void GivenMood_WhenNullMessage_ShouldThrowException()
        {
            try
            {
                MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain();
                string mood= moodAnalyserMain.AnalyseMood("NULL");
            }
            catch(MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        /// <summary>
        /// Test Method to Handle Exception for Empty Message
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
    }
}