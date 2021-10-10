using System;

namespace Capstone.VendingMachine
{
    public static class PurchaseMenu
    {
        public static void PurchaseDisplay(VendingMachine vendingMachine, Money money)
        {
            // idea: substitute "true" for sentinel variable
            // flip when option 4 is chosen (from true -> false)
            Console.Clear();
            
            while (true)
            {
                
                Console.WriteLine("\nPlease select an option: ");
                Console.WriteLine($"{money.CurrentBalance.ToString("C")} + Current Money Provided");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");

                string mainPurchaseMenuInput = Console.ReadLine();
                bool isOperatingPurchaseDisplay = true;

                // need to handle bad inputs here


                while (isOperatingPurchaseDisplay)
                {
                    if (mainPurchaseMenuInput == "1")
                    {
                        Console.WriteLine("Amounts to enter: 1, 2, 5, 10.");
                        string feedMoneyInput = Console.ReadLine();

                        if (feedMoneyInput == ("1") || feedMoneyInput == ("2") || feedMoneyInput == ("5") || feedMoneyInput == ("10"))
                        {
                            money.FeedMoney(decimal.Parse(feedMoneyInput));
                        }
                        else
                        {
                            Console.WriteLine("Please enter a whole dollar amount.");
                        }
                        break;
                    }

                    else if (mainPurchaseMenuInput == "2")
                    {
                        while (true)
                        {
                            vendingMachine.DisplayAllInventory();
                            Console.WriteLine();
                            Console.WriteLine($"{money.CurrentBalance.ToString("C")}");
                            Console.WriteLine("Please select an item: ");

                            string choiceAlphaNumeric = Console.ReadLine();
                            Product choiceInVM = vendingMachine.GetVendingItem(choiceAlphaNumeric);

                            if (vendingMachine.IfItemExists(choiceAlphaNumeric))
                            {
                                if (vendingMachine.Inventory[choiceInVM] == 0)
                                {
                                    Console.WriteLine($"{choiceInVM.Name} is sold out");
                                    break;
                                }
                                else if (!money.PerformPriceCheck(choiceInVM.Price))
                                {
                                    Console.WriteLine($"Not enough Money for {choiceInVM.Name}.");
                                    break;
                                }
                                else
                                { 
                                    // need to call vendingmachine.getitem();
                                    // need to update balance
                                    Console.WriteLine($"\nDispensing {choiceInVM.Name}...");
                                    Console.WriteLine(choiceInVM.Sound);
                                    PurchaseDisplay(vendingMachine, money);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select another item");
                            }
                       }

                    }

                    else if (mainPurchaseMenuInput == "3")
                    {
                        // get it to run back to opening menu, with money set to 0 and inventory restocked
                        Console.WriteLine("Transaction finished.");
                        Console.WriteLine("Dispensing change...");
                        money.MakeChange(money);
                        Console.WriteLine("Exiting to Main Menu");
                        isOperatingPurchaseDisplay = false;
                    }
                    else
                    {
                        Console.WriteLine("Not valid option. Please try again");
                        break;
                    }
        }
        }
    }
    }
}

