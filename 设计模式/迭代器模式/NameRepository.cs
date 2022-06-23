using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式
{
    /// <summary>
    /// 步骤 2 创建实现了 Container 接口的实体类。该类有实现了 Iterator 接口的内部类 NameIterator。
    /// </summary>
    public class NameRepository : Container
    {
        public static String[] names = { "Robert", "John", "Julie", "Lora" };
        public Iterator GetIterator()
        {
            return new NameIterator();
        }

        /// <summary>
        /// 迭代器内部类
        /// </summary>
        private class NameIterator : Iterator
        {
            int index;

            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
