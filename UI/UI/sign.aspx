<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign.aspx.cs" Inherits="UI.sign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="css/sign.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="bg1">
			<div class="logo">
				<h1> </h1>
			</div>
		</div>
		<div class="main-container">
			<div class="nav"><a>账号注册</a></div>
            <div class="form">
            	
            	<div class="row">
            		<span class="label"> 用户名</span>
            		<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            		<span class="instruction" style="margin-left: 15px;">发帖时展示，一经注册不可更改</span><br />
                    <span runat="server" class="sp" id="usernamesp"></span>
            	</div>
            	<div class="row">
            		<span class="label"> 昵称</span>
            		<asp:TextBox ID="txtNick" runat="server"></asp:TextBox>
            		<span class="instruction" style="margin-left: 15px;">注册后可以随时修改</span><br />
                    <span runat="server" class="sp" id="nicksp"></span>
            	</div>
            	<div class="row">
            		<span class="label"> 密码</span>
            		<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox><br />
            		<span runat="server" class="sp" id="pwdsp"></span>
            	</div>
            	<div class="row">
            		<span class="label"> 重复密码</span>
            		<asp:TextBox ID="txtPwd1" runat="server" TextMode="Password"></asp:TextBox><br />
            		<span runat="server" class="sp" id="pwdsp1"></span>
            	</div>
            	 <div class="row">
        			<span class="label">生日</span>
                    <input type="tel"  id="txtYear" runat="server" value="" name="year" style ="width:30px;" />
        			<span class="tiny-inline-label">年</span>
        			<input type="tel"  id="txtMouth" runat="server" value="" name="mouth" style ="width:20px;" />
                    <span class="tiny-inline-label">月</span>
        			<input type="tel"  id="txtDay" runat="server" value="" name="day" style ="width:20px;" />
                    <span class="tiny-inline-label">日</span><br />
       				<span runat="server" class="sp" id="ymdsp"></span>
        			
            	 </div>
            	 <div class="row">
            	 	<span class="label">性别</span>
                    <input type="radio" class="styledbox" id="txtRB1" data-role="gender" name="rb" value="M" checked/>
        			<label  class="instruction2" for="radio-gender-1">男</label>
                    <input type="radio" class="styledbox" id="txtRB2" data-role="gender" name="rb" value="W"/>
        			<label class="instruction2" for="radio-gender-2">女</label><br />
        			<span runat="server" class="sp" id="sexsp"></span>
        			
      			</div>
      			<div class="lable label2" style="margin-top: 15px;margin-left: 10px;">
        			<asp:Button ID="Button1" runat="server" Text="注册" CssClass="button blue" Font-Size="12px" OnClick="Button1_Click" />
        			<asp:Button ID="BtnClear" runat="server" Text="清除" CssClass="button" Font-Size="12px" OnClick="BtnClear_Click" />
      			</div>
      			<div class="lable label2">
        			<span class="instruction">点击注册，即表示你阅读并同意遵守<a class="blue-link" data-no-pjax href="#" target="_blank">站规细则</a></span>
      			</div>
      		
            </div>
		</div>
		<div class="footer">
			<p>© 2018</p>
		</div>
    </form>
</body>
</html>
