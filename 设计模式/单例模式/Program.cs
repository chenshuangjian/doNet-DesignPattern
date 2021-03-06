using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 步骤 2 从 singleton 类获取唯一的对象
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //不合法的构造函数
            //编译时错误：构造函数 SingleObject() 是不可见的
            //SingleObject object = new SingleObject();

            //获取唯一可用的对象
            SingleObject obj = SingleObject.getInstance();

            //显示消息
            obj.showMessage();
        }
    }
}
