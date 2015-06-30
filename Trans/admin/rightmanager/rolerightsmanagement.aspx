<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rolerightsmanagement.aspx.cs" Inherits="Trans.admin.rightmanager.rolerightsmanagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>角色权限管理</title>
    <link href="../../css/style.css" type="text/css" />
</head>
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div>
        <asp:Panel runat = "server" ID="rolePanel">
            <label>角色选择</label>
            <asp:DropDownList ID="ddlRole" runat="server"  AutoPostBack="true"
                onselectedindexchanged="ddlRole_SelectedIndexChanged">
            
            </asp:DropDownList>
        </asp:Panel>
        <asp:Panel runat="server" ID="rightPanel">
        </asp:Panel>
    </div>
    </form>
</body>
</html>
