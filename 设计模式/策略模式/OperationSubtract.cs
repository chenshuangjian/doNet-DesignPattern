using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 步骤 2创建实现接口的实体类。
    /// 减法策略
    /// </summary>
    public class OperationSubtract : Strategy
    {        public int doOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
