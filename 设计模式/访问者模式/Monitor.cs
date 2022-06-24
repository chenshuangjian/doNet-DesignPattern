using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上述类的实体类。
    /// </summary>
    public class Monitor : ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
