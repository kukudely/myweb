using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class UserRegDAL
    {
        public bool SetUserByUserName(string userName,string nick, string pwd, string year,string mouth,string day, string sex,string head)
        {
            
            string sql = "insert into UserLogin values (@userName,@nick,@pwd,@year,@mouth,@day,@sex,@head)";
            SqlParameter[] para = {
                new SqlParameter("@userName",userName),
                new SqlParameter("@nick",nick),
                new SqlParameter("@pwd",pwd),
                new SqlParameter("@year",year),
                new SqlParameter("@mouth",mouth),
                new SqlParameter("@day",day),
                new SqlParameter("@sex",sex),
                new SqlParameter("@head",head)
            };
            
            int result = SqlHelper.ExecuteNonQuery(sql, para);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
