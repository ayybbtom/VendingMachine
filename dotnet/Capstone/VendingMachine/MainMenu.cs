using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    public static class Menu
    {
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
                    VendingMachine.AllVendingItems();
                    Console.WriteLine();

                }
                else if(input == "2")
                {
                    PurchaseMenu purchaseMenu = new PurchaseMenu();
                    purchaseMenu.Show();

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
