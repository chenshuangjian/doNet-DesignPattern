using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 步骤 3 创建实现了 Order 接口的实体类。
    /// </summary>
    class SellStock : Order
    {
        private Stock abcStock;
        public SellStock(Stock stock)
        {
            this.abcStock = stock;
        }

        public void execute()
        {
            abcStock.sell();
        }
    }
}
