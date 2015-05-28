<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trunksourcepublisher.aspx.cs" Inherits="Trans.admin.information.trunksourcepublisher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>车源信息发布</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../../css/home_style.css" type="text/css" />
    <link href="../kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script src="../kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="../kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/code/prettify.js" type="text/javascript"></script>  
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.create('#txtDescription', {
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
    <style  type="text/css">
        .calendar
        {
            position: absolute;
            width: 250px;
            padding: 5px;
            background-color: White;
            border: 1px solid #858585;
            z-index: 10;
        }
    </style>
</head>
<body  style="background:#f0f9fd;">
    <form id="form1" runat="server">
    <div class="formbody">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <ul class="forminfo">  
            <li>
                <label>标题</label>
                <asp:TextBox ID="txtTitle" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>选择货车</label>
                <asp:DropDownList ID="ddlTrunk" runat="server"></asp:DropDownList>
                <a href="trunknumber/addtrunk.aspx" target="_self">添加货车</a>
            </li>
            <li>
                <label>类型</label>
                <asp:DropDownList ID="ddlRouteType" runat="server"></asp:DropDownList>
            </li>
            <li>
                <label>出发地</label>
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
                <label>目的地</label>
                    <asp:UpdatePanel ID="updatePanelDstPlace" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddlProvinceDst" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddlProvinceDst_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlCityDst" runat="server" AutoPostBack="True"  
                                onselectedindexchanged="ddlCityDst_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlCountyDst" runat="server" AutoPostBack="true" 
                                onselectedindexchanged="ddlCountyDst_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtDstPlaceCode" runat="server" ReadOnly="true"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </li>
            <li>
                <label>途经地名</label>
                <asp:TextBox ID="txtRouter" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>发车时间</label>
                     <asp:UpdatePanel ID="updatePanelTakeOffTime" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtTakeOffTime" runat="server" Width="100" />  
                            <asp:ImageButton id="imageButton" runat="server" ImageUrl="~/images/time.png" AlternateText="calendar" OnClick="ImageButton_Click" CausesValidation="false" />  
                            <br />  
                            <div id="calendar" class="calendar" visible="false" runat="server">  
                            <asp:Calendar ID="txtTakeOffCalendar" runat="server" 
                                    OnSelectionChanged="txtTakeOffCalendar_SelectionChanged" />  
                            </div>  
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </li>
            <li>
                <label>市场运价</label>
                <asp:TextBox ID="txtPrice" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>协议运价</label>
                <asp:TextBox ID="txtNegotiatePrice" runat="server" class="dfinput"></asp:TextBox>
            </li>
            <li>
                <label>车源类型</label>
                <asp:DropDownList ID="ddlTimeType" runat="server" ></asp:DropDownList>
            </li>
            <li>
                <label>往返类型</label>
                <asp:DropDownList ID="ddlReturnType" runat="server" ></asp:DropDownList>
            </li>
            <li>
                <label>备注</label>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>&nbsp;</label>
                <asp:Button ID="btnSubmit" runat="server" class="btn" Text="添加" 
                    onclick="btnSubmit_Click" />
                
            </li>
        </ul>
    
    </div>
    </form>
</body>
</html>
