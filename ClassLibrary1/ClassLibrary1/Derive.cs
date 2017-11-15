using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    /*-------------------------------------------------------------------------------------------------------------------------
    * 
    * This class is used to Derive any one term in the form x^n. Maximum number of values received is two.
    * This is to account for the value that comes before x.
    * The structure for Derive is as follows --> Command:
    *                                            Derive [SPACE key] 'Coeffecient of x' [SPACE key] 'x^Exponenent'
    * Example-->                                 Derive 3 x^2 
    * 
    * -------------------------------------------------------------------------------------------------------------------------
    */
    //Property
    public class Derive : Computer
    {
        public string Name
        {
            get { return "Derive"; }
        }
        public double Execute(params string[] values)
        {
            int maxnbrvalues = 2;
            double i = 0;
            double d = 0;

            //'Derive' implements the Execute method declared by 'Computer'
            //This is how 'Derive' signs the contract with 'Computer'
            if (values.Length - 1 <= maxnbrvalues)
            {
                //Test to see if values received are of type
                //'double' and convert. Otherwise, show error.
                try
                {
                    double[] value_derive;
                    string letterused = "";
                    value_derive = new double[values.Length];
                    try {letterused = values[maxnbrvalues]; } catch { d = 0; }
                    string[] substrings = new string[2];
                    substrings = letterused.Split('^');
                    value_derive[0] = Convert.ToDouble(values[1]);
                    value_derive[1] = Convert.ToDouble(substrings[1]);

                    i = value_derive[0] * value_derive[1];
                    d = value_derive[1] - 1;

                    if (Regex.IsMatch(substrings[0], @"^[a-zA-Z]+$"))
                    {

                        Console.Write("= " + i + substrings[0] + "^");
                    }
                    else { Console.Write(" Is an Invalid command = "); d = 0; }
                }
                catch (FormatException)
                {
                    Console.Write(" Is an Invalid command = ");
                    d = 0;
                }
            }
            else
            {
                Console.Write("\nError: Maximum number of parameters for operation exceeded. ");
                d = 0;
            }
            return d;
        }
    }
}
