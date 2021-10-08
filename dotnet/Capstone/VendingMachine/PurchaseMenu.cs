using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class PurchaseMenu
    {
        public Money money;
        public VendingMachine vm;

        public void PurchaseDisplay()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine($"{money.CurrentBalance.ToString("C")} + Current Money Provided");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine("(4) Exit ");
                
                string input = Console.ReadLine();
                decimal inputToDec;
                while(true)
                {
                    if (decimal.TryParse(input, out inputToDec))
                    {
                        if (input == "1")
                        {
                            Console.WriteLine($"{money.CurrentBalance.ToString("C")}: Current Money Provided");
                            Console.WriteLine("Amounts to enter: 1, 2, 5, 10.");
                            input = Console.ReadLine();
                            if (input == "1" || input == ("2") || input == ("5") || input == ("10"))
                            {
                                money.FeedMoney(inputToDec);
                                Console.WriteLine($"Current money provided: {money.CurrentBalance.ToString("C")}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a whole dollar amount.");
                            }

                        }
                        else if(input == "2")
                        {
                            while (true)
                            {
                                //display
                                Console.WriteLine("Please select an item. ex A1");
                                string productChoice = Console.ReadLine();
                            }
                            if (vm.
                            {

                            }
                            
                        }
                    }
                }
                
                
                



            }
        }
        
        
        
        //public static void InventoryItems(Dictionary<string, string> allInventory)
        //{
        //    foreach (KeyValuePair<string, string> nameLocation in allInventory)
        //    {
                
        //    }
        //}
    }
}
