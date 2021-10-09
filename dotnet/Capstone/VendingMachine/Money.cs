using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Money
    {
        public decimal CurrentBalance { get; private set; } //= 0.00M;

        public void MakeChange()
        {
            // per readme
            //The customer's money is returned using nickels, dimes, and quarters (using the smallest amount of coins possible).
            decimal quarterValue = 0.25m;
            decimal dimeValue = 0.10m;
            decimal nickelValue = 0.05m;

            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;


            decimal amountToBreak = CurrentBalance;

            while (amountToBreak > 0)
            {
                if ( (amountToBreak / quarterValue >= 1) )
                {

                }
                else if (amountToBreak / dimeValue> 0)


                amountToBreak -= COIN
            }
        }

        public void FeedMoney(decimal inputBill)
        {
            // only accepts $1, 2, 5, 10 bills
            // get currentbalance
            // set to currbal + inputbill
            // sets updated currbal

            switch (inputBill)
            {
            CurrentBalance += inputBill;


            }
        public static bool CheckAvailableFunds(string priceCheck)
        {
            
            //helper method - called to prevent "muddying up" other method bodies
            //returns True if Balance >= priceCheck
            //returns False if Balance < priceCheck
            return false;
        }

        }

        
    }
}
