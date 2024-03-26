using System;
//using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            // clear the console screen
            Console.Clear();
            // sets the title of the console
            Console.Title = "My ATM App";
            // sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;

            // set the welcome message
            Console.WriteLine("\n\n---------------------Welcome to My ATM APP---------------------\n\n");
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card, read the card number and validate it");

            Utility.PressEnterToContinue();
        } 
    }
}

