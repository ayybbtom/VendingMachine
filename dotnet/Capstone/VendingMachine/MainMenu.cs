using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    public static class MainMenu
    {
        public VendingMachine vm;
        public PurchaseMenu pm;
        public static void Display()
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
                    vm.DisplayAllInventory();
                    Console.WriteLine();
                }
                else if(input == "2")
                {
                    pm.PurchaseDisplay();

                }
                else if(input == "3")
                {
                    Console.WriteLine("Thank you! Come back soon.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}
