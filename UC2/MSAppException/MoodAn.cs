using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAppException
{
    public class MoodAn
    {
        private string message;

        public MoodAn(string message)
        {
            this.message = message;
        }


        public string AnalyzeMood()
        {

            try
            {


                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }

                else
                {
                    return "HAPPY";
                }
            }

            catch
            {
                return "HAPPY";
            }
        }




    }
}
