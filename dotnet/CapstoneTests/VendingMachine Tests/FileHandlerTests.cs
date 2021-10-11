using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests.VendingMachine_Tests
{
    [TestClass]
    public class FileHandlerTests
    {
        [TestMethod]
        public static void StockVendingMachineInventoryTests_ConfirmItemsAreImportedFromReadme()
        {
            Money money = new Money();
            Logger logger = null;
            VendingMachine vendingMachine = new VendingMachine(money, logger);
            

            Queue<string> simulatedInventoryToUnpack = {""}
            ItemVended itemVended = new Candy("Wonka Bar", 1.50M, 5);

            Assert.AreEqual(itemVended, item["B3"]);
        }


    }
}

//method to test importing from the csv and correctly parsed 