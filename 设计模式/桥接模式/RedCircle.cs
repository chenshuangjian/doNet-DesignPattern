using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 步骤 2 创建实现了 DrawAPI 接口的实体桥接实现类
    /// </summary>
    public class RedCircle : DrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: "+ radius + ", x: " + x + ", " + y + "]");
        }
    }
}
