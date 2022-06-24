using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 1 定义一个表示元素的接口。
    /// </summary>
    public interface ComputerPart
    {
        void accept(ComputerPartVisitor computerPartVisitor);
    }
}
