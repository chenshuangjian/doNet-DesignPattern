using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    /// <summary>
    /// 步骤4 创建实现接口的实体类
    /// </summary>
    class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
