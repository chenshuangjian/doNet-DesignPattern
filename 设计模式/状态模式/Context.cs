using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 步骤 3 创建 Context 类。
    /// </summary>
    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return state;
        }
    }
}
