using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Subtractor : Computer
    {
        /*-------------------------------------------------------------------------------------------------------------------------
        * 
        * This class is used to subtract all values received in a table of values. Maximum number of values is 10.
        * 
        * -------------------------------------------------------------------------------------------------------------------------
        */
        //Property
        public string Name
        {
            get { return "Subtractor"; }
        }

        //'Subtractor' implements the Execute method declared by 'Computer'
        //This is how 'Subtractor' signs the contract with 'Computer'
        public double Execute(params string[] values)
        {
            int maxnbrvalues = 10;
            double result = 0;

            //Limit number of values mathematical class can use.
            //If not respected, show error.
            if (values.Length - 1 <= maxnbrvalues)
            {
                //Test to see if values received are of type
                //'double' and convert. Otherwise, show error.
                try
                {
                    int i = 1;
                    int d = 0;
                    double[] values_subtract;
                    values_subtract = new double[values.Length];
                    for (i = 1; i < values.Length; i++)
                    {
                        values_subtract[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    result = values_subtract[0];
                    for (int b = 1; b < values.Length; b++)
                    {
                        result -= values_subtract[b];
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
