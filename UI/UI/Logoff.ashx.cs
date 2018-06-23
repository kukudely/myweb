using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace UI
{
    /// <summary>
    /// Logoff 的摘要说明
    /// </summary>
    public class Logoff : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            //将session设置为空
            context.Session["UserName"] = null;
            //跳转到登录页面
            context.Response.Redirect("/Login.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}