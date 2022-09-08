using MathsLib;
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
            #endregion Variables declaration

            char oper = AskUserForCharInput("Enter operator");

            while (oper != '#')
            {
                #region User inputs and variables initialization
                int op1 = AskUserForIntegerInput("Enter first operand");
                int op2 = AskUserForIntegerInput("Enter second operand");
                #endregion User input and variable initialization

                MathsRequest mathsRequest = new MathsRequest(op1, oper, op2);
                result = PerformCalculation(mathsRequest);

                #region Display result
                DisplayResult(mathsRequest, result);
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

        static private void DisplayResult(MathsRequest mathsRequest, int result)
        {
            throw new NotImplementedException();
        }

        static private void DisplayMessage(string message)
        {
            throw new NotImplementedException();
        }
        #endregion GUI

        static private int PerformCalculation(MathsRequest mathsRequest)
        {
            throw new NotImplementedException();
        }
    }
}
