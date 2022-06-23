using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式
{
    /// <summary>
    /// 步骤 3 使用 NameRepository 来获取迭代器，并打印名字。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.GetIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
