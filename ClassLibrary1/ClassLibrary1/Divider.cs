using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Divider : Computer
    {
        public string Name
        {
            get { return "Divider"; }
        }

        public double Execute(params string[] values)
        {
            int i = 1;
            int d = 0;
            int maxnbrvalues = 10;
            double[] values_divide;
            values_divide = new double[values.Length - 1];
            double result = 0;
            if (values.Length - 1 <= maxnbrvalues)
            {
                try
                {
                    for (i = 1; i < values.Length; i++)
                    {
                        values_divide[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    result = values_divide[0];
                    for (int b = 1; b < values_divide.Length; b++)
                    {
                        result /= values_divide[b];

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
