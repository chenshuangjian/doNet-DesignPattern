using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式
{
    /// <summary>
    /// 步骤 1 创建迭代器接口:
    /// </summary>
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
