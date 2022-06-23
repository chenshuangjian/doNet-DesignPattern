using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC模式
{
    /// <summary>
    /// 步骤 1 创建模型。
    /// </summary>
    public class Student
    {
        private String rollNo;
        private String name;

        public string RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
    }
}
