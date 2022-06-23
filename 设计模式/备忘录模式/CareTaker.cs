using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 步骤 3 创建 CareTaker 类。
    /// </summary>
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento get(int index)
        {
            return mementoList[index];
        }
    }
}
