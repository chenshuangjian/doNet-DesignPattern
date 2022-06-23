using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 责任链模式
{
    /// <summary>
    /// 步骤 2 创建扩展了该记录器类的实体类。
    /// </summary>
    class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override void write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
