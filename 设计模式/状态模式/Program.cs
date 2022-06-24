using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 我们将创建一个 State 接口和实现了 State 接口的实体状态类。Context 是一个带有某个状态的类。StatePatternDemo，我们的演示类使用 Context 和状态对象来演示 Context 在状态改变时的行为变化。
/// </summary>
namespace 状态模式
{
    /// <summary>
    /// 步骤 4 使用 Context 来查看当状态 State 改变时的行为变化。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            Console.WriteLine(context.getState().ToString());

            StopState stopState = new StopState();
            stopState.doAction(context);

            Console.WriteLine(context.getState().ToString());
        }
    }
}
