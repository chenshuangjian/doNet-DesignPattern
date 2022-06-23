using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式
{
    /// <summary>
    /// 步骤 1 创建中介类。
    /// 聊天室
    /// </summary>
    public class ChatRoom
    {
        public static void showMessage(User user, String message)
        {
            Console.WriteLine(new DateTime().ToString()+ " [" + user.Name + "] : " + message);
        }
    }
}
