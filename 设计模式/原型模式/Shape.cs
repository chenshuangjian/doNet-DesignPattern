using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 步骤 1 创建一个实现了 Cloneable 接口的抽象类
    /// </summary>
    public abstract class Shape : ICloneable
    {
        private String id;
        private String type;

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }

        public abstract void draw();
        public object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception e)
            {
                
            }
            return clone;
        }
    }
}
