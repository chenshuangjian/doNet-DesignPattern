using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    /// <summary>
    /// 步骤 2 创建实现接口的实体类。
    /// </summary>
    public class Circle : Shape
    {
        private String color;
        private int x;
        private int y;
        private int radius;

        public Circle(string color)
        {
            this.color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Radius { get => radius; set => radius = value; }

        public void draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + color
         + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
}
