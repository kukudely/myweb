using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserAltBLL
    {
        UserAltDAL dal = new UserAltDAL();
        public bool AltUserByUserName(string userName, string nick, string year, string mouth, string day, string sex)
        {

            return dal.AltUserByUserName(userName, nick, year, mouth, day, sex);

        }
        public bool AltUserByUserName(string userName, string head)
        {

            return dal.AltUserByUserName(userName, head);

        }
        public bool AltUserByUserName(string userName, string pwd,string i)
        {

            return dal.AltUserByUserName(userName, pwd,i);

        }
    }
}
