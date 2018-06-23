<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defult.aspx.cs" Inherits="UI.Defult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <nav class="nav">
		<div class="person">
            <form id="person" runat="server">
                
                    
                
            </form>

		</div>
		<div class="shouye">
			
			<a href="#">首页</a>
		</div>
		
		<div class="geren">
			<a href="personal.aspx">个人中心</a>
		</div>
		<div class="anniu" style="bottom:10px;width:200px; position:absolute;text-align:center;">
        <a href="Logoff.ashx" class="btn btn-info">注销</a>
        </div>
	</nav>
    <div class="page-content">
        <div class="content">
            <div class="content-1">
                <span class="person-shoucang" id="ess" runat="server">
                    
                </span>
            </div>
        </div>
    </div>
</body>
</html>
