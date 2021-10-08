using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.VendingMachine
{
    public class FileHandler
    {
        public Queue<string> FileReader ()
        {
            // read files in here
            string filePath = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv";
            string line = "";
            Queue<string> lineInputQueue = new Queue<string>();

            try
            {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                        line = sr.ReadLine();
                        lineInputQueue.Enqueue(line);
                        }
                    }
                
                return lineInputQueue;
            }
            catch (IOException ex)
            {
                Console.WriteLine("File not found. Please try again.");
                return lineInputQueue;
            }

        }


        //public static void FileWriter(string filepath)
        //{      
        //    // taken from Logger - will need to generalize for use in Sales Report & for Logging
        //    // will need to delete from Logger
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
