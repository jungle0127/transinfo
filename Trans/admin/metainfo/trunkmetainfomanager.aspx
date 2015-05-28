<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trunkmetainfomanager.aspx.cs" Inherits="Trans.admin.metainfo.trunkmetainfomanager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>车辆元数据</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div class="formbody">
        <ul class="forminfo"> 
            <li>
                <label>车牌号码</label>
                <asp:DropDownList runat="server" ID="ddlTrunkNumberPrefix" CssClass="select1">
                </asp:DropDownList>
                <asp:TextBox runat="server" ID="txtTrunkNumber"></asp:TextBox>
            </li>
            <li>
                <label>车辆类型</label>
                <asp:DropDownList ID="ddlVanType" runat="server"></asp:DropDownList>
            </li>
            <li>
                <label>车体类型</label>
                <asp:DropDownList ID="ddlTrunkType" runat="server"></asp:DropDownList>
            </li>
        </ul>
        <a href="../information/trunknumber/addtrunk.aspx" target="_self">添加货车</a>
    </div>
    </form>
</body>
</html>
