using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 过滤器模式
{
    /// <summary>
    /// 步骤 1 创建一个类，在该类上应用标准。
    /// </summary>
    public class Person
    {
        private String name;
        private String gender;
        private String maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
    }
}
