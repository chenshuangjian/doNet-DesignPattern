using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 步骤 3 创建实体观察者类。
    /// </summary>
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Octal String: "+ Convert.ToString(subject.getState(),16));
        }
    }
}
