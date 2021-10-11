using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.VendingMachine
{
    public class SalesReport
    {
        public Dictionary<string, int> SalesReportData { get; private set; }

        public SalesReport()
        {
        }

        public SalesReport(Dictionary<string, int> salesReportData)
        {
            SalesReportData = salesReportData;
        }





        public static void WriteCheckSalesReport(Dictionary<string, int> outgoingSalesReport)
        {
            string inputFile = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\vendingmachine.csv";
            string createOutputFile = @"C:\Users\Student\workspace\orange-mod1-capstone-team2\dotnet\SalesReport.csv";

            decimal totalSales = 0.00M;

            Dictionary<string, int> salesReportData = new Dictionary<string, int>();
            var lines = File.ReadAllLines(inputFile);
            SalesReport salesReport = new SalesReport(salesReportData);                                                     

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
                            salesReportData.Add(Convert.ToString(valuesSR[1]), 0);
                        }
                        else
                        {
                            Console.WriteLine("Input.csv not found");
                        }
                    }
                }
                using (StreamWriter createSR = new StreamWriter(createOutputFile))
                {
                    foreach (KeyValuePair<string, int> kvps in salesReportData)
                    {
                        createSR.WriteLine($"{kvps.Key}|{kvps.Value}");
                    }
                    createSR.WriteLine($"\n*** TOTAL SALES ***");
                    createSR.WriteLine($"${totalSales}");
                }
            }
            else 
            {
                Dictionary<string, int> existingSalesReport = new Dictionary<string, int>();
                decimal totalSaleFromOldReport = 0.00M;

                using (StreamReader readInSalesReport = new StreamReader(createOutputFile))
                {

                    while (!readInSalesReport.EndOfStream)
                    {
                        string line = readInSalesReport.ReadLine();

                        if (line.Contains("***"))
                        {
                            break;
                        }
                        else if (line.Contains("$"))
                        {
                            line = readInSalesReport.ReadLine();
                            totalSaleFromOldReport = decimal.Parse(line.Substring(1));

                            break;
                        }
                        if (line.Equals(""))
                        {
                            break;
                        }
                        string[] lineContents = line.Split("|");

                        existingSalesReport[lineContents[0]] = int.Parse(lineContents[1]);
                    }

                }


                using (StreamWriter updateSalesReport = new StreamWriter(createOutputFile))
                {
                    foreach (KeyValuePair<string, int> kvps in existingSalesReport)
                    {
                        updateSalesReport.WriteLine($"{kvps.Key}|{kvps.Value}");
                    }
                    updateSalesReport.WriteLine($"\n*** TOTAL SALES ***");
                    updateSalesReport.WriteLine($"${totalSaleFromOldReport}");

                }
            }
        }


        public static Dictionary<string, int> GenerateSalesReport(VendingMachine vendingMachine, Money money)
        {
            Dictionary<string, int> outgoingSalesReport = new Dictionary<string, int>();
            foreach (KeyValuePair<Product, int> vendingItem in vendingMachine.Inventory)
            {
                int initialStockCount = 5;
                Product itemName = vendingItem.Key;
                int numItemsSold = initialStockCount - vendingMachine.Inventory[itemName];

                outgoingSalesReport[itemName.ToString()] = numItemsSold;
                

            }
            return outgoingSalesReport;


        }

    }
}
