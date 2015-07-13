<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainFrame.aspx.cs" Inherits="Trans.admin.MainFrame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>物流信息信息管理系统</title>
</head>
    <frameset rows="88,*" cols="*" frameborder="no" border="0" framespacing="0">
        <frame src="top.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame" title="topFrame" />
        <frameset cols="187,*" frameborder="no" border="0" framespacing="0">
         <frame src="leftmenu.aspx" name="leftFrame" scrolling="No" noresize="noresize" id="leftFrame" title="leftFrame" />
         <frame src="welcome.aspx" name="rightFrame" id="rightFrame" title="rightFrame" />
        </frameset>
    </frameset>
<body>
    <form id="form1" runat="server">

    </form>
</body>
</html>
