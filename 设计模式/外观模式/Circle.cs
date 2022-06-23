using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    /// <summary>
    /// 步骤 2 创建实现接口的实体类
    /// </summary>
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
