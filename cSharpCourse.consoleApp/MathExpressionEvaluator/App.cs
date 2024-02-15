using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCourse.consoleApp.MathExpressionEvaluator
{
    public static class App
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                Console.Write("Enter math expression: ");
                var input = Console.ReadLine();
                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"Left Side = {expr.LeftSideOperand}, Operation = {expr.Operation}, Right Side = {expr.RightSideOperand}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{input} = {EvaluateExpression(expr)}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        private static object EvaluateExpression(MathExpression expr)
        {
            var op = expr.Operation;
            var left = expr.LeftSideOperand;
            var right = expr.RightSideOperand;
            switch (op)
            {
                case MathOperation.Addition:
                    return left + right;
                case MathOperation.Subtraction:
                    return left - right;
                case MathOperation.Division:
                    return left / right;
                case MathOperation.Multiplicaton:
                    return left * right;
                case MathOperation.Modulus:
                    return left % right;
                case MathOperation.Sin:
                    return Math.Sin(right);
                case MathOperation.Cos:
                    return Math.Cos(right);
                case MathOperation.Tan:
                    return Math.Tan(right);
                case MathOperation.Power:
                    return Math.Pow(left, right);
                default:
                    return 0;
            }
        }
    }
}
