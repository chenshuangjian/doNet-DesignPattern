using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 实体类库（Model），主要存放数据库中的表字段
/// </summary>
namespace Model
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
