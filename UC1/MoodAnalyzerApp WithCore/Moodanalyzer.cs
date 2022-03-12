using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerApp_WithCore
{
    public class Moodanalyzer
    {


        private string message;

        public Moodanalyzer(string message)
        {
            this.message = message;
        }


        public string AnalyzeMood()
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
    }
}
