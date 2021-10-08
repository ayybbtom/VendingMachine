using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.VendingMachine
{
    public class FileHandler
    {
        public string FilePath = { get; private set; } = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv";
       
    public Queue<string> FileReader ()
        {
            string filePath = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv";
            string line = "";
            Queue<string> lineInputQueue = new Queue<string>();

            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
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

     public string InventoryStocker(Queue<string> inventoryToUnpack)
    {
        // takes input from Filereader and converts it to correct format to feed into VendingMachine
        //INPUT - A1|Potato Crisps|3.05|Chip - INPUT
        //PRODUCT Candy(string sound, decimal price, string name, string slotLocation) - PRODUCT EX CLASS
        //VENDING MACHINE - Inventory - string: product name : int: # of product in vend. mach.

        string[] unpackedProduct = new string[4] { };
        const int InitialStockCount = 5;

        foreach (string product in inventoryToUnpack)
        {
            string unpackedProduct = product.Split("|");

            string location = unpackedProduct[0];
            string name = unpackedProduct[1];
            decimal price = unpackedProduct[2]M;
            string type = unpackedProduct[3];
            
            VendingMachine vendingMachine = new VendingMachine(parameters here)
            Type.GetType(type) name = new Type.GetType(type)(GetType(type).Sound, price, name, location);

            // (string sound, decimal price, string name, string slotLocation)


            VendingMachine.Inventory.Add(name, InitialStockCount);

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

        public static void LogWriter(Queue<string> totalSessionLog)
        {
            // use this method to format log files - might be able to completely get rid of FileWriter method and replace it w/ LogWriter & SalesReportWriter
            foreach (string log in TotalSessionLog)
            {
                //no need dequeue method - foreach handles "unloading of logs" from TotalSessionLog
                try
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
                }

        public static void SalesReportWriter()
        {
            // use this method to format sales report files - might be able to completely get rid of FileWriter method and replace it w/ LogWriter & SalesReportWriter
        }


        




    }
}
