using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    /// <summary>
    /// 步骤 3 创建一个工厂，生成基于给定信息的实体类的对象
    /// </summary>
    class ShapeFactory
    {
        private static readonly Dictionary<String, Shape> circleMap = new Dictionary<string, Shape>();
        public static Shape getCircle(String color)
        {
            Circle circle = null;

            if (!circleMap.ContainsKey(color))
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circleMap[color];
        }
    }
}
