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

                result = PerformCalculation(op1, oper, op2);

                #region Display result
                DisplayResult(op1, oper, op2, result);
                #endregion Display result

                oper = AskUserForCharInput("Enter operator");
            }
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

        static private int PerformCalculation(int op1, char oper, int op2)
        {
            throw new NotImplementedException();
        }
    }
}
