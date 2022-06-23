using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    /// <summary>
    /// 步骤 5 为 Color 和 Shape 对象创建抽象类来获取工厂。
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Color getColor(String color);
        public abstract Shape getShape(String shape);
    }
}
