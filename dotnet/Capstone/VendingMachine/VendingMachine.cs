using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    
    public class VendingMachine
    {
        #region Properties

        // Inventory - string: product name : int: # of product in vend. mach.
        public Dictionary<T (where T:Product) , int> Inventory { get; private set; } = new Dictionary<T (where T:Product), int>();

        //public decimal Balance { get; set; }
        //public string Logger { get; set; }

        //do we need userinterface anymore?
        //public Dictionary<string, string> UserInterface { get; private set; } = new Dictionary<string, string>();

        #endregion

        #region Constructors
        public VendingMachine(Dictionary<string, int> inventory)
        {
            Inventory = inventory;
        }

        #endregion

        #region Methods
        public void VendingMachineStocker()
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.FileReader();
        }
        public void RunVendingMachine()
        {
            Menu.Display();
            //VendingMachine.PurchaseStuff();
        }
        public AllVendingItems()
        {
            vmAllItems = FileHandler.LocationOfList/Dictionary();
        } 
        public void DisplayAllItems()
    {
        //once file 
    }

        #endregion


    }
}
