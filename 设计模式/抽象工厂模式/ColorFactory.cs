using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    /// <summary>
    /// 步骤 6 创建扩展了 AbstractFactory 的工厂类，基于给定的信息生成实体类的对象
    /// 颜色实现类
    /// </summary>
    class ColorFactor : AbstractFactory
    {
        public override Color getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
