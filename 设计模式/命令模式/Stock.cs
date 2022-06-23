using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 步骤 2 创建一个请求类。
    /// 请求买卖命令
    /// </summary>
    public class Stock
    {
        private String name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity +" ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity +" ] sold");
        }
    }
}
