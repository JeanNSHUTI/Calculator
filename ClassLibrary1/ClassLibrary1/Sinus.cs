using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sinus : Computer
    {
        /*-------------------------------------------------------------------------------------------------------------------------
        * 
        * This class is used to find the sinus of a real number. Maximum number of values is 1.
        * 
        * -------------------------------------------------------------------------------------------------------------------------
        */
        //Property
        public string Name
        {
            get { return "Sinus"; }
        }

        //'Sinus' implements the Execute method declared by 'Computer'
        //This is how 'Sinus' signs the contract with 'Computer'
        public double Execute(params string[] values)
        {
            int i = 1;
            int d = 0;
            int maxnbrvalues = 1;
            double result = 0;

            //Limit number of values mathematical class can use.
            //If not respected, show error.
            if (values.Length - 1 <= maxnbrvalues)
            {
                //Test to see if values received are of type
                //'double' and convert. Otherwise, show error.
                try
                {
                    double[] value_sinus;
                    value_sinus = new double[maxnbrvalues];
                    for (i = 1; i < values.Length; i++)
                    {
                        value_sinus[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    double angle_rad = Math.PI * value_sinus[0] / 180.0;
                    double angle_deg = value_sinus[0];

                    result = Math.Sin(angle_rad);
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
