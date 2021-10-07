using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Money
    {
        public decimal CurrentBalance { get; private set; } = 0.00M;

        public void MakeChange()
        {
            // per readme
            //The customer's money is returned using nickels, dimes, and quarters (using the smallest amount of coins possible).
            decimal quarters = 0.25m;
            decimal dimes = 0.10m;
            decimal nickels = 0.05m;
        }

        public void FeedMoney(decimal inputBill)
        {
            // only accepts $1, 2, 5, 10 bills
            // get currentbalance
            // set to currbal + inputbill
            // return updated currbal
        }

        public bool CheckAvailableFunds(decimal priceCheck)
        {
            //helper method - called to prevent "muddying up" other method bodies
            //returns True if Balance >= priceCheck
            //returns False if Balance < priceCheck
            return false;
        }

    }
}
