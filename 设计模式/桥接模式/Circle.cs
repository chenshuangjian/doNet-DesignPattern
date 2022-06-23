using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 步骤 4 创建实现了 Shape 抽象类的实体类
    /// </summary>
    public class Circle : Shape
    {
        private int x, y, radius;

        //构造对象特有属性与绘制特有造型进行桥接接口
        public Circle(int x,int y,int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
