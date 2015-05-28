<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updaterolename.aspx.cs" Inherits="Trans.admin.rightmanager.updaterolename" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
<div class="formbody">
    <br />
    <br />
    <ul class="forminfo">    

    <li><label>角色名称</label><asp:TextBox ID="txtRoleName" class="dfinput" runat="server" name=""></asp:TextBox> <i>角色名不能超过10个字符</i></li>
    <li><label>&nbsp;</label><asp:Button runat="server" ID="btnSubmit" name="" 
            class="btn" Text="确认修改" onclick="btnSubmit_Click" ></asp:Button></li>
    </ul>
    
    
    </div>
    </form>
</body>
</html>
