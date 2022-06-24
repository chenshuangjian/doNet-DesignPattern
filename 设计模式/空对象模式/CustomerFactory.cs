using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 空对象模式
{
    /// <summary>
    /// 步骤 3 创建 CustomerFactory 类。
    /// </summary>
    public class CustomerFactory
    {
        public static readonly String[] names = {"Rob", "Joe", "Julie"};
 
   public static AbstractCustomer getCustomer(String name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name,StringComparison.CurrentCultureIgnoreCase))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
