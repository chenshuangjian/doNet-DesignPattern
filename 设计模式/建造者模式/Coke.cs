using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 4 创建扩展了 Burger 和 ColdDrink 的实体类
    /// </summary>
    class Coke : ColdDrink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 30.0f;
        }
    }
}
