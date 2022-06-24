using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 步骤 3 创建 Context 类。
    /// </summary>
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStrategy(int num1, int num2)
        {
            return strategy.doOperation(num1, num2);
        }
    }
}
