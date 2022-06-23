using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 步骤 1创建桥接实现接口
    /// </summary>
    public interface DrawAPI
    {
        void drawCircle(int radius, int x, int y);
    }
}
