using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalesReport.WriteCheckSalesReport();

            Money money = new Money();
            Queue<string> totalSessionLog = new Queue<string>();
            Logger logger = new Logger(totalSessionLog);
            VendingMachine vendingMachine = new VendingMachine(money, logger);

            vendingMachine.StockVendingMachine(vendingMachine);
            MainMenu.Display(vendingMachine, money, logger);


        }
    }
}
