using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCourse.consoleApp.MathExpressionEvaluator
{
    internal static class ExpressionParser
    {
        private const string MathSymbols = "+*/%^";
        public static MathExpression Parse(string expression)
        {
            expression = expression.Trim();
            var expr = new MathExpression();
            string token = "";
            bool leftSideInitialized = false;
            for (int i = 0; i < expression.Length; i++)
            {
                var currentChar = expression[i];
                if (char.IsDigit(currentChar))
                {
                    token += currentChar;
                    if (i == expression.Length - 1 && leftSideInitialized)
                    {
                        expr.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if (MathSymbols.Contains(currentChar))
                {
                    if (!leftSideInitialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                    }
                    token = "";
                    expr.Operation = ParseMathOperation(currentChar.ToString());
                }
                else if (currentChar == '-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Subtraction;
                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                        token = "";
                    }
                    else
                    {
                        token += currentChar;
                    }
                }
                else if (char.IsLetter(currentChar))
                {
                    token += currentChar;
                    leftSideInitialized = true;
                }
                else if (currentChar == ' ')
                {
                    if (!leftSideInitialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                        token = "";
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = ParseMathOperation(token);
                        token = "";
                    }
                }
                else
                {
                    token += currentChar;
                }
            }
            return expr;
        }

        private static MathOperation ParseMathOperation(string operation)
        {
            switch (operation.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplicaton;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "pow":
                case "^":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
