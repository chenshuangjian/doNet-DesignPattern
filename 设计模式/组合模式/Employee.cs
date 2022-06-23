using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    /// <summary>
    /// 步骤 1 创建 Employee 类，该类带有 Employee 对象的列表。
    /// </summary>
    public class Employee
    {
        private String name;
        private String dept;
        private int salary;
        private List<Employee> subordinates = new List<Employee>();

        public Employee(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + name
                    + ", dept : " + dept + ", salary :"
                    + salary + " ]");
        }
    }
}
