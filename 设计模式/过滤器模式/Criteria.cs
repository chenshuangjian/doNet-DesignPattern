using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 过滤器模式
{
    /// <summary>
    /// 步骤 2 为标准（Criteria）创建一个接口
    /// 标准
    /// </summary>
    public interface Criteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
