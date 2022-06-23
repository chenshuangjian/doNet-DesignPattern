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
    class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
