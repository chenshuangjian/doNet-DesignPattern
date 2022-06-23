using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Circle : Shape
    {
        public Circle()
        {
            Type = "Circle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
