using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.loadCache();
            //获取克隆对象
            Shape clonedShape = (Shape)ShapeCache.getShape("1");
            Console.WriteLine("Shape : " + clonedShape.Type);
            //修改原型对象时，克隆对象不会发生改变
            //将原型修改Rectangle
            Rectangle rectangle = new Rectangle();
            ShapeCache.UpdateCache("1", rectangle);
            //克隆体不会改变
            Console.WriteLine("Shape : " + clonedShape.Type);


            Shape clonedShape2 = (Shape)ShapeCache.getShape("2");
            Console.WriteLine("Shape : " + clonedShape2.Type);

            Shape clonedShape3 = (Shape)ShapeCache.getShape("3");
            Console.WriteLine("Shape : " + clonedShape3.Type);
        }
    }
}
