using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2TCN
{
    public class UC2TC2
    {
        private string message;

        public UC2TC2(string message)
        {
            this.message = message;
        }


        public string AnalyzeMood()
        {

            try
            {


                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.Empty_Message, "Moodshoud not be empty");
                }


                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }

                else
                {
                    return "HAPPY";
                }
            }

            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }



    }
}
