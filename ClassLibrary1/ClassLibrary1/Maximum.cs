using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Maximum : Computer
    {
        /*-------------------------------------------------------------------------------------------------------------------------
        * 
        * This class is used to calculate the maximum number within a maximum of ten whole numbers.
        * 
        * -------------------------------------------------------------------------------------------------------------------------
        */
        //Property
        public string Name
        {
            get { return "Maximum"; }
        }

        //'Maximum' implements the Execute method declared by 'Computer'
        //This is how 'Maximum' signs the contract with 'Computer'
        public double Execute(params string[] values)
        {
            int maxnbrvalues = 10;
            double maximumvalue = 0;

            //Limit number of values mathematical class can use 
            //If not respected, show error.
            if (values.Length - 1 <= maxnbrvalues)
            {
                //Test to see if values received are of type
                //'double' and convert. Otherwise, show error.
                try
                {
                    int i = 1;
                    int d = 0;
                    double[] values_max;
                    values_max = new double[values.Length];
                    for (i = 1; i < values.Length; i++)
                    {
                        values_max[d] = Convert.ToInt32(values[i]);
                        d++;
                    }
                    maximumvalue = values_max.Max();
                }
                catch (FormatException)
                {
                    Console.Write(" Is an Invalid command ");
                }
            }
            else
            {
                Console.Write("\nError: Maximum number of parameters for operation exceeded. ");
                maximumvalue = 0;
            }


            return maximumvalue;

        }
        public int Computeintegers(params int[] values)
        {
            int maximumvalue = values.Max();

            return maximumvalue;

        }
    }
}
