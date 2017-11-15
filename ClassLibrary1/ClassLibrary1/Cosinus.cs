using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cosinus : Computer
    {
        /*-------------------------------------------------------------------------------------------------------------------------
        * 
        * This class is used to find the consinus of a real number. Maximum number of values is 1.
        * 
        * -------------------------------------------------------------------------------------------------------------------------
        */
        //Property
        public string Name
        {
            get { return "Cosinus"; }
        }

        //'Cosinus' implements the Execute method declared by 'Computer'
        //This is how 'Cosinus' signs the contract with 'Computer'
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
                    double[] value_cosinus;
                    value_cosinus = new double[2];
                    for (i = 1; i < values.Length; i++)
                    {
                        value_cosinus[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    double angle_rad = Math.PI * value_cosinus[0] / 180.0;
                    double angle_deg = value_cosinus[0];

                    result = Math.Cos(angle_rad);
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
