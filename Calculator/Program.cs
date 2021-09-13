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

            oper = AskUserForCharInput("Enter operator");

            while (oper != '#')
            {
                #region User inputs and variables initialization
                op1 = AskUserForIntegerInput("Enter first operand");
                op2 = AskUserForIntegerInput("Enter second operand");

                #endregion User input and variable initialization

                #region Perform calculations
                switch (oper)
                {
                    case ('+'):
                        result = Add(op1, op2);
                        break;
                    case ('-'):
                        result = Substract(op1, op2);
                        break;
                    case ('*'):
                        result = Multiply(op1, op2);
                        break;
                    case ('/'):
                        result = Divide(op1, op2);
                        break;
                    default:
                        DisplayMessage("Operator not supported");
                        goto End;
                }

                #endregion Perform calculations

                #region Display result
                DisplayResult(op1, oper, op2, result);
                #endregion Display result

                oper = AskUserForCharInput("Enter operator");
            }
            End:
            DisplayMessage("You choose to leave...");
        }

        #region GUI
        static private char AskUserForCharInput(string question)
        {
            throw new NotImplementedException();
        }

        static private int AskUserForIntegerInput(string question)
        {
            throw new NotImplementedException();
        }

        static private void DisplayResult(int op1, char oper, int op2, int result)
        {
            throw new NotImplementedException();
        }

        static private void DisplayMessage(string message)
        {
            throw new NotImplementedException();
        }
        #endregion GUI

        #region Perfom calculations
        static private int Add(int op1, int op2)
        {
            throw new NotImplementedException();
        }

        static private int Substract(int op1, int op2)
        {
            throw new NotImplementedException();
        }

        static private int Multiply(int op1, int op2)
        {
            throw new NotImplementedException();
        }

        static private int Divide(int op1, int op2)
        {
            throw new NotImplementedException();
        }

        #endregion Perfom calculations
    }
}
