using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{

    public class VendingMachine
    {
        #region Properties

        // Inventory - string: product name : int: # of product in vend. mach.
        public Dictionary<Product, int> Inventory { get; private set; } = new Dictionary<Product, int>();
        VendingMachine vendingMachine = FileHandler.InventoryStocker();

        #endregion

        #region Constructors
        public VendingMachine()
        {
        }


        #endregion

        #region Methods
        public void VendingMachineStocker()
        {

            Console.WriteLine();
            foreach (KeyValuePair<Product, int> answers in vendingMachine.Inventory)
            {
                Console.WriteLine(answers.Value);
                
            }


        }
        public void RunVendingMachine()
        {
            Menu.Display();
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
        public bool IfItemExists(string itemNumber)
        {
            return Inventory.ContainsKey(itemNumber);
            
        }
        // this GetItem will first check if: item exists, money is >= machine current money, and if itemStock > 0
        // call money.methods here: current blanace, balance after
        // call log to write transaction
        public bool GetItem(string itemNumber)

    }
}
#endregion