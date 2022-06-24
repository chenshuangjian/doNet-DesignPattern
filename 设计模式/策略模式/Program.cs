using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 步骤 4 使用 Context 来查看当它改变策略 Strategy 时的行为变化。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.executeStrategy(10, 5));

            context = new Context(new OperationSubtract());
            Console.WriteLine("10 - 5 = " + context.executeStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.executeStrategy(10, 5));
        }
    }
}
