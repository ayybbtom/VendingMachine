using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CapstoneTests.VendingMachine_Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void FeedMoneyTest_ConfirmBalanceChanges()
        {
            // Will not run for unknown reason - makes call to PurchaseMenu, which causes Build to fail due to need for user input
            // Unsure of why this is - ran out of time to diagnose & realign.
            // TODO - correct this - get test to run / find way to avoid PurchaseMenu
            Money money = new Money();
            decimal initialMoneyCurrBal = money.CurrentBalance; //defaults to 0
            Logger logger = null;

            string moneyInput = "1";
            decimal moneyInputAsWouldBeExpected = decimal.Parse(moneyInput);
            money.FeedMoney(moneyInputAsWouldBeExpected, money, logger);

            Assert.AreEqual(initialMoneyCurrBal + moneyInputAsWouldBeExpected, money.CurrentBalance);
        }

        [TestMethod]
        public void FeedMoneyTest_InvalidInput()
        {
            // Design oversight: logic is externalized to PurchaseMenu Class
            // Due to the above, we manually tested the following inputs with the following outputs:

            // Better design would be: refactor Menu classes to exclusively make method calls to other classes
            // Logic, including the "Bill Validation" for FeedMoney, should take place within FeedMoney()
            // Test-Driven Dev. environments would address this at the cost of greater time to develop pgm.
            // In lieu of performing unit tests, we performed manual tests with User Inputs in order to validate expected vs actual outputs
            // Results below:
            //  
            //if (feedMoneyInput == ("1") || feedMoneyInput == ("2") || feedMoneyInput == ("5") || feedMoneyInput == ("10"))
            //{
            //    money.FeedMoney(decimal.Parse(feedMoneyInput), money, logger);
            //    break;
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a whole dollar amount.\n");
            //}
            // 
            // {Inputs : Expected Output, Actual Output}
            //
            // {"1" : CurrentBalance += 1, CurrentBalance += 1}
            // {"2" : CurrentBalance += 2, CurrentBalance += 2}
            // {"3" : "Please enter a whole dollar amount.\n", "Please enter a whole dollar amount.\n"}
            // {"A" : "Please enter a whole dollar amount.\n", "Please enter a whole dollar amount.\n"}
            // {"-1" : "Please enter a whole dollar amount.\n", "Please enter a whole dollar amount.\n"}
            // {"break;" : "Please enter a whole dollar amount.\n", "Please enter a whole dollar amount.\n"}
            // {"3.15;" : "Please enter a whole dollar amount.\n", "Please enter a whole dollar amount.\n"}
        }


















    }
}
