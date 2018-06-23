using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class EssCont : System.Web.UI.Page
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
            sb.Append(string.Format("<p><img src='{0}' alt='' /></p><p>{1}</p><p>{2}</p>", user.Head, user.UserName, user.Sex));
            sb.Append("</div>");
            person.InnerHtml = sb.ToString();

            int id = Convert.ToInt32(Request.QueryString["SEssid"]);
            GetEssay singleEssay = bll3.GetSingleEssayById(id);
            StringBuilder sbSingleEss = new StringBuilder();
            if (singleEssay != null)
            {
                sbSingleEss.Append(string.Format("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号：{0}</span><span style = 'display: block;float: left; width:349.6px;color: #2ed4b4;'>标题：{1}</span><span style ='display: block;float: left; width:203.6px;color: #2ed4b4;'>作者：{2}</span></span> ",singleEssay.Id,singleEssay.Title,singleEssay.Author));
                
                sbSingleEss.Append(string.Format("<div>{0}</div>", GetInterIDList(singleEssay.Textpath)));
                ess.InnerHtml = sbSingleEss.ToString();
            }
            else
            {
                //sbSingleEss.Append("<span class='list-title'><span style = 'display: block;float: left; margin-left: 22px;width:103.6px;color: #2ed4b4;'>序号</span><span style = 'display: block;float: left; width:349.6px;color: #2ed4b4;'> 标题 </span><span style ='display: block;float: left; width:103.6px;color: #2ed4b4;'>作者</span></span> ");
                ess.InnerHtml = "";
            }
        }
        public string GetInterIDList(string strfile)
        {
            string strout;
            strout = "";
            if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(strfile)))
            {
            }
            else
            {
                StreamReader sr = new StreamReader(System.Web.HttpContext.Current.Server.MapPath(strfile), System.Text.Encoding.Default);
                String input = sr.ReadToEnd();
                sr.Close();
                strout = input;
            }
            return strout;
        }
    }
}