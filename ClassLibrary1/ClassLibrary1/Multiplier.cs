using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*-------------------------------------------------------------------------------------------------------------------------
    * 
    * This class is used to multiply all values received in a table of values. Maximum number of values received is 10.
    * 
    * -------------------------------------------------------------------------------------------------------------------------
    */
    //Property
    public class Multiplier : Computer
    {
        public string Name
        {
            get { return "Multiplier"; }
        }

        //'Multiplier' implements the Execute method declared by 'Computer'
        //This is how 'Multiplier' signs the contract with 'Computer'
        public double Execute(params string[] values)
        {
            int maxnbrvalues = 10;
            double result = 0;
            int i = 1;
            int d = 0;
            double[] values_multiply;
            values_multiply = new double[values.Length - 1];

            //Limit number of values mathematical class can use.
            //If not respected, show error.
            if (values.Length - 1 <= maxnbrvalues)
            {
                //Test to see if values received are of type
                //'double' and convert. Otherwise, show error.
                try
                {
                    for (i = 1; i < values.Length; i++)
                    {
                        values_multiply[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    result = values_multiply[0];
                    for (int b = 1; b < values_multiply.Length; b++)
                    {
                        result *= values_multiply[b];
                    }
                }
                catch (FormatException)
                {
                    Console.Write(" Is an Invalid command ");
                }
            }
            else
            {
                Console.Write("\nError: Maximum number of parameters for operation exceeded. ");
                result = 0;
            }
            return result;
        }
    }
}
