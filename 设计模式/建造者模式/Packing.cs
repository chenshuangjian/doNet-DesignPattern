using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 1 创建一个表示食物条目和食物包装的接口
    /// 食物包装
    /// </summary>
    public interface Packing
    {
        String pack();
    }
}
