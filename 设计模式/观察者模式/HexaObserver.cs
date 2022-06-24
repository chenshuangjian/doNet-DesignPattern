using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Hex String: "+ Convert.ToString(subject.getState(),10).ToUpper());
        }
    }
}
