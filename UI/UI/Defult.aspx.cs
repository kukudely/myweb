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
    public partial class Defult : System.Web.UI.Page
    {
        UserLoginBLL bll = new UserLoginBLL();
        GetEssayBLL bll3 = new GetEssayBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                //未登录则跳转到登录页面
                Response.Redirect("/Login.aspx");
            }
            //if (Request.QueryString["UserName"] == null)
            //{
            //    Response.Redirect("/Login.aspx");
           // }
            string username = Session["UserName"].ToString();
            UserLogin user = bll.GetUserByUserName(username);
            StringBuilder sb = new StringBuilder();
            sb.Append("<div>");
            sb.Append(string.Format("<p><img src='{0}' alt='' /></p><p>{1}</p><p>{2}</p>",user.Head,user.UserName,user.Sex));
            sb.Append("</div>");
            person.InnerHtml= sb.ToString();

            List<GetEssay> allessayList = bll3.GetAllEssay();
            StringBuilder sbAllEss = new StringBuilder();
            if (allessayList != null)
            {
                sbAllEss.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:349.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                foreach (var item in allessayList)
                {
                    sbAllEss.Append(string.Format("<span class='list-item' id = 'ess{0}' runat='server'><a class='link' href='EssCont.aspx?SEssid={1}'>", item.Id,item.Id));
                    sbAllEss.Append(string.Format("<span style='display: block; float: left; margin-left: 22px;width:103.6px; color: #2ed4b4;'>{0}</span>", item.Id));
                    sbAllEss.Append(string.Format("<span style='display: block; float: left; width:349.6px; color: black;'>{0}</span>", item.Title));
                    sbAllEss.Append(string.Format("<span style='display: block; float: left; width:103.6px; color: black;'>{0}</span>", item.Author));
                    sbAllEss.Append("</a></span>");
                }
                ess.InnerHtml = sbAllEss.ToString();
            }
            else
            {
                sbAllEss.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:349.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                ess.InnerHtml = sbAllEss.ToString();
            }

        }

        
    }
}