using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CapstoneTests.VendingMachine_Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void FeedMoneyTest_ConfirmBalanceChanges()
        {
            Queue<string> queueString = new Queue<string>();
            Money money = new Money();
            Logger logger = new Logger(queueString);
            VendingMachine vendingMachine = new VendingMachine(money, logger);
            PurchaseMenu.PurchaseDisplay(vendingMachine, money, logger);


            decimal inputBill = 1.00M;

            decimal balanceBeforeChange = money.CurrentBalance;
            money.FeedMoney(inputBill, money, logger);
            decimal balanceAfterChange = money.CurrentBalance;
            
            Assert.AreEqual(balanceBeforeChange + inputBill, balanceAfterChange);

        }

        [TestMethod]
        public void FeedMoneyTest_InvalidInput()
        {
            // Design oversight: logic is externalized to PurchaseMenu Class
            // Due to the above, 


        }


















    }
}
