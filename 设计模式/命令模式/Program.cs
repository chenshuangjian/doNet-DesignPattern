using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock(); //命令集

            BuyStock buyStockOrder = new BuyStock(abcStock); //买命令
            SellStock sellStockOrder = new SellStock(abcStock);//卖命令

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
        }
    }
}
