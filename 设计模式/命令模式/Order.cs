using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 步骤 1 创建一个命令接口。
    /// </summary>
    public interface Order
    {
        void execute();
    }
}
