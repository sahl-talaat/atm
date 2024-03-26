using System;
using System.ComponentModel;
//using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class Validator
    {
        /* public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;
            while (!valid)
            {
                userInput = Utility.GetUserInput(prompt);
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return default;
        } */

        public static T Convert<T>(string prompt)
{
    bool valid = false;
    string userInput;
    while (!valid)
    {
        userInput = Utility.GetUserInput(prompt);
        try
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter != null)
            {
                return (T)converter.ConvertFromString(userInput);
            }
            else
            {
                return default;
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }
    return default;
}

    }
}