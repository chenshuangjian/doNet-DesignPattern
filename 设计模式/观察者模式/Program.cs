using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 步骤 4 使用 Subject 和实体观察者对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.setState(15);
            Console.WriteLine("Second state change: 10");
            subject.setState(10);
        }
    }
}
