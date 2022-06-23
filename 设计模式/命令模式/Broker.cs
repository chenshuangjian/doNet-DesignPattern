using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 步骤 4 创建命令调用类。
    /// 接受订单并下订单
    /// </summary>
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
