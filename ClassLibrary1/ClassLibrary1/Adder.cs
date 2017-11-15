using System;

namespace ClassLibrary1
{
	public class Adder : Computer
	{
        /*-------------------------------------------------------------------------------------------------------------------------
        * 
        * This class is used to calculate the sum of a maximum of ten numbers.
        * 
        * -------------------------------------------------------------------------------------------------------------------------
        */
        //Property
        public string Name
		{
			get { return "Adder"; }
		}

        //'Adder' implements the Execute method declared by 'Computer'
        //This is how 'Adder' signs the contract with 'Computer'
        public double Execute (params string[] values)
		{
            int maxnbrvalues = 10;
            double result = 0;

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
                    double[] values_add;
                    values_add = new double[values.Length];
                    for (i = 1; i < values.Length; i++)
                    {
                        values_add[d] = Convert.ToDouble(values[i]);
                        d++;
                    }
                    Array.ForEach(values_add, value => result += value);
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
