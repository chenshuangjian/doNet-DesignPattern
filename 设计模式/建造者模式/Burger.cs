using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 3 创建实现 Item 接口的抽象类，该类提供了默认的功能
    /// 汉堡
    /// </summary>
    public abstract class Burger : Item
    {
        public abstract string name();
        //实现一部分默认功能
        public Packing packing() {
            return new Wrapper();
        }
        public abstract float price();
    }
}
