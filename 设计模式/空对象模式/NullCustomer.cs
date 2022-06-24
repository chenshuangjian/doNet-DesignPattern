using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 空对象模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上述类的实体类。
    /// </summary>
    public class NullCustomer : AbstractCustomer
    {
        public override string getName()
        {
            return "Not Available in Customer Database";
        }

        public override bool isNil()
        {
            return true;
        }
    }
}
