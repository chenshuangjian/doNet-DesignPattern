using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 步骤 3 创建一个类，从数据库获取实体类，并把它们存储在一个 Hashtable 中。
    /// </summary>
    public class ShapeCache
    {

        private static Dictionary<String, Shape> shapeMap= new Dictionary<string, Shape>();

        public static Shape getShape(String shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        // 对每种形状都运行数据库查询，并创建该形状
        // shapeMap.put(shapeKey, shape);
        // 例如，我们要添加三种形状
        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.Id = "1";
            shapeMap.Add(circle.Id, circle);

            Square square = new Square();
            square.Id ="2";
            shapeMap.Add(square.Id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.Id = "3";
            shapeMap.Add(rectangle.Id, rectangle);
        }

        public static void UpdateCache(string id, Shape shape) {
            shapeMap[id] = shape;
        }
    }
}
