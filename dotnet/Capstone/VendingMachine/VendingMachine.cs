using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class VendingMachine
    {
        #region Properties
        public Dictionary<string, int> Inventory { get; private set; } = new Dictionary<string, int>();

        public decimal Balance { get; set; }
        //public string Logger { get; set; }

        public Dictionary<string, string> UserInterface { get; private set; } = new Dictionary<string, string>();

        #endregion

        #region Constructors
        public VendingMachine(Dictionary<string, int> inventory, decimal balance, Dictionary<string, string> UserInterface)
        {




        }
        
        #endregion

        #region Methods
        public void DisplayInterface ()
        {
            for (int i = 0; i < )
            Console.WriteLine(");


        }

        public void RunVendingMachine()
        {
            Console.WriteLine("Hello! Please select an option: ");


            string interfaceInput = Console.ReadLine();
            
            DisplayInterface(interfaceInput);




        }


        #endregion


    }
}
