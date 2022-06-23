using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    /// <summary>
    /// 步骤 3 InterpreterPatternDemo 使用 Expression 类来创建规则，并解析它们。
    /// </summary>
    class Program
    {
        //规则：Robert 和 John 是男性
        public static Expression getMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //规则：Julie 是一个已婚的女性
        public static Expression getMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        static void Main(string[] args)
        {
            Expression isMale = getMaleExpression();
            Expression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.interpret("John"));
            Console.WriteLine("Julie is a married women? "+ isMarriedWoman.interpret("Married Julie"));
        }
    }
}
