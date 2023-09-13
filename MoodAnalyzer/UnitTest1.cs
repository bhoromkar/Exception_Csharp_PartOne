using ExceptionProblem;

using CustomExceptionproblem;

namespace MoodAnalyzer1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {//
         //arrange
            string excepted = "SAD";
            string message = "I am In a sad  Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //act
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(excepted, mood);

        }/*
        [TestMethod]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {//
         //arrange
            string excepted = "HAPPY";
            // string message = "I am In a sad  Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //act
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(excepted, mood);

        }
        */
        [TestMethod]
        [DataRow("I am In Happy Mood")]
        public void GivenEmptymoodshouldReturnEmptyMessage(string message)
        {//
         //arrange
            try
            {
                string excepted = " ";
                // string message = "I am In a sad  Mood";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyzeMood();
                //act
            }
            catch (CustomException e)
            {

                Assert.AreEqual("Mood Should Not Be Empty", e.message);

            }
        }
    }
}