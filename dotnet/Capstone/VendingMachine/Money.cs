using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Money
    {
        public decimal CurrentBalance { get; private set; } //= 0.00M;

        public void MakeChange(Money money)
        {
            decimal quarterValue = 0.25M;
            decimal dimeValue = 0.10M;
            decimal nickelValue = 0.05M;
            decimal pennyValue = 0.01M;

            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;
            int numPennies = 0;

            decimal amountToBreak = money.CurrentBalance;

            while (amountToBreak > 0)
            {
                if ((amountToBreak / quarterValue >= 1))
                {
                    numQuarters += (int)(amountToBreak / quarterValue);
                    amountToBreak -= (numQuarters * quarterValue);
                }
                else if (amountToBreak / dimeValue >= 1)
                {
                    numDimes += (int)(amountToBreak / dimeValue);
                    amountToBreak -= (numDimes * dimeValue);
                }
                else if (amountToBreak / nickelValue >= 1)
                {
                    numNickels += (int)(amountToBreak / nickelValue);
                    amountToBreak -= (numNickels * nickelValue);
                }
                else
                {
                    numPennies += (int)(amountToBreak * 100);
                    amountToBreak -= (decimal)(numPennies * pennyValue);
                }
            }
            //working - need to confirm formatting
            Console.WriteLine($"Num quarters given: {numQuarters}");
            Console.WriteLine($"Num dimes given: {numDimes}");
            Console.WriteLine($"Num nickels given: {numNickels}");
            Console.WriteLine($"Num pennies given: {numPennies}");
            Console.WriteLine($"Remaining balance is: {amountToBreak}");

            money.CurrentBalance = 0.00M;

        }

        public void FeedMoney(decimal inputBill)
        {
            // only accepts $1, 2, 5, 10 bills
            // get currentbalance
            // set to currbal + inputbill

            CurrentBalance += inputBill;

            }
        public bool PerformPriceCheck(decimal itemPrice)
        {
            //helper method - called to prevent "muddying up" other method bodies
            //returns True if Balance >= priceCheck
            //returns False if Balance < priceCheck

            if (itemPrice <= this.CurrentBalance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    
        public void RemoveMoney(decimal amountToRemove)
        {

            this.CurrentBalance -= amountToRemove;
            
        }
    }
    
}
