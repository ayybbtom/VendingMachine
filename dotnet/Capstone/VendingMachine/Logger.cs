using System;
using System.Collections.Generic;
using System.IO;


// every variable name needs to be checked
namespace Capstone
{
    public class Logger
    {

        public Queue<string> TotalSessionLog { get; private set; } = new Queue<string>();
        public string SingleLogEntry { get; private set; }

        public void Log(Queue<string> totalSessionLog)
        {
            string fullPath = Path.Combine(@"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\", "log.txt");

            DateTime date = DateTime.UtcNow;
            string dateLong = date.ToString("G");

            string moneyBefore = moneyBefore.ToString("C");
            string moneyAfter = moneyAfter.ToString("C");
            string message = message;

            string writeLogLine = ($"{dateLong} {message} {moneyBefore} {moneyAfter} ");


            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true)
                {
                    sw.WriteLine(writeLogLine);
            }
            }
            catch 
            {
                Console.WriteLine("Logging eror");
            }
        }
    }
}  



    //moneyBefore
    //moneyAfter
    //item
    TotalSessionLog = totalSessionLog;


        }
}
}
public void GenerateLogEntry()
{
    // "01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00"
    //string singleLogEntry = ($"{date} {datelong} {moneyBefore} {moneyAfter}");
    string singleLogEntry = "";



    FileHandler.LogWriter(TotalSessionLog);
    // generate singleLogEntry given parameters on Balance from call in Vending Machine
    // Write generated single line log entry into log array TotalSessionLog
    // return TotalSessionLog to FileHandler method WriteLogFile(input)
        //public void WriteLogToFile()
        //{
        //    //write entire log array into a file at designated output directory 
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter("Log.txt", true))
        //        {
        //            sw.WriteLine(//whole log array//);
        //        }
        //    }
        //    catch (IOException l)
        //    {
        //        Console.WriteLine(l.ToString());
        //    }
        //}

