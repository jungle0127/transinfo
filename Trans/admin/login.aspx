<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Trans.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎登录后台管理系统</title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <script language="JavaScript" type="text/javascript" src="../js/jquery.js"></script>
    <script src="../js/cloud.js" type="text/javascript"></script>

    <script type="text/javascript" language="javascript">
        $(function () {
            $('.loginbox').css({ 'position': 'absolute', 'left': ($(window).width() - 692) / 2 });
            $(window).resize(function () {
                $('.loginbox').css({ 'position': 'absolute', 'left': ($(window).width() - 692) / 2 });
            })
        });  
    </script> 
</head>
<body  style="background-color:#1c77ac; background-image:url(../images/light.png); background-repeat:no-repeat; background-position:center top; overflow:hidden;">
    <form id="form1" runat="server">
    <div id="mainBody">
      <div id="cloud1" class="cloud"></div>
      <div id="cloud2" class="cloud"></div>
    </div>  


<div class="logintop">    
    <span>欢迎登录后台管理界面平台</span>    
    <ul>
    <li><a href="#">回首页</a></li>
    <li><a href="#">帮助</a></li>
    <li><a href="#">关于</a></li>
    </ul>    
    </div>
    
    <div class="loginbody">
    
    <span class="systemlogo"></span> 
       
    <div class="loginbox">
    
    <ul>
    <li>
        <asp:TextBox ID="txtLoginName" runat="server" class="loginuser" value="admin" ></asp:TextBox>
        <%--<input name="" type="text" class="loginuser" value="admin" onclick="JavaScript:this.value=''"/>--%>
    </li>
    <li>
        <asp:TextBox runat="server" ID="txtPwd" class="loginpwd" TextMode="Password" value="lotus" ></asp:TextBox>
        <%--<input name="" type="text" class="loginpwd" value="密码" onclick="JavaScript:this.value=''"/>--%>
    </li>
    <li>
        <asp:Button runat="server" Text="登录" CssClass="loginbtn" ID="btnLogin" 
            onclick="btnLogin_Click" />
        <%--<input name="" type="button" class="loginbtn" value="登录"  onclick="javascript:window.location='mainframe.htm'"  />--%>
        <label><input name="" type="checkbox" value="" checked="checked" />记住密码</label><label><a href="#">忘记密码？</a></label>
    </li>
    </ul>
    
    
    </div>
    
    </div>
    
    
    
    <div class="loginbm">版权所有  2013  <a href="http://www.uimaker.com">uimaker.com</a>  仅供学习交流，勿用于任何商业用途</div>
	
    </form>
</body>
</html>
