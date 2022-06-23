using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 3 创建实现 Item 接口的抽象类，该类提供了默认的功能
    /// 冷饮
    /// </summary>
    public abstract class ColdDrink : Item
    {
        public abstract string name();
        public Packing packing() { return new Bottle(); }
        public abstract float price();
    }
}
