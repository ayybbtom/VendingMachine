using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests.VendingMachine_Tests
{
    class PurchaseMenuTests
    {
        [TestClass]
        public class PurchaseTests
        {

            // Due to PurchaseMenu relying heavily on UserInput, we opted to Manually Test this Class.
            // We performed manual tests with self-supplied User Inputs in order to validate expected vs actual outputs
            // Results below:
            //  
            //if (input == ("1") || input == ("2") || input == ("3")
            //{
            // 1 - Expect Feed Money to be called, looped over correctly
            // 2 - Expect Select Product to be called - first, displaying inventory of vendingMachine, then allowing choice to be made
            // 3 - Expect Finish Transaction to be called - dispense remaining balance as change (via money.makeChange)
            // then outputting various console output and returning to MainMenu,Display, passing along instances of money, vendingMachine, and logger
            //}
            // 
            // {Inputs : Expected Output, Actual Output}
            //
            // {"1" : Feed Money called, looped over correctly - able to operate each option and return to main menu once complete (see Money tests for more)
            // {"2" : Inventory items displayed, choices allowed to be made. Operated as expected. Traveled down various logical paths, including:
            //Price Check - successful call to money.PerformPriceCheck(vendingMachine[item entered].Price) - actual == expected for following conditions:
            // Price > Balance, Price == Balance, Price < Balance - all three operated as expected
            //Inventory Check - Successful call to vendingMachine.Inventory[choiceInVM] - checks available inventory int value and returns expected comparison of
            // inventory int > 0 - successfully changes display value to "SOLD OUT" when int == 0
            //Item Exists Check -  successfully called to vendingMachine.IfItemExists(choiceAlphanumeric) - behaved as expected for tests mentioned in VendingMachineTests.
            //Ability to purchase item if above three checks satisfied - successful calls to money.RemoveMoney and vendingMachine.GetVendingItem to decrease available balance
            // and item inventory as expected. 
            //
            // {"3" : Console.WriteLine "Thank you! Come back soon." Program ends in Terminal window. - WriteLine occurred exactly as intended, Program ended in terminal.}
            // {"4" : : "Please select another item.", "Please select another item."}
            // {"A" : "Please select another item.", "Please select another item."}
            // {"-1" : "Please select another item.", "Please select another item."}
            // {"break;" : "Please select another item.", "Please select another item."}
            // {"3.15;" : "Please select another item.", "Please select another item."}

            [TestMethod]
            public void IfEnoughMoneyEntered_ReturnItemSuccess()
            {

                //  if: there's enough money currently in the machine, and enough stock of the item chosen, the class will
                // this class tests: if there's enough stock and money for the item
                // 
                //
                // Arrange:
                // 
                //
                //
                // Act:
                // Assert:


                VendingMachine vm = new VendingMachine();
                Money money = new Money();
                vm.GetVendingItem("C2");
                Assert.AreEqual("")
                string result = vm.messageWhenItemSuccessfullyVended


            }
    }
}
