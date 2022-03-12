using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerApp_WithCore;


namespace MooDAnalyzerMSTESTWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadShouldReturnSad()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";

            Moodanalyzer mood = new Moodanalyzer(message);

            string moo = mood.AnalyzeMood(); 


            Assert.AreEqual(expected,moo);


        }
    }
}