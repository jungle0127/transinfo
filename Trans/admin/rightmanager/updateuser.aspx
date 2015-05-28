<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateuser.aspx.cs" Inherits="Trans.admin.rightmanager.updateuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
<%--    <link href="../../css/select.css" rel="stylesheet" type="text/css" />--%>
    <script type="text/javascript">
        $(document).ready(function (e) {
            $(".select1").uedSelect({
                width: 345
            });
            $(".select2").uedSelect({
                width: 167
            });
            $(".select3").uedSelect({
                width: 100
            });
        });
    </script>
</head>
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
        <div class="formbody">
        <br />
        <br />
        <ul class="forminfo">    
        <li><label>用户名称</label><asp:TextBox ID="txtUserName" class="dfinput" runat="server" 
                name="" ReadOnly="True"></asp:TextBox></li>
        <li><label>登录名称</label><asp:TextBox ID="txtLoginName" class="dfinput" 
                runat="server" name="" ReadOnly="True"></asp:TextBox></li>
        <li><label>角色名称</label>
                <div class="vocation">
                <asp:DropDownList CssClass="select1" ID="ddlRole" runat="server" Height="16px" 
                        Width="106px">
                    <asp:ListItem Text="Plese select." Value="-1"></asp:ListItem>
                </asp:DropDownList>
                </div>
        </li>
        <li><label>&nbsp;</label>
        <asp:Button runat="server" ID="btnSubmit" name="" 
                class="btn" Text="确认修改" onclick="btnSubmit_Click" ></asp:Button>
        <asp:Button runat="server" ID="btnUpdatePwd" name="" class="btn" Text="重置密码" 
                onclick="btnUpdatePwd_Click" />
        </li>
        </ul>
    
    
        </div>
    </form>
</body>
</html>
