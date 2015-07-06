<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRightManager.aspx.cs" Inherits="Trans.admin.rightmanager.UserRightManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户权限管理</title>
    <link href="../../css/style.css" type="text/css" />
</head>
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="updatePanel" runat="server">
            <ContentTemplate>
                <asp:Panel runat="server" ID="userPanel">
                    <label>用户选择</label>
                    <asp:DropDownList ID="ddlUser" runat="server" AutoPostBack="true"
                        onselectedindexchanged="ddlUser_SelectedIndexChanged"></asp:DropDownList>
                    <hr />
                </asp:Panel>
                <asp:Panel ID="rightPanel" runat="server">
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>

