using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    public static class MainMenu
    {
        //public VendingMachine vm;
        //public PurchaseMenu pm;
        public static void Display(VendingMachine vendingMachine, Money money, Logger logger)
        {

            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine();
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase"); //display submenu
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
                    // access sales report
                    //Console.WriteLine("Accessing Sales Report.");
                    //break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}
