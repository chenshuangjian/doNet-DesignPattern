using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式
{
    /// <summary>
    /// 步骤 3 创建实现了 Shape 接口的抽象装饰类
    /// 为原有类套上装饰器抽象类，默认保留原有功能
    /// </summary>
    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        protected ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void draw()
        {
            decoratedShape.draw();
        }
    }
}
