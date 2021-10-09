using System;

namespace Capstone.VendingMachine
{
    public class PurchaseMenu
    {
        public Money money;
        public VendingMachine vm;
        public void PurchaseDisplay()
        {
            // idea: substitute "true" for sentinel variable
            // flip when option 4 is chosen (from true -> false)
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
                while (true)
                {
                    if (decimal.TryParse(input, out inputToDec))
                    {
                        Console.WriteLine("Amounts to enter: 1, 2, 5, 10.");
                        Console.WriteLine($"{money.CurrentBalance.ToString("C")}: Current Money Provided");
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

                    //
                    //      else if (input == "2)
                    //
                    // 1 make sure item input is valid (Input matches slotLocation of a real item)
                    // 2 find item in vm.Inventory (using slotLocation, get name of item. use that to search vm.Inventory)
                    // 3 in vm.Inventory[item], check quantity (the value part of key-value pair)
                    // 4 if qty > 0, && balance > item.price -> allow sale to take place
                    // 5 sale: -1 to quantity, -price from balance

                    //call kvp contains name of item, instance of class product. 

                    //    else if (input == "2")
                    //    {
                    //        while (true)
                    //        {
                    //            vm.DisplayAllInventory();
                    //            Console.WriteLine();
                    //            Console.WriteLine("Please select an item: ");

                    //            string choice = Console.ReadLine();                               

                    //            if (vm.IfItemExists(choice) && vm.GetItem(choice))
                    //            {
                    //                Console.WriteLine($"{vm.Inventory[choice].itemName} {vm.Inventory[choice].SoundItMakesWhenWeNomNomNom}");
                    //                break;

                    //            else if (!vm.IfItemExists(choice))
                    //                {
                    //                    Console.WriteLine("Please select another item");

                    //                }
                    //            else if (vm.IfItemExists(choice) && (vm.Inventory.ContainsValue = 0)) ;
                    //            {
                    //                Console.WriteLine($"{vm.Inventory[choice]} is sold out");

                    //            }
                    //            else if (money.CurrentBalance < vm.Inventory[choice].itemPrice)
                    //            {
                    //                Console.WriteLine($"Not enough Money.");
                    //                    break;
                    //            }

                    //            }
                    //        }
                    //    }
                    //    else if (input == "3")
                    //    {
                    //        Console.WriteLine("Transaction finished.");
                    //        Console.WriteLine(money.MakeChange());
                    //    }
                    //    else if (input == "4")
                    //    {
                    //        Console.WriteLine("Exiting to Main Menu");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Not valid option. Please try again");
                    //    }
                    //}
                }
            }
        }
    }
}