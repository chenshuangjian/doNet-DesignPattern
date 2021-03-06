using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 步骤 1 创建 Subject 类。
    /// 对象
    /// </summary>
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
