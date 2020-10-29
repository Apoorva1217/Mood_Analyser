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
        public void GivenSadMood_ShouldReturnSAD()
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
        public void GivenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalyserMain moodAnalyserMain = new MoodAnalyserMain("I am in ANY Mood");
            //Act
            string mood = moodAnalyserMain.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }
    }
}