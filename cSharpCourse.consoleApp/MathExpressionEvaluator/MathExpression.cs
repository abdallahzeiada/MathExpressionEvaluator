using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCourse.consoleApp.MathExpressionEvaluator
{
    internal class MathExpression
    {
        public double LeftSideOperand { get; set; }
        public double RightSideOperand { get; set; }
        public MathOperation Operation { get; set; }
    }
}
