using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capstone.VendingMachine
{
    [TestClass]
    public class VendingMachineTests
    {


        //StockVendingMachine was tested in FileHandlerTests due to extreme dependency on that class.
        //This is yet another painful lesson in why unit testing must be considered when framing projects.
        //Additionally, earlier & more frequent attempts to write unit tests could have avoided this.

        //Same goes for RunVendingMachine - this time, dependent on MainMenu class (specifically .Display() method)

        //[TestMethod]
        //public void DisplayAllInventory_Test_DisplayAbility()
        //{
        //    Money money = new Money();
        //    Logger logger = null;
        //    VendingMachine vendingMachine = new VendingMachine(money, logger);

        // due to Public Set property Inventory (meant to be accessed via FileHandler - once - to set inventory, then 
        // subsequently by other vendingMachine method PurchaseItem - this cannot be tested in our typical fashion.

        // It is abundantly clear that our design requires major refactoring to become testable.

        //vendingMachine.Inventory = new Dictionary<Product, int>()
        //{
        //    { new Candy(0,"",""), 5},
        //    { new Drink(0,"",""), 5},
        //    { new Chip(0,"",""), 5},
        //    { new Gum(0,"",""), 5}
        //};

        //Assert.AreEqual

        //Expected: $"{"#"} -- {"Stock"} -- {"Product"} -- {"Price"}"
        //In order: Item.SlotNumber, Inventory.Value, Item.Name, Item.Price

        //Manual testing demonstrated that this method worked sufficiently - fed items from input .csv file.
        //}
        //[TestMethod]
        //public void PurchaseItemTests_InputNumberLessOrEqualToInventoryAmt_ExpectSuccessfulSet()
        //{ 
        //// PurchaseItem method worked successfully - input a Product name "choiceInVM", ability is gained to
        //// set value of vendingMachine.Inventory[choiceInVM] - this is intended.
        //// Tested PurchaseItem manually - handles -= or += of <= the Inventory[choiceInVM] qty, as expected.
        //}  

        //}


        //[TestMethod]
        //public void IfItemExists_InputBothRealAndFakeItems_ExpectTrueAndFalseRespectively()
        //{ 
        //Arranged vendingMachine.Inventory to hold items listed in input.csv file
        //Called IfItemExists method using some randomly-chosen Products from this .csv to confirm method works.
        //Expected: True - successful acquisition of item. Actual: True - successful acquisition of item.
        //Input of false item (ex: "Scoby", 12393357, -1, and "false" - expect False - actual False
        // Manual tests prove method works as intended.
        //}


    }
}
