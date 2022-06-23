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
    class OrCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public OrCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.meetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.meetCriteria(persons);

            foreach (Person person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}
