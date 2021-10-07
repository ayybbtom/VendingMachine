using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class VendingMachine
    {
        public Dictionary<string, int> Inventory { get; private set} = new Dictionary<string, int>();

        public decimal Balance { get; set }
        public string Logger { get; set; }


    }
}
