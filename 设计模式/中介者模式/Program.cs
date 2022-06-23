using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式
{
    /// <summary>
    /// 步骤 3 使用 User 对象来显示他们之间的通信。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.sendMessage("Hi! John!");
            john.sendMessage("Hello! Robert!");
        }
    }
}
