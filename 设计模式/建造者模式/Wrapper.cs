using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 2 创建实现 Packing 接口的实体类
    /// </summary>
    class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
