<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addtrunk.aspx.cs" Inherits="Trans.admin.information.trunknumber.addtrunk" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加车辆</title>
    <link href="../../../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body  style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div class="formbody">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <ul class="forminfo">
            <li>
                <label>车牌号</label>
                <asp:DropDownList runat="server" ID="ddlNumberPrefix"></asp:DropDownList>
                <asp:DropDownList runat="server" ID="ddlNumberCityPrefix"></asp:DropDownList>
                <asp:TextBox runat="server" ID="txtNumber" class="dfinput"></asp:TextBox>
            </li>
           <%-- <li>
                <label>车牌号码</label>
                <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
            </li>
            <li>
                <label>车牌号</label>
                <asp:DropDownList ID="ddlTrunkNumber" runat="server"></asp:DropDownList>
                <a href="addtrunknumber.aspx" target="_self">添加车牌号</a>
            </li>--%>
            <li>
                <label>车长</label>
                <asp:TextBox ID="txtTrunkLength" runat="server"  class="dfinput"></asp:TextBox>米
            </li>
            <li>
                <label>载重</label>
                <asp:TextBox ID="txtTrunkCapacity" class="dfinput" runat="server"></asp:TextBox>吨
            </li>
            <li>
                <label>容积</label>
                <asp:TextBox ID="txtTrunkVolume" class="dfinput" runat="server"></asp:TextBox>
                立方米</li>
            <li>
                <label>常驻地</label>
                <asp:UpdatePanel ID="updatePanelPlace" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddlProvince_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True"  
                                onselectedindexchanged="ddlCity_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlCounty" runat="server" AutoPostBack="true" 
                                onselectedindexchanged="ddlCounty_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtPlaceCode" runat="server" ReadOnly="true"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </li>
            <li>
                <label>常驻位置</label>
                <asp:TextBox ID="txtAddress" class="dfinput" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>车辆类型</label>
                <asp:DropDownList ID="ddlVanType" runat="server"></asp:DropDownList>
            </li>
            <li>
                <label>车辆品牌</label>
                <asp:TextBox ID="txtBrand" class="dfinput" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>车体类型</label>
                <asp:DropDownList ID="ddlTrunkType" runat="server"></asp:DropDownList>
            </li>
            <li>
                <label>随车联系人</label>
                <asp:TextBox ID="txtContactPerson" class="dfinput" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>随车电话</label>
                <asp:TextBox ID="txtContactPhone" class="dfinput" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>车辆识别码</label>
                <asp:TextBox ID="txtIdentificationCode" class="dfinput" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>车辆图片</label>
                <asp:FileUpload ID="fileUploadTrunkImage" runat="server" />
            </li>
            <li>
                <label>行驶证图片</label>
                <asp:FileUpload ID="fileUploadTrunkLicenceImage" runat="server" />
            </li>
            <li>
                <label>&nbsp;</label>
                <asp:Button ID="btnSubmit" runat="server" class="btn" Text="提交" 
                    onclick="btnSubmit_Click" />
            </li>
        </ul>
    
    </div>
    </form>
</body>
</html>
