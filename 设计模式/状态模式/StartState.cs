using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 步骤 2 创建实现接口的实体类。
    /// </summary>
    public class StartState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
