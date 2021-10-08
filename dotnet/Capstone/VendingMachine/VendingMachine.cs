using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{

    public class VendingMachine
    {
        #region Properties

        // Inventory - string: product name : int: # of product in vend. mach.
        public Dictionary<Product, int> Inventory { get; private set; } = new Dictionary<Product, int>();

        //public decimal Balance { get; set; }
        //public string Logger { get; set; }

        //do we need userinterface anymore?
        //public Dictionary<string, string> UserInterface { get; private set; } = new Dictionary<string, string>();

        #endregion

        #region Constructors
        public VendingMachine()
        {
        }


        #endregion

        #region Methods
        public void VendingMachineStocker()
        {
            FileHandler.InventoryStocker();
        }
        public void RunVendingMachine()
        {
            Menu.Display();
            //VendingMachine.PurchaseStuff();
        }
        public void DisplayAllInventory() { }

    }
}
        #endregion