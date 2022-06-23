using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    /// <summary>
    /// 步骤 2 创建实现了上述接口的实体类。
    /// 包含解释器
    /// </summary>
    class TerminalExpression : Expression
    {
        private String data; 

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }

}
