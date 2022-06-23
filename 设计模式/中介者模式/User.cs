using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式
{
    public class User
    {
        private String name;

        public User(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public void sendMessage(String message)
        {
            ChatRoom.showMessage(this, message);
        }
    }
}
