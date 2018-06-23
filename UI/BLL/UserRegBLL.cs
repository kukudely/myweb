using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserRegBLL
    {
        UserRegDAL dal = new UserRegDAL();
        public bool SetUserByUserName(string userName, string nick, string pwd, string year, string mouth, string day,string sex,string head)
        {

            return dal.SetUserByUserName(userName,nick,pwd,year,mouth,day,sex,head);

        }
    }
}
