using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public static class Menu
    {
        public static void Display()
        {   

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase"); //display submenu
                Console.WriteLine("(3) Exit");

                Console.WriteLine("sleect num");
                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: Console.WriteLine("Inventory Displayed Below"); return;
                    case 2:
                        {
                            PurchaseMenu.InventoryItems();
                        }
                        return;
                    case 3: Console.WriteLine("Thank you. Get lost."); return;
                    default: Console.WriteLine("Please select a valid input"); break;
                }

                //if (input == "1")
                //{
                //    Console.WriteLine("Items below: etc");
                //    //displayItems

                //}
                //else if(input == "2")
                //{
                //    PurchaseMenu purchaseMenu = new PurchaseMenu();
                //    purchaseMenu.InventoryItems();
                //}
                //else if(input == "3")
                //{
                //    Console.WriteLine("Thank you. Goodbye. Get out. Get Lost. Beat it.");
                //}
                //else
                //{
                //    if (!input == (1 || 2 || 3))
                //    {
                //        Console.WriteLine("Please select ana cceptable menu choice");
                //    };
                //}
            }
        }
        public void DisplayInventory()
        {

        }
    }
}
