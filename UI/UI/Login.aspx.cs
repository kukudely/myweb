using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            pwdsp.InnerText = "";
            usernamesp.InnerText = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            pwdsp.InnerText = "";
            usernamesp.InnerText = "";
            string userName = txtUserName.Value;
            string pwd = txtPwd.Value;
            if (string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pwd))
            {
                usernamesp.InnerText = "用户名不能为空！";
                pwdsp.InnerText = "";
            }
            if (string.IsNullOrEmpty(pwd) && !string.IsNullOrEmpty(userName))
            {
                usernamesp.InnerText = "";
                pwdsp.InnerText = "密码不能为空！";
            }
            if (string.IsNullOrEmpty(pwd) && string.IsNullOrEmpty(userName))
            {
                pwdsp.InnerText = "密码不能为空！";
                usernamesp.InnerText = "用户名不能为空！";
            }
            UserLoginBLL bll = new UserLoginBLL();
            UserLogin user = bll.GetUserByUserName(userName);
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pwd))
            {
                if (user == null)
                {
                    usernamesp.InnerText = "用户名不存在！";
                    //Response.Write("<script>alert('用户名不存在');</script>");
                }
                else
                {
                    if (user.Pwd == pwd)
                    {
                        Session["UserName"] = userName;
                        Response.Redirect("Defult.aspx");

                    }
                    else
                    {
                        usernamesp.InnerText = " ";
                        pwdsp.InnerText = "密码错误！";
                        
                        //Response.Write("<script> alert('密码错误！');</script>");

                    }
                }
            }
            
            


        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign.aspx");

        }
    }
}