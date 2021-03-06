using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    class BinaryObserver : Observer
    {
        public BinaryObserver( Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary String: "+ Convert.ToString(subject.getState(),2));
        }
    }
}
