using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserLoginDAL
    {
        public UserLogin GetUserByUserName(string userName){

            string sql = "select id,UserName,nick,pwd,year,mouth,day,sex,head from UserLogin where UserName = @userName";
            SqlParameter para = new SqlParameter("@userName",userName);
            SqlDataReader reader = SqlHelper.ExecuteReader(sql,para);
            UserLogin user = null;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    user = new UserLogin();
                    user.Id = Convert.ToInt32( reader["id"]);
                    user.UserName = reader["UserName"].ToString();
                    user.Nick = reader["nick"].ToString();
                    user.Pwd = reader["pwd"].ToString();
                    user.Year = reader["year"].ToString();
                    user.Mouth = reader["mouth"].ToString();
                    user.Day = reader["day"].ToString();
                    user.Sex = reader["sex"].ToString();
                    user.Head = reader["head"].ToString();

                }
            }
            reader.Close();
            return user;
        }
        
    }
}
