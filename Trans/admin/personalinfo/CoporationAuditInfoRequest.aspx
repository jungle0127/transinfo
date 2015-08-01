<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoporationAuditInfoRequest.aspx.cs" Inherits="Trans.admin.personalinfo.CoporationAuditInfoRequest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>企业审核信息提交</title>
    <link href="../../css/style.css" type="text/css" rel="Stylesheet" />
</head>
<body  style="background:#f0f9fd;">
    <form id="form1" runat="server">
        <div class="formbody">
            <ul class="forminfo">    
                <li>
                    <label>公司名称</label>
                    <asp:TextBox ID="txtCorporationName" class="dfinput" runat="server" name=""></asp:TextBox>
                    
                </li>
                <li>
                    <label>公司地址</label>
                    <asp:TextBox ID="txtAddress" class="dfinput" runat="server"></asp:TextBox>
                </li>
                <li>
                    <label>联系人</label>
                    <asp:TextBox ID="txtContact" runat="server" class="dfinput"></asp:TextBox>
                </li>
                <li>
                    <label>联系电话</label>
                    <asp:TextBox ID="txtPhone" runat="server" class="dfinput"></asp:TextBox>
                </li>
                <li>
                    <label>营业执照</label>
                    <asp:FileUpload ID="fileUploadLicenseUrl" runat="server" class="dfinput" />
                </li>
                <li>
                    <label>&nbsp;</label>
                    <asp:Button runat="server" ID="btnSubmit" name=""  onclientclick="validateInput()"
                            class="btn" Text="提交审核" onclick="btnSubmit_Click" ></asp:Button>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
