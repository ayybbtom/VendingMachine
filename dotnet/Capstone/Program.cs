using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalesReport.WriteCheckSalesReport();
            Console.WriteLine("Hello World!");
            Money money = new Money();
            VendingMachine vendingMachine = new VendingMachine(money);

            vendingMachine.StockVendingMachine(vendingMachine);
            MainMenu.Display(vendingMachine, money);


            //foreach (KeyValuePair<Product, int> inventory in vendingMachine.Inventory)
            //{
            //    Console.WriteLine($"Item: {inventory.Key.Name} with count: {inventory.Value}");
            //    Console.WriteLine($"Item is located in {inventory.Key.SlotLocation} and costs: {inventory.Key.Price}");
            //}

            //FileHandler fileHandler = new FileHandler();
            //Queue<string> files = fileHandler.FileReader();
            ////foreach (string line in files)
            //{
            //    Console.WriteLine(line);
            //}


        }
    }
}
