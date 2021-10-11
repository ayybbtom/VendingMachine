using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    public static class MainMenu
    {

        public static void Display(VendingMachine vendingMachine, Money money, Logger logger)
        {

            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine();
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase"); 
                Console.WriteLine("(3) Exit");
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                string input = (Console.ReadLine());

                if (input == "1")
                {
                    Console.WriteLine("Vending machine stock displayed below. Hit Enter to return to the main menu.");
                    vendingMachine.DisplayAllInventory();
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    PurchaseMenu.PurchaseDisplay(vendingMachine, money, logger);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Thank you! Come back soon.");
                    Logger.WriteLogToFile(logger.TotalSessionLog, logger);
                    System.Environment.Exit(1);
                }
                else if (input == "4")
                {
                    // Functionality not fully implemented.
                    // Initial report generates, and flow works properly when preexisting report is accessed
                    // Missing feature: add current vendingMachine sales info & total sales $ amt to current version of report
                    
                    // NOTE: SalesReport incorporates vestigal code from pre-vendingMachine.Inventory code
                    // This is why items are accessed from stream read/writes
                    
                    // Goal: Implement FileHandler into SalesReport class, so only one class handles all streams
                    // Addtl Goal: Merge preexisting salesreport with current vendingMachine inventory info, per above.

                    Console.WriteLine("Accessing Sales Report.");
                    SalesReport.WriteCheckSalesReport(SalesReport.GenerateSalesReport(vendingMachine, money));
                    Console.WriteLine("Sales Report generated.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}
