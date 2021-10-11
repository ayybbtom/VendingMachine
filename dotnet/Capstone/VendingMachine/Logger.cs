using System;
using System.Collections.Generic;
using System.IO;


namespace Capstone.VendingMachine
{
    public class Logger
    {

        public Queue<string> TotalSessionLog { get; private set; } = new Queue<string>();
        public string SingleLogEntry { get; private set; }

        public Logger(Queue<string> totalSessionLog)
        {
            TotalSessionLog = totalSessionLog;
        }


        public static void WriteLogToFile(Queue<string> totalSessionLog, Logger logger)
        {
            string fullPath = Path.Combine(@"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\", "log.txt");

            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    foreach (string logLine in logger.TotalSessionLog)
                    {
                        sw.WriteLine(logLine);
                    }
                }
            }

            catch (IOException ex)
            {
                Console.WriteLine("Logging error");
            }
        }
        public static void GenerateMakeChangeLogEntry(decimal moneyToLogBefore, decimal moneyToLogAfter, Logger logger)
        {
            //"01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00"
            //string singleLogEntry = ($"{date} {datelong} {moneyBefore} {moneyAfter}");
            //string singleLogEntry = "";

            string logEntry = $"{DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm:ss tt")} GIVE CHANGE: ${moneyToLogBefore.ToString("0.00")} ${moneyToLogAfter.ToString("0.00")}";

            logger.TotalSessionLog.Enqueue(logEntry);
        }

        public static void GeneratePurchaseLogEntry(decimal moneyToLogBefore, decimal moneyToLogAfter, Logger logger, Product choiceInVM)
        {
            string logEntry = $"{DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm:ss tt")} {choiceInVM.Name} {choiceInVM.SlotLocation} ${moneyToLogBefore.ToString("0.00")} ${moneyToLogAfter.ToString("0.00")}";

            logger.TotalSessionLog.Enqueue(logEntry);
        }

        public static void GenerateFeedMoneyLogEntry(decimal moneyToLogBefore, decimal moneyToLogAfter, Logger logger)
        {
            string logEntry = $"{DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm:ss tt")} FEED MONEY: ${moneyToLogBefore.ToString("0.00")} ${moneyToLogAfter.ToString("0.00")}";

            logger.TotalSessionLog.Enqueue(logEntry);
        }

        public void WriteLogToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    foreach (string logLine in TotalSessionLog)
                    {
                        sw.WriteLine(logLine);
                    }
                }
            }
            catch (IOException l)
            {
                Console.WriteLine(l.ToString());
            }
        }
    }
}
        




