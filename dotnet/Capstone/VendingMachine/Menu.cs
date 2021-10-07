using System;

namespace Capstone.VendingMachine
{
    public static class Menu
    {
        public static void Display()
        {

            while (true)
            {
                Console.WriteLine("Hello! Please select an option: ");

                Console.WriteLine();
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase"); //display submenu
                Console.WriteLine("(3) Exit");

                var input = int.Parse(Console.ReadLine());

                //switch (input)
                //        {
                //            case 1: 
                //                Console.WriteLine("Inventory Displayed Below"); 
                //                VendingM
                //                return;
                //            case 2:
                //                {
                //                    PurchaseMenu.InventoryItems();
                //                }
                //                return;
                //            case 3: 
                //                Console.WriteLine("Thank you. Get lost."); 
                //                return;
                //            default: 
                //                Console.WriteLine("Please select a valid input"); 
                //                break;
                //        }

                //    }
            }
            //public void DisplayInventory()
            //{

        }
    }
}
