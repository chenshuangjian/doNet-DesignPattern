using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 4 创建实现了上述类的实体访问者。
    /// </summary>
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {
        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
