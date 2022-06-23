using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式
{
    /// <summary>
    /// 步骤 4 创建扩展了 ShapeDecorator 类的实体装饰类。
    /// 基于原有功能的装饰器进行扩展，新增红色装饰
    /// </summary>
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void draw()
        {
            decoratedShape.draw(); //原有特性
            setRedBorder(decoratedShape); //原有功能添加红色特性
        }

        private void setRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
