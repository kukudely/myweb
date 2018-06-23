 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personal.aspx.cs" Inherits="UI.personal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/personal.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <nav class="nav">
		<div id="p_person" class ="person" runat="server">
                
                    
                
        </div>

		<div class="person-shouye">
			
			<a href="Defult.aspx">首页</a>
		</div>
		
		<div class="person-geren">
			<a href="#">个人中心</a>
		</div>
        <div class="anniu" style="bottom:10px;width:200px; position:absolute;text-align:center;">
        <a href="Logoff.ashx" class="btn btn-info">注销</a>
        </div>
	</nav>


        <div class="person-content">
		<div class="lujing"><p><a href="Defult.aspx" style="text-decoration: none;">首页</a><span style="color:gray;"> / 个人中心</span></p></div>
		<div class="person-content1">
		<div class="person-tab-head">
			<h4 class="person-selected">资料修改</h4>
			<h4>我的文章</h4>
			<h4>头像修改</h4>
			<h4>密码修改</h4>
        </div> 
        <div class="person-tab-content">
            <div class="person-show">
            	<span style="display: block;width: 60px; height: 40px;border-bottom: 4px solid #2ed4b4; margin:30px 0 0 125px; line-height: 40px; text-align: center;">资料修改</span>
            	<span class="person-ziliao"  style="display:block">
            		<section class="row">
            			<span class="label">用户名：</span>
            			<span id="p_username" runat="server"></span>
            		</section>
            		
            		<section class="row">
            			<span class="label">昵称:</span>
                        <span id ="p_nick" runat="server"></span>
            		</section>
            		<section class="row">
            			<span class="label">生日:</span>
                        <span id ="p_bir" runat="server"></span>
        				
       					
            		</section>
            		<section class="row">
            			<span class="label">性别:</span>
                        <span id ="p_rb1" runat="server"></span>
        				
        				<label  class="instruction2" for="radio-gender-1">男</label>
                        <span id="p_rb2" runat="server"></span>
        				
        				<label class="instruction2" for="radio-gender-2">女</label>
        				
            		</section>
            		<span class="lable label2" style="margin-top: 50px;margin-left: 0px; display: block;">
                    <asp:Button ID="btnalter" runat="server" Text="确认修改" CssClass="button blue" OnClick="btnalter_Click" />
        			
      				</span>
            	</span>
            </div>
            <div>
            	
            		<span class="person-shoucang" style="display: block";>
            			<span style="display: block;" class="shoucang-top">
            				<span style=" font-size: 24px;">我的文章</span>
            				<p style="margin: 15px 0 0 0px; display: block; width: 38px; border-top: 4px solid #2ed4b4; border-left,border-right: 1px solid #eeeeee; border-bottom: none; ">
            					<span style="display: block; padding-left: 5px;">文章</span>
            				</p>
            			</span>
            			<span style="display: block; width: 500px; margin: 10px auto;" id="essay" runat="server">
            				
            			</span>
                        <span runat="server">
                            删除文章：&nbsp;
                            选择删除序号：<input type="text" runat="server" name="deless" id="DelEss" value="" style="width:50px;"/>
                            <asp:Button ID="CofDel" OnClick="CofDel_Click" runat="server" Text="确认删除" Width="70px" />
                        </span><br />
                        <br />
                        <span runat="server">
                            添加文章：&nbsp;
                            标题：<input type="text" runat="server" id="essTil" value="" style="width:100px;"/>
                            <asp:Button ID="CofAdd" OnClick="CofAdd_Click" runat="server" Text="确认添加" Width="70px" /><br />
                            <span id ="tipaddess" runat="server" style="font-size: 10px;color: rgb(255, 0, 0);padding-left: 160px;margin: 0;"></span>
                        </span>
            		</span>
            	
            </div>
            <div>
            	<span style="display: block;width: 60px; height: 40px;border-bottom: 4px solid #2ed4b4; margin:30px 0 0 125px; line-height: 40px; text-align: center;">头像修改</span>
            	<span class="person-touxiang">
            		<span id="head" runat="server" ></span>
                    <asp:FileUpload ID="FUhead" runat="server" style="margin-top:10px;margin-left:-20px"  Height="20px" Width="150px" BorderStyle="None" />
                    
            	</span>
            	<span class="person-xiugai">
            		<span class="person-xiugai1"><asp:Button ID="Selhead" OnClick="Selhead_Click" runat="server" Text="修改头像" CssClass="button blue label2" /></span>
            	</span>
            </div>
            <div>
            	<span style="display: block;width: 60px; height: 40px;border-bottom: 4px solid #2ed4b4; margin:30px 0 0 125px; line-height: 40px; text-align: center;">密码修改</span>
            	<span style="display: block;" class="person-mima">
            	<section class="row">
            		<span class="label" style="display: block; float: left;"> 原密码：</span>
            		<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox><br />
                    <span runat="server" class="sp" id="pwdsp"></span>
            		
            	</section>
            	<section class="row">
            		<span class="label" style="display: block; float: left;"> 新密码：</span>
            		<asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox><br />
                    <span runat="server" class="sp" id="newpwdsp"></span>
            		
            	</section>
            	<section class="row">
            		<span class="label" style="display: block; float: left;"> 再次输入新密码：</span>
            		<asp:TextBox ID="TxtNewPwd2" runat="server" TextMode="Password"></asp:TextBox><br />
                    <span runat="server" class="sp" id="newpwdsp2"></span>
            	
            	</section>
            	<span class="person-mima1">
            		<span class="person-mima1">
                        <asp:Button ID="PwdAlt" OnClick="PwdAlt_Click" runat="server" Text="确认修改" CssClass="button blue label2" />
            		</span>
            	</span>
            	</span>
            </div>
        </div>
            </div>
	</div><!-- person-content -->
	
	
	
	
	<script>
		 var tabs = document.getElementsByClassName('person-tab-head')[0].getElementsByTagName('h4'),
                contents = document.getElementsByClassName('person-tab-content')[0].getElementsByTagName('div');

            (function changeTab(tab) {
                for(var i = 0, len = tabs.length; i < len; i++) {
                    tabs[i].onmousedown = showTab;
                }
            })();

            function showTab() {
                for(var i = 0, len = tabs.length; i < len; i++) {
                    if(tabs[i] === this) {
                        tabs[i].className = 'person-selected';
                        contents[i].className = 'person-show';
                    } else {
                        tabs[i].className = '';
                        contents[i].className = '';
                    }
                }
            }
	</script>
	<script type="text/javascript" src="js/jquery-3.1.1.slim.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
