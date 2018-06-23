using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class personal : System.Web.UI.Page
    {
        UserLoginBLL bll = new UserLoginBLL();
        UserAltBLL bll2 = new UserAltBLL();
        GetEssayBLL bll3 = new GetEssayBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                //未登录则跳转到登录页面
                Response.Redirect("/Login.aspx");
            }
            string username = Session["UserName"].ToString();
            UserLogin user = bll.GetUserByUserName(username);
            StringBuilder sb = new StringBuilder();
            sb.Append("<div>");
            sb.Append(string.Format("<p><img src='{0}' alt='' width='96px' height='96px' /></p><p>{1}</p><p>{2}</p>", user.Head, user.UserName, user.Sex));
            sb.Append("</div>");
            p_person.InnerHtml = sb.ToString();

            //显示头像
            StringBuilder sbhead = new StringBuilder();
            sbhead.Append(string.Format("<img src='{0}' alt='' width='96px' height='96px' />", user.Head));
            head.InnerHtml = sbhead.ToString();

            p_username.InnerText = user.UserName;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(string.Format("<input type='text'name='nick' value ='{0}' />", user.Nick.Trim()));
            p_nick.InnerHtml = sb1.ToString();

            StringBuilder sb2 = new StringBuilder();
            sb2.Append(string.Format("<input type='tel' class='tiny' data-role='birthyear' name='year' value ='{0}'><span class='tiny - inline - label'>年</span>", user.Year.Trim()));
            sb2.Append(string.Format("<input type='tel' class='ex - tiny' data -role='birthmonth' name='mouth' value ='{0}'><span class='tiny - inline - label'> 月</span>", user.Mouth.Trim()));
            sb2.Append(string.Format("<input type='tel' class='ex - tiny 'data-role='birthday' name='day' value ='{0}'><span class='tiny - inline - label'>日</span>", user.Day.Trim()));
            p_bir.InnerHtml = sb2.ToString();

            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            if (user.Sex.Trim() == "男")
            {
                sb3.Append("<input type = 'radio' class='styledbox' id='radio-gender-1' data-role='gender 'name='rb' value='M' checked>");
                p_rb1.InnerHtml = sb3.ToString();
                sb4.Append("<input type = 'radio' class='styledbox' id='radio-gender-2' data-role='gender 'name='rb' value='W'>");
                p_rb2.InnerHtml = sb4.ToString();

            }
            else
            {
                sb3.Append("<input type = 'radio' class='styledbox' id='radio-gender-1' data-role='gender 'name='rb' value='M' >");
                p_rb1.InnerHtml = sb3.ToString();
                sb4.Append("<input type = 'radio' class='styledbox' id='radio-gender-2' data-role='gender 'name='rb' value='W' checked>");
                p_rb2.InnerHtml = sb4.ToString();
            }
            //加载文章
            string author = Session["UserName"].ToString();
            List<GetEssay> essayList = bll3.GetEssayByAuthor(author);
            StringBuilder sbessay = new StringBuilder();
            if (essayList != null)
            {
                sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                foreach (var item in essayList)
                {
                    sbessay.Append(string.Format("<span class='list-item' id = 'ess{0}' runat='server'><a class='link'>", item.Id));
                    sbessay.Append(string.Format("<span style='display: block; float: left; margin-left: 22px;width:103.6px; color: #2ed4b4;'>{0}</span>", item.Id));
                    sbessay.Append(string.Format("<span style='display: block; float: left; width:249.6px; color: black;'>{0}</span>", item.Title));
                    sbessay.Append(string.Format("<span style='display: block; float: left; width:103.6px; color: black;'>{0}</span>", item.Author));
                    sbessay.Append("</a></span>");
                }
                essay.InnerHtml = sbessay.ToString();
            }
            else
            {
                sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                essay.InnerHtml = sbessay.ToString();
            }
        }

        protected void btnalter_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                //未登录则跳转到登录页面
                Response.Redirect("/Login.aspx");
            }
            string username = Session["UserName"].ToString();
            string nick = Request["nick"  ];
            string year = Request["year"];
            string mouth = Request["mouth"];
            string day = Request["day"];
            string sex = "";
            if (Request["rb"] == "M")
            {
                sex = "男";
            }
            if (Request["rb"] == "W")
            {
                sex = "女";
            }
            bool user = bll2.AltUserByUserName(username,nick,year,mouth,day,sex);
            if (user == false)
            {
                Response.Write("<script>alert('修改失败，请重新修改');</script>");
            }
            else
            {
                Response.Write("<script>alert('修改成功');</script>");

                UserLogin user1 = bll.GetUserByUserName(username);
                p_username.InnerText = user1.UserName;
                StringBuilder sb1 = new StringBuilder();
                sb1.Append(string.Format("<input type='text'name='nick' value ='{0}' />", user1.Nick.Trim()));
                p_nick.InnerHtml = sb1.ToString();

                StringBuilder sb2 = new StringBuilder();
                sb2.Append(string.Format("<input type='tel' class='tiny' data-role='birthyear' name='year' value ='{0}'><span class='tiny - inline - label'>年</span>", user1.Year.Trim()));
                sb2.Append(string.Format("<input type='tel' class='ex - tiny' data -role='birthmonth' name='mouth' value ='{0}'><span class='tiny - inline - label'> 月</span>", user1.Mouth.Trim()));
                sb2.Append(string.Format("<input type='tel' class='ex - tiny 'data-role='birthday' name='day' value ='{0}'><span class='tiny - inline - label'>日</span>", user1.Day.Trim()));
                p_bir.InnerHtml = sb2.ToString();

                StringBuilder sb3 = new StringBuilder();
                StringBuilder sb4 = new StringBuilder();
                if (user1.Sex.Trim() == "男")
                {
                    sb3.Append("<input type = 'radio' class='styledbox' id='radio-gender-1' data-role='gender 'name='rb' value='M' checked>");
                    p_rb1.InnerHtml = sb3.ToString();
                    sb4.Append("<input type = 'radio' class='styledbox' id='radio-gender-2' data-role='gender 'name='rb' value='W'>");
                    p_rb2.InnerHtml = sb4.ToString();

                }
                else
                {
                    sb3.Append("<input type = 'radio' class='styledbox' id='radio-gender-1' data-role='gender 'name='rb' value='M' >");
                    p_rb1.InnerHtml = sb3.ToString();
                    sb4.Append("<input type = 'radio' class='styledbox' id='radio-gender-2' data-role='gender 'name='rb' value='W' checked>");
                    p_rb2.InnerHtml = sb4.ToString();
                }
            }
        }
        protected void Selhead_Click(object sender, EventArgs e)
        {
            if (FUhead.HasFile)
            {
                string filePath = Server.MapPath("~/img/");
                string fileName = FUhead.PostedFile.FileName;
                FUhead.SaveAs(filePath + fileName);
                //Response.Write("<script>alert('上传成功');</script>");
                string username = Session["UserName"].ToString();
                bool user = bll2.AltUserByUserName(username,"/img/"+fileName);
                if (user == false)
                {
                    Response.Write("<script>alert('上传失败，请重新上传');</script>");
                }
                else
                {
                    StringBuilder sbhead = new StringBuilder();
                    UserLogin getuser = bll.GetUserByUserName(username);
                    sbhead.Append(string.Format("<img src='{0}' alt='' width='96px' height='96px'/>", getuser.Head));
                    head.InnerHtml = sbhead.ToString();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("<div>");
                    sb.Append(string.Format("<p><img src='{0}' alt='' width='96px' height='96px' /></p><p>{1}</p><p>{2}</p>", getuser.Head, getuser.UserName, getuser.Sex));
                    sb.Append("</div>");
                    p_person.InnerHtml = sb.ToString();
                }
            }
            else
            {
                Response.Write("<script>alert('请选择上传的文件');</script>");
            }
        }
        protected void PwdAlt_Click(object sender, EventArgs e)
        {
            string oldpwd = txtPwd.Text;
            string newpwd = txtNewPwd.Text;
            string newpwd2 = TxtNewPwd2.Text;
            string username = Session["UserName"].ToString();
            UserLogin getuser = bll.GetUserByUserName(username);
            
            if (oldpwd != getuser.Pwd)
            {
                pwdsp.InnerText = "原密码错误，请重新输入！";
            }
            if(newpwd != newpwd2)
            {
                newpwdsp2.InnerText = "密码不一致！";
            }
            if(oldpwd == getuser.Pwd && newpwd == newpwd2)
            {
                pwdsp.InnerText = "";
                newpwdsp.InnerText = "";
                bool user = bll2.AltUserByUserName(username, newpwd2, "");
                if (user == false)
                {
                    Response.Write("<script>alert('密码修改失败！');</script>");
                }
                else
                {
                    Session["UserName"] = null;
                    Response.Write("<script>alert('密码修改成功！请重新登陆'); window.location.href='/Login.aspx'</script>");
                    
                }
            }
        }

        protected void CofDel_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                string essayId = DelEss.Value;
                if (String.IsNullOrEmpty(essayId))
                {
                    Response.Write("<script>alert('请输入序号！');</script>");
                }
                else
                {
                    if (bll3.DeleteEssay(Convert.ToInt32(essayId)))
                    {
                        string author = Session["UserName"].ToString();
                        List<GetEssay> essayList = bll3.GetEssayByAuthor(author);
                        StringBuilder sbessay = new StringBuilder();
                        if (essayList != null)
                        {
                            sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                            foreach (var item in essayList)
                            {
                                sbessay.Append(string.Format("<span class='list-item' id = 'ess{0}' runat='server'><a class='link'>", item.Id));
                                sbessay.Append(string.Format("<span style='display: block; float: left; margin-left: 22px;width:103.6px; color: #2ed4b4;'>{0}</span>", item.Id));
                                sbessay.Append(string.Format("<span style='display: block; float: left; width:249.6px; color: black;'>{0}</span>", item.Title));
                                sbessay.Append(string.Format("<span style='display: block; float: left; width:103.6px; color: black;'>{0}</span>", item.Author));
                                sbessay.Append("</a></span>");
                            }
                            essay.InnerHtml = sbessay.ToString();
                        }
                        else
                        {
                            sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                            essay.InnerHtml = sbessay.ToString();
                        }
                        
                    }
                    else
                    {
                        Response.Write("<script>alert('删除失败！');</script>");
                    }
                }
            }
        }

        protected void CofAdd_Click(object sender, EventArgs e)
        {
            string esstil = essTil.Value;
            string essaut = Session["UserName"].ToString();
            if (esstil != "")
            {
                if (bll3.AddEssay(esstil, essaut))
                {
                    string author = Session["UserName"].ToString();
                    List<GetEssay> essayList = bll3.GetEssayByAuthor(author);
                    StringBuilder sbessay = new StringBuilder();
                    if (essayList != null)
                    {
                        sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                        foreach (var item in essayList)
                        {
                            sbessay.Append(string.Format("<span class='list-item' id = 'ess{0}' runat='server'><a class='link'>", item.Id));
                            sbessay.Append(string.Format("<span style='display: block; float: left; margin-left: 22px;width:103.6px; color: #2ed4b4;'>{0}</span>", item.Id));
                            sbessay.Append(string.Format("<span style='display: block; float: left; width:249.6px; color: black;'>{0}</span>", item.Title));
                            sbessay.Append(string.Format("<span style='display: block; float: left; width:103.6px; color: black;'>{0}</span>", item.Author));
                            sbessay.Append("</a></span>");
                        }
                        essay.InnerHtml = sbessay.ToString();
                    }
                    else
                    {
                        sbessay.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:249.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                        essay.InnerHtml = sbessay.ToString();
                    }

                }
                else
                {
                    Response.Write("<script>alert('添加失败！');</script>");
                }

            }
            else
            {
                tipaddess.InnerText = "请输入题目！";
            }
        }
    }
}