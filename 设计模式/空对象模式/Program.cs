using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 空对象模式
{
    /// <summary>
    /// 步骤 4 使用 CustomerFactory，基于客户传递的名字，来获取 RealCustomer 或 NullCustomer 对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.getCustomer("Rob");
            AbstractCustomer customer2 = CustomerFactory.getCustomer("Bob");
            AbstractCustomer customer3 = CustomerFactory.getCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.getCustomer("Laura");

            Console.WriteLine("Customers");
            Console.WriteLine(customer1.getName());
            Console.WriteLine(customer2.getName());
            Console.WriteLine(customer3.getName());
            Console.WriteLine(customer4.getName());
        }
    }
}
