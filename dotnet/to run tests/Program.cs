using System;

namespace to_run_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal CurrentBalance = 5.13M;
            
            decimal quarterValue = 0.25M;
            decimal dimeValue = 0.10M;
            decimal nickelValue = 0.05M;
            decimal pennyValue = 0.01M;

            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;
            int numPennies = 0;

            decimal amountToBreak = CurrentBalance;

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
                    numPennies += (int)(amountToBreak*100);
                    amountToBreak -= (decimal)(numPennies* pennyValue);
                }
            }
            Console.WriteLine($"Num quarters given: {numQuarters}");
            Console.WriteLine($"Num dimes given: {numDimes}");
            Console.WriteLine($"Num nickels given: {numNickels}");
            Console.WriteLine($"Num pennies given: {numPennies}");
            Console.WriteLine($"Remaining balance is: {amountToBreak}");
        }
    }
}
