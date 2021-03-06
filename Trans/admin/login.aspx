﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Trans.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>川北物流首页</title>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script language="javascript" src="../js/bootstrap.min.js"></script>
    <script language="javascript" src="../js/js.js"></script>
    <link rel="stylesheet" href="../css/index_login.css" />
    <link rel="Stylesheet" href="../css/bootstrap.min.css" />
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("#background").fullBg();
        });
    </script>
</head>
<%--style="background-color:#1c77ac; background-image:url(../imgs/bg3.jpg); background-repeat:no-repeat; background-position:center top; overflow:hidden;"--%>
<body>
    <form id="form1" runat="server">
    <img id="background" src="../imgs/bg3.jpg" alt="" />

    <table width="100%" class="homeBg" cellspacing="0">
  <tbody>
     <tr>
     <td id="home_middle">
 	 <div class='container-fluid loginAndRegister'>
    	<div class='tabL'>
            <ul class="nav nav-tabs" id="myTab">
                <li class="active"><a href="#login" data-toggle='tab' class="loginLink">登陆</a></li>
                <li><a href="#register" data-toggle='tab' class="registerLink">注册</a></li>
            </ul>
            <div class="tab-content">
              <div class="tab-pane active" id="login">
               <table class="login_form">
               <tbody>
                <tr>
                <td><p class="whiteBold">用户名：</p></td>
                <td>
                <%--<input type="text" id="userNameInput" class="userNameInput"/>--%>
               <asp:TextBox ID="userNameInputLogin" runat="server" class="userNameInput" value="admin" ></asp:TextBox>
                </td>
                </tr>
                 <tr>
                 <td><p class="whiteBold">密码：</p></td>
                 <td>
                 <%--<input type="password" id="passwordInput"  class="passwordInput"/>--%>
                 <asp:TextBox runat="server" ID="passwordInput" class="passwordInput" TextMode="Password" value="lotus" ></asp:TextBox>
                 </td>

                 </tr>
                 <tr>           
                 <td></td>
                 <td>
                 <input type="checkbox" class="checkRemPsw"/><span class="whiteBold rember">记住我</span>
                 <a href="#" class="findPswLink">找回密码</a>
                 </td> 
                 </tr>
                 <tr>
                 <td>
                 <%--<input  type="button" id="loginBtn" class="loginBtn"/>--%>
                 <asp:Button runat="server"   class="loginBtn" ID="loginBtn" onclick="btnLogin_Click" />
                 </td>

                 <td>
                 <%--<input  type="button" id="exitBtn" class="exitBtn" onclick="toIndex(this)">--%>
                 <asp:Button runat="server" id="exitBtnLogin" class="exitBtn"  />

                 </td>
                 </tr>
                </tbody>
               </table>
              </div>
              <div class="tab-pane" id="register">
                <table class="register_form">
                 <tbody>
                  <tr>
                    <td><p class="whiteBold">用户名：</p></td>
                    <td><input type="text" id="userNameInputRegister" class="registerNameInput"/></td>
                  </tr>
                   <tr>
                     <td><p class="whiteBold">输入密码：</p></td>
                     <td><input type="password" id="addPassword" class="registerPswInput"/></td>
                   </tr>
                   <tr>
                     <td><p class="whiteBold">确认密码：</p></td>
                     <td><input type="password" id="confirmPswInput" class="confirmPswInput"/></td>
                   </tr>
                   <tr>
                     <td><p class="whiteBold">用户类型：</p></td>
                     <td>
                     	<select class="selectUserType">
                        	<option selected="selected" value="个人">个人</option>
                            <option value="物流企业">物流企业</option>
                            <option value="运输商">运输商</option>
                        </select>
                     </td>
                   </tr>
                   <tr>
                     <td><input  type="button" id="registerBtn" class="registerBtn"/></td>
                     <td><input  type="button" id="exitBtnRegister" class="exitBtn" onclick="toIndex(this)" /></td>
                   </tr>
                  </tbody>
               </table>
              </div>
        	</div>
       	  </div>
    	</div>
     </td> 
    </tr>
  </tbody>
</table>

    </form>
</body>
</html>
