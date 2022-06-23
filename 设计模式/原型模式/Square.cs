using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上面抽象类的实体类。
    /// </summary>
    class Square : Shape
    {
        public Square()
        {
            Type = "Square";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
