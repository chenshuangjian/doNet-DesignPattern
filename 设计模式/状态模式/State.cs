using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    /// <summary>
    /// 步骤 1 创建一个接口。
    /// </summary>
    public interface State
    {
        void doAction(Context context);
    }
}
