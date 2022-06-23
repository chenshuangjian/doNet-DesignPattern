using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 步骤 3 使用 DrawAPI 接口创建抽象类 Shape。
    /// 形状绘制处理动作接受接口
    /// </summary>
    public abstract class Shape
    {
        protected DrawAPI drawAPI;
        protected Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void draw();
    }
}
