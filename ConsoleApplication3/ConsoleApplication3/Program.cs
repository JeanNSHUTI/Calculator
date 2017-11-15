using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using ClassLibrary1;

namespace ConsoleApplicatio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*-------------------------------------------------------------------------------------------------------------------------
            * 
            * ConsoleApplication3 functions as a calculator. This calculator implements the following mathematical functions:
            * 
            * a)Addition b)Subtraction c)Multiplication d)Division e)Minimum f) Maximum
            * 
            * Attention: This calculator does not implement the rules of BODMAS !
            * ConsoleApplication3 references the assembly called 'ClassLibrary1.dll
            * All new mathematical functions should be added to this library class and inherit from the interface Computer.
            * 
            * 
            * -------------------------------------------------------------------------------------------------------------------------
            */

            //Load library ClassLibrary1.dll
            Assembly classlibrary = Assembly.LoadFrom("ClassLibrary1.dll");

            Console.WriteLine("               ===== Welcome to Calculator 3.1 =====");
            Console.WriteLine("");
            Console.WriteLine("Attention: This calculator does not implement the rules of BODMAS !");
            Console.WriteLine("");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("               ===== Rules for usage: ====");
            Console.WriteLine("");
            Console.WriteLine("Calculator 3.1 strictly uses the following formula to evaluate equations:");
            Console.WriteLine("'Operation' [SPACE key] 'First number' [SPACE key] 'Second number'");
            Console.WriteLine("where 'Operation' can either be:");
            Console.WriteLine("a) Divider b) Multiplier c) Adder d) Subtractor e) Minimum f) Maximum .");
            Console.WriteLine("Calculator 3.1 does not evaluate any unknown commands! Program will restart.");
            Console.WriteLine("Example --> Command:");
            Console.WriteLine("            Divider 10 5 ");
            Console.WriteLine("Important: Respect the order of division when dividing --> ");
            Console.WriteLine("'First number' / 'Second number'.");
            Console.WriteLine("The structure for Derive is as follows -->");
            Console.WriteLine(" Derive [SPACE key] 'Coeffecient of x' [SPACE key] 'x^Exponenent'");
            Console.WriteLine("The parameters 'First number' and 'Second number' are real numbers.");
            Console.WriteLine("The operations 'Minimum' and 'Maximum' only accept whole numbers (integers) ");
            Console.WriteLine("All operations take a maximum of 10 values at a time to ease visualization");
            Console.WriteLine("Enter 'Help'to retrieve the diferent types in referenced Assembly");
            Console.WriteLine("Enter 'Exit'or 'exit' to close calculator");
            Console.WriteLine("\nThat's it, happy calculating.");
            Console.WriteLine("");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("");

            for (;;)
            {
                int i = 1;
                Console.WriteLine();
                Console.WriteLine("Command:");

                // Read entry command by user
                string main_command = Console.ReadLine();
                string[] substrings_main = main_command.Split(' ');

                foreach (Type t in classlibrary.GetTypes())
                {
                    // Filter to keep only the classes that
                    // implement the interface ClassLibrary1
                    if (t.IsClass && typeof(ClassLibrary1.Computer).IsAssignableFrom(t))
                    {
                        //Evaluate only if command entry is equal to current type 
                        //Otherwise continue and restart
                        if (substrings_main[0] == t.Name)
                        {
                            Console.Write(">>> " + t.Name + " ");
                            for (i = 1; i < substrings_main.Length; ++i)
                            {
                                Console.Write(substrings_main[i] + " ");
                            }
                            // Create instance of class for each type 
                            // Stock the instance in a variable of type 'Computer' 
                            // Possible because c inherits from the interface 'Computer'
                            ClassLibrary1.Computer c = (ClassLibrary1.Computer)Activator.CreateInstance(t);

                            // Call execute method and send data received through 
                            // entry in console
                            double a = c.Execute(substrings_main);

                            //Different format for displaying of Derive function
                            if (substrings_main[0] == "Derive")
                            {
                                Console.Write(a);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write("= " + a);
                                Console.WriteLine();
                            }
                        }

                        //Test for exit
                        else if ((substrings_main[0] == "Exit") | (substrings_main[0] == "exit"))
                        {
                            Environment.Exit(0);
                        }

                        //Test for help function which prints out
                        //all types present in ClassLibrary1.dll
                        else if ((substrings_main[0] == "Help") | (substrings_main[0] == "help"))
                        {
                            info(classlibrary);
                        }
                        else { continue; }
                    }
                }
            }
        }
        public static void info(Assembly ClassLibrary)
        {
            foreach (Type type in ClassLibrary.GetTypes())
            {
                Console.WriteLine(" Class info -> " + type);

            }
        }
    }
}

/*-------------------------------------------------------------------------------------------------------------------------
* 
* Lines of code used to carry out first tests on different classes in ClassLibrary1.
* 
* -------------------------------------------------------------------------------------------------------------------------
*/

//Algebra alg = new Algebra();
//Adder test = new Adder();
//Subtractor test = new Subtractor();
//Multiplier test = new Multiplier();
//Divider test = new Divider();
//Sinus test = new Sinus();
//Cosinus test = new Cosinus();
//Minimum_and_Maximum test = new Minimum_and_Maximum();
//double[] numbers = new double[4];
//for (int i = 0; i < 4; i++)
//{
//    numbers[i] = i + 3;
//}
//a = test.Compute(numbers);
//double number1 = 100;
//double number2 = 50;
//double result = alg.Addition(number1, number2);
//Console.Write(number1);
//Console.Write(" + ");
//Console.Write(number2);
//Console.Write(" = ");

//Console.WriteLine(result);
//Console.WriteLine(a);
