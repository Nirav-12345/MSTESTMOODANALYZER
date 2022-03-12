using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSAppException;
using System.Reflection;
namespace MSTeSTException
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        [DataRow(null)]
        public void GivenSadShouldReturnSad(string message)
        {
            string expected = "HAPPY";
            

            MoodAn mood = new MoodAn(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
    }
}