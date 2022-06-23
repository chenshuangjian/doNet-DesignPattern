using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 步骤 1 创建一个 Singleton 类
    /// 注意使用时可以结合锁使用
    /// </summary>
    public class SingleObject
    {
        //创建 SingleObject 的一个对象
        private static SingleObject instance = new SingleObject();

        //让构造函数为 private，这样该类就不会被实例化
        private SingleObject() { }

        //获取唯一可用的对象
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
