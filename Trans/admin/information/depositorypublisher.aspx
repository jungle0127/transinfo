<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="depositorypublisher.aspx.cs" Inherits="Trans.admin.information.depositorypublisher" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>仓储信息</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script src="../kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="../kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/code/prettify.js" type="text/javascript"></script>  
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.create('#txtNote', {
                //上传管理
                uploadJson: '../kindeditor/asp.net/upload_json.ashx',
                //文件管理
                fileManagerJson: '../kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                //设置编辑器创建后执行的回调函数
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                },
                //上传文件后执行的回调函数,获取上传图片的路径
                afterUpload: function (url) {
                    //alert(url);
                },
                //编辑器高度
                width: '700px',
                //编辑器宽度
                height: '450px;',
                //配置编辑器的工具栏
                items: [
                'source', '|', 'undo', 'redo', '|', 'preview', 'print', 'template', 'code', 'cut', 'copy', 'paste',
                'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
                'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',
                'superscript', 'clearhtml', 'quickformat', 'selectall', '|', 'fullscreen', '/',
                'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
                'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image', 'multiimage',
                'flash', 'media', 'insertfile', 'table', 'hr', 'emoticons', 'baidumap', 'pagebreak',
                'anchor', 'link', 'unlink', '|', 'about'
                ]
            });
            prettyPrint();
        });
    </script>

</head>
<body  style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="formbody">
            <ul class="forminfo">    
                <li>
                    <label>标题</label>
                    <asp:TextBox ID="txtTitle" class="dfinput" runat="server" name=""> </asp:TextBox>
                </li>
                <li>
                    <label>所在地</label>
                    <asp:UpdatePanel ID="updatePanelSrcPlace" runat="server">
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
                                <asp:TextBox ID="txtSrcPlaceCode" runat="server" ReadOnly="true"></asp:TextBox>
                            </ContentTemplate>
                   </asp:UpdatePanel>
                </li>
                <li>
                    <label>地址</label>
                    <asp:TextBox ID="txtAddress" class="dfinput" runat="server"></asp:TextBox>
                </li>
             <li>
                <label>经营范围</label>
                <asp:DropDownList ID="ddlBizScope" runat="server">
                </asp:DropDownList>
            </li>
            <li>
                <label>仓库类型</label>
                <asp:DropDownList ID="ddlDepotType" runat="server"></asp:DropDownList>
            </li>
            <li>
                <label>面积</label>
                <asp:TextBox ID="txtArea" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>可用面积</label>
                <asp:TextBox ID="txtUseableArea" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>参考报价</label>
                <asp:TextBox ID="txtPrice" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>联系人</label>
                <asp:TextBox ID="txtContactPerson" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>联系电话</label>
                <asp:TextBox ID="txtPhone" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>有效时间</label>
                     <asp:UpdatePanel ID="updatePanelValidTime" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtValidTime" runat="server" Width="100" >长期有效</asp:TextBox>
                            <asp:ImageButton id="imageButton" runat="server" ImageUrl="~/images/time.png" AlternateText="calendar" OnClick="ImageButton_Click" CausesValidation="false" />  
                            <br />  
                            <div id="calendar" class="calendar" visible="false" runat="server">  
                            <asp:Calendar ID="txtValidCalendar" runat="server" 
                                    OnSelectionChanged="txtValidCalendar_SelectionChanged" />  
                            </div>  
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </li>
            <li>
                <label>仓储说明</label>
                <asp:TextBox ID="txtNote" runat="server"></asp:TextBox>
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
