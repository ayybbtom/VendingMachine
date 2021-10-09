using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.VendingMachine
{
    public static class FileHandler
    {

        public static Queue<string> FileReader(string filePath)
        {
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


        public static void InventoryStocker(VendingMachine vendingMachine)
        {
            //Takes input from Filereader and converts it to correct format to feed into VendingMachine
            //INPUT - A1|Potato Crisps|3.05|Chip - INPUT
            //PRODUCT Candy(string sound, decimal price, string name, string slotLocation) - PRODUCT EX CLASS
            //VENDING MACHINE - Inventory - string: product name : int: # of product in vend. mach.

            // Factory Pattern implementation would be optimal to scale this project up to more than 4 datatypes
            // However due to time constraints we will opt for finite-number Switch-Case handling.
            //Type.GetType(type) name = new Type.GetType(type)(GetType(type).Sound, price, name, location);


            Queue<string> inventoryToUnpack = FileReader(@"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv");
            string[] unpackedProduct = new string[4];
            const int InitialStockCount = 5;
            VendingMachine vendingMachine = new VendingMachine();

            foreach (string product in inventoryToUnpack)
            {
                unpackedProduct = product.Split("|");

                string location = unpackedProduct[0].ToString();
                string name = unpackedProduct[1].ToString();
                decimal price = decimal.Parse(unpackedProduct[2]);
                string productType = unpackedProduct[3].ToString();

                switch (productType)
                {
                    case "Candy":
                        vendingMachine.Inventory.Add(new Candy(price, name, location), InitialStockCount);
                        continue;
                    case "Chip":
                        vendingMachine.Inventory.Add(new Chip(price, name, location), InitialStockCount);
                        continue;
                    case "Drink":
                        vendingMachine.Inventory.Add(new Drink(price, name, location), InitialStockCount);
                        continue;
                    case "Gum":
                        vendingMachine.Inventory.Add(new Gum(price, name, location), InitialStockCount);
                        continue;
                }
            }
        }

        public static void LogWriter(Queue<string> totalSessionLog)
        {
            // use this method to format log files - might be able to completely get rid of FileWriter method and replace it w/ LogWriter & SalesReportWriter
            foreach (string log in TotalSessionLog)
            {
                //no need dequeue method - foreach handles "unloading of logs" from TotalSessionLog
                //try
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
        }
        public static void SalesReportWriter()
        {
            // use this method to format sales report files - might be able to completely get rid of FileWriter method and replace it w/ LogWriter & SalesReportWriter
        }







    }
}