using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{

    public class VendingMachine
    {
        #region Properties

        // Inventory - string: product name : int: # of product in vend. mach.
        public Dictionary<Product, int> Inventory { get; private set; } = new Dictionary<Product, int>();

        #endregion

        #region Constructors
        public VendingMachine(Money money)
        {
        }


        #endregion

        #region Methods
        public void StockVendingMachine(VendingMachine vendingMachine)
        {
            //Machine startup process
            // Instantiates vending machine & money

            FileHandler.StockVendingMachineInventory(vendingMachine);


            Console.WriteLine("Vending machine is stocked! Woo.");

        }
        public void RunVendingMachine(VendingMachine vendingMachine, Money money)
        {
            MainMenu.Display(vendingMachine, money);
            //VendingMachine.PurchaseStuff();
        }
        //display vending: item #, stock, name, price
        public void DisplayAllInventory()
        {
            Console.WriteLine($"{"#"} -- {"Stock"} -- {"Product"} -- {"Price"}");
            foreach (KeyValuePair<Product, int> dai in Inventory)
            {
                if (dai.Value > 0)
                {
                    var itemStock = dai.Value;
                    var itemNumber = dai.Key.SlotLocation;
                    var itemName = dai.Key.Name;
                    var itemPrice = dai.Key.Price;
                    Console.WriteLine($"{itemNumber} {itemStock} {itemName} '$'{itemPrice}");
                }
                else
                {
                    Console.WriteLine($"{dai.Key.Name} is Sold Out.");
                }
            }
        }

        public Product GetVendingItem(string itemNumber)
        {
            Product newProduct = new Chip(1.00M, "", ""); //null
            foreach (KeyValuePair<Product, int> vendingItem in this.Inventory)
            {
                Product workingKey = vendingItem.Key;
                if (workingKey.SlotLocation == itemNumber)
                {
                    newProduct = workingKey;
                }
            }
            return newProduct;
        }

        public bool IfItemExists(string itemNumber)
        {
            foreach (KeyValuePair<Product, int> vendingItem in this.Inventory)
            {
                Product workingKey = vendingItem.Key;
                if (workingKey.SlotLocation == itemNumber)
                {
                    return true;
                }
            }
            return false;
        }

        // this GetItem will first check if: item exists, money is >= machine current money, and if itemStock > 0
        // call money.methods here: current blanace, balance after
        // call log to write transaction

        // TO DO
        // handle the inventory change (eg -1 when you buy an item)

        public void PurchaseItem(Product choiceInVM)
        {
            //will only call after money.PerformPriceCheck - no need to check for funds here
            //will only call after vm.IfItmeExists - no need to check if item exists
            //will only call after item qty > 0 is checked - no need for that, either
            //money withdraw is handled separately, in money.RemoveMoney

            Inventory[choiceInVM] -= 1;

            // TO DO  Logger.CreateLog(DateTime.UtcNow, message, moneyBefore, moneyAfter);
            return;


        }
    }

        //}   // if: item exists, AND money is >= itemPrice AND >0 itemstock 
        //   // stirng message = (log $"datetime, action = "Itemname slotLocation", BalanceBeforeTransacation, BalanceAfterTransaction)
        //   // decimal moneybefore = money before
        //   // removemoney(vendingmachine.Inventory[itemNumber].price)
        //   // decimal moneyafter = money after
        //   // log(message, moneybefore, moneyafter)
        //   // return true;
        //   // else return false;

        //    if (Money.CheckAvailableFunds(price))
        //    {
        //    Money.RemoveMoney(price);
        //    //buy item - update inventory
        //    }
        //    else
        //    {
        //    Console.WriteLine("Sorry - you don't have enough money for that item.")
        //    }
    //}
}
#endregion