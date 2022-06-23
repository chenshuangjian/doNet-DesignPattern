using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 过滤器模式
{
    /// <summary>
    /// 步骤 3 创建实现了 Criteria 接口的实体类
    /// </summary>
    class CriteriaSingle : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.MaritalStatus.Equals("SINGLE",StringComparison.CurrentCultureIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
