﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserLoginBLL
    {
        UserLoginDAL dal = new UserLoginDAL();
        public UserLogin GetUserByUserName(string userName) {
            
            return dal.GetUserByUserName(userName);

        }
    }
}
