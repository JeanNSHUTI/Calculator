using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*-------------------------------------------------------------------------------------------------------------------------
    * 
    * This class is used to calculate the minimum number within a maximum of ten whole numbers.
    * 
    * -------------------------------------------------------------------------------------------------------------------------
    */
    //Property
    public class Minimum : Computer
    {
        public string Name
        {
            get { return "Minimum"; }
        }

        //'Minimum' implements the Execute method declared by 'Computer'
        //This is how 'Maximum' signs the contract with 'Computer'
        public double Execute(params string[] values)
        {
            int maxnbrvalues = 10;
            double minimumvalue = 0;

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
                    double[] values_min;
                    values_min = new double[values.Length - 1];
                    for (i = 1; i < values.Length; i++)
                    {
                        values_min[d] = Convert.ToInt32(values[i]);
                        d++;
                    }
                    minimumvalue = values_min.Min();
                }
                catch (FormatException)
                {
                    Console.Write(" Is an Invalid command ");
                }
            }
            else
            {
                Console.Write("\nError: Maximum number of parameters for operation exceeded. ");
                minimumvalue = 0;
            }
            return minimumvalue;
        }

    }
}
