using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


// every variable name needs to be checked
namespace Capstone
{
    public class Logger 
    {
        public void Log(string qweqweqwe)
        {
            DateTime date = DateTime.UtcNow;
            string dateLong = date.ToString("G");
            //moneyBefore
            //moneyAfter
            //item

            //fullLogString name needs changed! one line, could use collection - buffer hold all log entry
            string fullLogString = ($"{date} {datelomg} {moneyBefore} {moneyAfter}");

            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    sw.WriteLine(fullLogString);
                }
            }
            catch (IOException l)
            {
                Console.WriteLine(l.ToString());
            }

        }
        public void GenerateLogEntry()
        {
            
        }
    }
}
