using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.VendingMachine
{
    //create sales report if not found
    //split items from input.csv, and put into dictionary to be posted to output SalesReport.csv. 
    //running the program again will overwrite the report. result should be sales report: name of item, type of item, and how many sold. 
    public class SalesReport
    {
        public static void WriteCheckSalesReport()
        {
            string inputFile = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv";
            string createOutputFile = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\SalesReport.csv";
            //string updatedOutputFile = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\SalesReport.csv";
           
            DateTime dateTime = DateTime.UtcNow;
            int startValueSold = 0;
            int totalItemsSold = 3;
            int itemsSoldInSession = 0; //change 0 to var 
            totalItemsSold += itemsSoldInSession;

            Dictionary<string, string> salesReport = new Dictionary<string, string>();
            var lines = File.ReadAllLines(inputFile);
                                                                      

            if (!File.Exists(createOutputFile))
            {
                using (StreamReader srSR = new StreamReader((inputFile)))
                {
                    while (!srSR.EndOfStream)
                    {
                        if (File.Exists(inputFile))
                        {
                            string itemsSR = srSR.ReadLine();
                            var valuesSR = itemsSR.Split("|");
                            salesReport.Add(Convert.ToString(valuesSR[1]), Convert.ToString(valuesSR[3]));
                        }
                        else
                        {
                            Console.WriteLine("Input.csv not found");
                        }
                    }
                }
                using (StreamWriter createSR = new StreamWriter(createOutputFile))
                {
                    createSR.WriteLine($"#### {dateTime} first accessed ####");
                    foreach (KeyValuePair<string, string> kvps in salesReport)
                    {
                        //rename when find var for TotalItemNumberSold
                        createSR.WriteLine($"{kvps.Key} | {kvps.Value} | {startValueSold}");
                    }
                }
            }
            else //use the live sessions dictionary to overwrite the file? with total items sold
            {
                Console.WriteLine("edit the dictionary on salesreport.cs if you're seeing this");
                //using (StreamWriter overwrite = new StreamWriter(createOutputFile))
                //{
                //    foreach (KeyValuePair<string, string> kvps in salesReport)
                //    {
                //        createSR.WriteLine($"{kvps.Key} | {kvps.Value} | {totalItemsSold}");
                //    }
                //    createSR.WriteLine($"#### {dateTime} first accessed ####");

                //}
            }
        }
    }
}
