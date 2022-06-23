using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    /// <summary>
    /// 步骤 7 创建一个工厂创造器/生成器类，通过传递形状或颜色信息来获取工厂
    /// </summary>
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactor();
            }
            return null;
        }
    }
}
