using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 1 创建一个表示食物条目和食物包装的接口
    /// 食物条目
    /// </summary>
    public interface Item
    {
        String name();
        Packing packing(); //包装
        float price();
    }
}
