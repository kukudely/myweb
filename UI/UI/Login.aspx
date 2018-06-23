<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/sign.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .button{
            margin-right:0;
        }
    </style>
</head>
<body style="background-image:url(img/background.jpg);">
    <div style="position:absolute;bottom:115px;width:100%">
        <div style="position:relative;margin:0 auto;width:fit-content">
        <form id="form1" runat="server" >
            
            <input type="text" runat="server" placeholder="输入用户名" id="txtUserName" value="" />
            
            <input type="password" runat="server" style="margin-right:50px"  placeholder="输入密码" id="txtPwd" value="" />
             
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="登陆" CssClass="button blue" />
            <asp:Button ID="Button2" runat="server" OnClick="btnReg_Click" style="margin-left: 25px" Text="注册" CssClass="button" /><br />
            <span runat="server" style="color:red" id="usernamesp"></span>
            <span runat="server" style="color:red" id="pwdsp"></span>
          
    </form>
        </div>
    </div>
    
</body>
</html>
