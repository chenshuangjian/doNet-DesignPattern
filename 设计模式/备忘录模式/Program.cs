using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 步骤 4 使用 CareTaker 和 Originator 对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.setState("State #1");
            originator.setState("State #2");
            careTaker.add(originator.saveStateToMemento());
            originator.setState("State #3");
            careTaker.add(originator.saveStateToMemento());
            originator.setState("State #4");

            Console.WriteLine("Current State: " + originator.getState());
            originator.getStateFromMemento(careTaker.get(0));
            Console.WriteLine("First saved State: " + originator.getState());
            originator.getStateFromMemento(careTaker.get(1));
            Console.WriteLine("Second saved State: " + originator.getState());
        }
    }
}
