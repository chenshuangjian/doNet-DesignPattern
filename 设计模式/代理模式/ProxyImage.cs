using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 步骤 2 创建实现接口的实体类。
    /// </summary>
    class ProxyImage : Image
    {
        private RealImage realImage;
        private String fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
