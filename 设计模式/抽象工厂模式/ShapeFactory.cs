using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    /// <summary>
    /// 步骤 6 创建扩展了 AbstractFactory 的工厂类，基于给定的信息生成实体类的对象
    /// 形状
    /// </summary>
    class ShapeFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            return null;
        }

        public override Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
