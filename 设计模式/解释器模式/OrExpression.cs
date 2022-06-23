﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    /// <summary>
    /// 步骤 2 创建实现了上述接口的实体类。
    /// 或解释器
    /// </summary>
    class OrExpression : Expression
    {
        private Expression expr1 = null;
        private Expression expr2 = null;

        public OrExpression(Expression expr1, Expression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }

        public bool interpret(string context)
        {
            return expr1.interpret(context) || expr2.interpret(context);
        }
    }
}
