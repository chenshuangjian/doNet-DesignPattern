using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式
{
    /// <summary>
    /// 步骤 5 使用 RedShapeDecorator 来装饰 Shape 对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            ShapeDecorator redCircle = new RedShapeDecorator(new Circle());
            ShapeDecorator redRectangle = new RedShapeDecorator(new Rectangle());
            //Shape redCircle = new RedShapeDecorator(new Circle());
            //Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.draw();
        }
    }
}
