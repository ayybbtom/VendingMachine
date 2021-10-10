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
        public VendingMachine()
        {
        }


        #endregion

        #region Methods
        public void StockVendingMachine(VendingMachine vendingMachine)
        {
            //Machine startup process
            // Instantiates vending machine & money

            FileHandler.StockVendingMachineInventory(vendingMachine);
            Money money = new Money();

            Console.WriteLine("Vending machine is stocked! Woo.");

            //foreach (KeyValuePair<Product, int> answers in vendingMachine.Inventory)
            //{
            //    Console.WriteLine(answers.Value);

            //}
            // also sets balance to 0 here

           
        }
        public void RunVendingMachine()
        {
            MainMenu.Display();
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
        //trying to get this to work below for this to be true to use in SubMenu option 2.

        //string 'Q4' input x
        //check it against vendingMachine.Inventory.keys().
        //foreach vendingMachine.Inventory.Keys()
        //    {
        //    if (Key.slotLocation == string input)
        //        {
        //        if true, item does exist
        //          once truth is determined, go to
        //          vendingMachine.Inventory[key] = value*
        //          we want this value*, this will be amt 
        //          of item that is in stock in the machine
        //          
        //

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
        //    public bool GetItem(string itemNumber)
        //    {
        //        if (this.IfItemExists(itemNumber) 
        //            && Money.PerformPriceCheck(itemNumber) >= Inventory.ContainsKey[itemPrice]
        //            && Inventory.ContainsValue > 0
        //            && vendingMachine[itemNumber].GetItem()
        //        {
        //            string message = ($"{Inventory.ContainsKey[itemNumber].itemPrice}");
        //            decimal moneyBefore = Money.PerformPriceCheck;

        //            Money.RemoveMoney(vendingMachine[itemNumber].itemPrice);

        //            decimal moneyAfter = Money.PerformPriceCheck;
        //            Logger.MethodToLogHere(DateTime.UtcNow, message, moneyBefore, moneyAfter);

        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

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
    }
}
#endregion