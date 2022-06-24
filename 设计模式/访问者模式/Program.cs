using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// 步骤 5 使用 ComputerPartDisplayVisitor 来显示 Computer 的组成部分。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());
        }
    }
}
