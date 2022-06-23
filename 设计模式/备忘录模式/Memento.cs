using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 步骤 1 创建 Memento 类。
    /// </summary>
    public class Memento
    {
        private String state;

        public Memento(string state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }
    }
}
