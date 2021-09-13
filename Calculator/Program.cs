using System;

namespace Calculator
{
    class Program
    {
        /// <summary>
        /// This method is the entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Variables declaration
            int result;
            int op1;
            int op2;
            char oper;
            #endregion Variables declaration

            Console.Write("Enter operator : ");
            oper = char.Parse(Console.ReadLine());

            while (oper != '#')
            {
                #region User inputs and variables initialization
                Console.Write("Enter first operand : ");
                op1 = int.Parse(Console.ReadLine());

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(false); // true = hide input
                }

                Console.Write("Enter second operand : ");
                op2 = int.Parse(Console.ReadLine());

                #endregion User input and variable initialization

                #region Perform calculations
                switch (oper)
                {
                    case ('+'):
                        result = op1 + op2;
                        break;
                    case ('-'):
                        result = op1 - op2;
                        break;
                    case ('*'):
                        result = op1 * op2;
                        break;
                    case ('/'):
                        result = op1 / op2;
                        break;
                    default:
                        Console.Write("Operator not supported");
                        goto End;
                }

                #endregion Perform calculations

                #region Display result
                Console.Clear();
                Console.WriteLine("The result of " + op1 + " " + oper +  " " + op2 + " is : " + result);
                Console.WriteLine("------------------");

                Console.Write("Enter operator : ");
                oper = char.Parse(Console.ReadLine());

                #endregion Display result
            }
            End:
            Console.WriteLine("You choose to leave...");
        }
    }
}
