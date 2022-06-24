using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 步骤 2 创建 Observer 类。
    /// 观察者
    /// </summary>
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }
}
