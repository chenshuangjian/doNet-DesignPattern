using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2、数据访问层（DAL），主要是存放对数据类的访问，即对数据库的添加、删除、修改、更新等基本操作
/// </summary>
namespace DAL
{
    public class UserDB
    {
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public int AddUser(UserInfo userInfo)
        {
            //对数据库进添加一个用户操作    
            string commandText = "insert into UserInfo (userName,Password)values(@userName,@Password)";
            SqlParameter[] paras = new SqlParameter[]
            {
           new SqlParameter ("@userName",userInfo.UserName ),
           new SqlParameter ("@Password",userInfo.Password )
            };

            return 0;
        }
    }
}
