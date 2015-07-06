<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="newspublisher.aspx.cs" Inherits="Trans.admin.promulagate.newspublisher" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新闻发布</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script src="../kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="../kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/code/prettify.js" type="text/javascript"></script>  
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.create('#txtContent', {
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
<body style="background:#f0f9fd;">
    <form id="form1" runat="server">
        <div class="formbody">
            <ul class="forminfo">    
                <li>
                    <label>标题</label>
                    <asp:TextBox ID="txtTitle" class="dfinput" runat="server" name=""> </asp:TextBox>
                </li>
                <li>
                    <label>公告类型</label>
                    <asp:DropDownList runat="server" ID="ddlArticleType"  class="dfinput">
                        <asp:ListItem Text="新闻" Value="1"></asp:ListItem>
                        <asp:ListItem Text="公告" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </li>
                <li>
                    <label>是否置顶</label>
                    <asp:CheckBox runat="server" ID="cbIstop" Checked="false" />
                </li>
                <li>
                        <label></label>
                        <asp:TextBox runat="server" ID="txtContent" TextMode="MultiLine" ></asp:TextBox>
                </li>
                <li>
                    <label>&nbsp;</label>
                    <asp:Button runat="server" ID="btnSubmit" name="" 
                            class="btn" Text="提交" onclick="btnSubmit_Click" ></asp:Button>
                    
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
