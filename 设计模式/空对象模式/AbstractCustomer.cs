using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 空对象模式
{
    /// <summary>
    /// 步骤 1 创建一个抽象类。
    /// </summary>
    public abstract class AbstractCustomer
    {
        protected String name;
        public abstract bool isNil();
        public abstract String getName();
    }
}
