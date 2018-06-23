using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAltDAL
    {
        public bool AltUserByUserName(string username,string nick, string year, string mouth, string day, string sex)
        {

            string sql = "update UserLogin set nick=@nick,year=@year,mouth=@mouth,day=@day,sex=@sex where UserName = @userName";
            SqlParameter[] para = {
                new SqlParameter("@nick",nick),
                new SqlParameter("@year",year),
                new SqlParameter("@mouth",mouth),
                new SqlParameter("@day",day),
                new SqlParameter("@sex",sex),
                new SqlParameter("@userName",username)
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
        public bool AltUserByUserName(string username,string head)
        {
            string sql = "update UserLogin set head=@head where UserName = @userName";
            SqlParameter[] para = {
                new SqlParameter("@userName",username),
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
        public bool AltUserByUserName(string username, string pwd,string i)
        {
            string sql = "update UserLogin set pwd=@pwd where UserName = @userName";
            SqlParameter[] para = {
                new SqlParameter("@userName",username),
                new SqlParameter("@pwd",pwd)
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
