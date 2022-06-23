using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 步骤 5 使用 Shape 和 DrawAPI 类画出不同颜色的圆
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //将对象属性与绘制动作进行桥接，两者可独立变化
            Shape redcircle = new Circle(100, 100, 10, new RedCircle());
            Shape greencircle = new Circle(10, 10, 10, new GreenCircle());

            redcircle.draw();
            greencircle.draw();
        }
    }
}
