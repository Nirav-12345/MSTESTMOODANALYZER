using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2TCN;

namespace MSTESTUC2TC2
{
    [TestClass]
    public class UnitTest1
    {

       
        [TestMethod]
        [DataRow("I am in Happy mood")]
        //[DataRow(null)]


        public void GivenSadShouldReturnSad(string message)
        {
            string expected = "HAPPY";


            UC2TC2 mood = new UC2TC2(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
    }
}