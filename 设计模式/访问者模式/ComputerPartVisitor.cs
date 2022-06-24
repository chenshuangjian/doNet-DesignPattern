using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 3 定义一个表示访问者的接口。
    /// </summary>
    public interface ComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
