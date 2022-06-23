using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    /// <summary>
    /// 步骤 1 创建一个表达式接口
    /// </summary>
    public interface Expression
    {
        bool interpret(String context); //解释
    }
}
