using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
   /// <summary>
   /// 步骤 3 当被请求时，使用 ProxyImage 来获取 RealImage 类的对象。
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test_10mb.jpg");
            // 图像将从磁盘加载
            image.display();
            Console.WriteLine("");
            // 图像不需要从磁盘加载
            image.display();
        }
    }
}
