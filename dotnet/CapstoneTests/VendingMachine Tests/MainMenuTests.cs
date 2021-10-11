using System;
using System.Collections.Generic;
using System.Text;
using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests.VendingMachine_Tests
{
    public class MainMenuTests
    {
        // Due to MainMenu relying heavily on UserInput, we opted to Manually Test this Class.
        // We performed manual tests with self-supplied User Inputs in order to validate expected vs actual outputs
        // Results below:
        //  
        //if (input == ("1") || input == ("2") || input == ("3") || input == ("4"))
        //{
        // 1 - Expect vendingMachine.DisplayAllInventory()
        // 2 - Expect PurchaseMenu.PurchaseDisplay
        // 3 - Expect Logger.WriteLogToFile as well as System.Environment.Exit
        // 4 - Expect SalesReport to save to file - this is a hidden option, and thus not displayed as an option when MainMenu is called.
        //}
        // 
        // {Inputs : Expected Output, Actual Output}
        //
        // {"1" : Console.WriteLine in the following format (for each item in .csv input file) "{itemNumber} {itemStock} {itemName} ${itemPrice}" - Output was the same as expected.}
        // {"2" : CurrentBalance += 2, CurrentBalance += 2}
        // {"3" : Console.WriteLine "Thank you! Come back soon." Program ends in Terminal window. - WriteLine occurred exactly as intended, Program ended in terminal.}
        // {"4" : Console.WriteLine "Accessing Sales Report" "Sales Report generated - SalesReport.csv should show date modified of moment it was called.
        //          "Above printed correctly - SalesReport.csv Date Modified field in File Explorer was updated.}
        // {"A" : "Please enter a valid option.", "Please enter a valid option."}
        // {"-1" : "Please enter a valid option.", "Please enter a valid option."}
        // {"break;" : "Please enter a valid option.", "Please enter a valid option."}
        // {"3.15;" : "Please enter a valid option.", "Please enter a valid option."}
    }
}
