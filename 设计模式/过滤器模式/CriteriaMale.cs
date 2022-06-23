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
    public class CriteriaMale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.Equals("MALE",StringComparison.CurrentCultureIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
