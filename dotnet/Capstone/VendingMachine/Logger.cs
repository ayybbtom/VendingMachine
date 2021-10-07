using System;
using System.Collections.Generic;
using System.Text;
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
            DateTime date = DateTime.UtcNow;
            string dateLong = date.ToString("G");
            //moneyBefore
            //moneyAfter
            //item
            TotalSessionLog = totalSessionLog;


        }
        public void GenerateLogEntry()
        {
            // generate singleLogEntry given parameters on Balance from call in Vending Machine
            // Write generated single line log entry into log array
            //string singleLogEntry = ($"{date} {datelong} {moneyBefore} {moneyAfter}");
        }
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



    }
}
