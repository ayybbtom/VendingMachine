using System;
using System.Collections.Generic;

namespace Capstone.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            FileHandler fileHandler = new FileHandler();
            Queue<string> files = fileHandler.FileReader();
            foreach (string line in files)
            {
                Console.WriteLine(line);
            }


        }
    }
}
