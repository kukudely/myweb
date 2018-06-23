using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class sign : System.Web.UI.Page
    {
        UserRegBLL bll = new UserRegBLL();
        UserLoginBLL bll2 = new UserLoginBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            usernamesp.InnerText = "";
            pwdsp.InnerText = "";
            pwdsp1.InnerText = "";
            ymdsp.InnerText = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string userName = txtUserName.Text.Trim();
            string pwd = txtPwd.Text;
            string pwd1 = txtPwd1.Text;
            string nick = txtNick.Text;
            
            string sex = "";
            string head = "/img/touxiang.png";
            UserLogin getuser = bll2.GetUserByUserName(userName);
            if (getuser != null)
            {
                usernamesp.InnerText = "用户名已存在，请重新输入";
            }
            //123
            if (userName == "")
            {
                usernamesp.InnerText = "请输入用户名!";
            }
            if (nick == "")
            {
                nicksp.InnerText = "昵称不能为空！";
            }
            if (pwd == "")
            {
                pwdsp.InnerText = "密码不能为空!";
            }
            if (pwd != pwd1)
            {
                pwdsp1.InnerText = "密码不一致，请重新输入";
            }
            if (txtYear.Value == "" || txtMouth.Value == "" || txtDay.Value == "")
            {
                ymdsp.InnerText = "请输入日期！";
            }
            if(getuser == null && userName != "" && nick != "" && pwd != "" && pwd == pwd1 && txtYear.Value != ""&& txtMouth.Value != ""&& txtDay.Value != "")
            {
                usernamesp.InnerText = "";
                nicksp.InnerText = "";
                pwdsp.InnerText = "";
                pwdsp1.InnerText = "";
                ymdsp.InnerText = "";
                int yearint, mouthint, dayint;
                try
                {
                    yearint = Convert.ToInt32(txtYear.Value);
                    mouthint = Convert.ToInt32(txtMouth.Value);
                    dayint = Convert.ToInt32(txtDay.Value);
                }
                catch (Exception)
                {
                    ymdsp.InnerText = "日期错误，请重新输入";
                    return;
                }
                if ((yearint < 1900 || yearint > 2018) || (mouthint < 0 || mouthint > 12) || (dayint < 0 || dayint > 31))
                {
                    ymdsp.InnerText = "日期错误，请重新输入";
                }
                else
                {
                    ymdsp.InnerText = "";
                    if (Request["rb"] == "M")
                    {
                        sex = "男";
                    }
                    if (Request["rb"] == "W")
                    {
                        sex = "女";
                    }

                    bool user = bll.SetUserByUserName(userName, nick, pwd, txtYear.Value, txtMouth.Value, txtDay.Value, sex, head);
                    if (user == false)
                    {
                        Response.Write("<script>alert('注册失败，请重新输入');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册成功');</script>");
                        Session["UserName"] = userName;
                        Response.Redirect("Defult.aspx");
                    }
                }
            } 
            

            //123
            
            

        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPwd.Text = "";
            txtPwd1.Text = "";
            txtNick.Text = "";
            txtYear.Value = "";
            txtMouth.Value = "";
            txtDay.Value = "";
        }
    }
}