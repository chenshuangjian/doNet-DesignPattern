using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上述类的实体类。
    /// </summary>
    public class Computer : ComputerPart
    {
        ComputerPart[] parts;

        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}
