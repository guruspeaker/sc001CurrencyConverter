using System;
using System.Collections.Generic;

namespace sc001CurrencyConverter
{
    public class CommonCurrencyConverter
    {
        string input; // to hold input
        public CommonCurrencyConverter(string userInput)
        {
            input = userInput;


        }
        // method to calculate the conversion and return the result

        public string ConvertCurrency()
        {
            var output = "";
            if (input.Length < 1)
                output = "Please Enter Number";

            else
            {
                try
                {
                    var results = Convert.ToDouble(input) * 0.86;
                    output = "$" + input + " = $eu" + results.ToString();
                }
                catch (Exception e)
                {
                    //var alert = UIAlertController.Create("Warning!", "Please enter a dollar amount!", UIAlertControllerStyle.Alert);
                    //alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                    //PresentViewController(alert, animated: true, completionHandler: null);
                    Console.WriteLine("Error in conversion" + e.Message);
                    output = "Please Enter Number";
                }
            }
            return output;
        }
    }
}