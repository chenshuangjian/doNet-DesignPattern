using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 步骤 1 创建一个接口。
    /// 策略
    /// </summary>
    public interface Strategy
    {
        int doOperation(int num1, int num2);
    }
}
