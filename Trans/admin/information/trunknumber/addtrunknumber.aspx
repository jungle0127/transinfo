<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addtrunknumber.aspx.cs" Inherits="Trans.admin.information.trunknumber.addtrunknumber" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>车牌号码添加</title>
    <link href="../../../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body  style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div class="formbody">
        <ul class="forminfo">  
            <li>
                <label>前缀</label>
                <asp:DropDownList runat="server" ID="ddlNumberPrefix"></asp:DropDownList>
                <asp:DropDownList runat="server" ID="ddlNumberCityPrefix">
                    
                </asp:DropDownList>
            </li>
            <li>
                <label>号码</label>
                <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
            </li>
            <li>
                <label>&nbsp;</label>
                <asp:Button runat="server" ID="btnSubmit" class="btn" Text="提交" 
                    onclick="btnSubmit_Click" />
            </li>
            
        </ul>
    </div>
    </form>
</body>
</html>
