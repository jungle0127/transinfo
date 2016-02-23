<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotificationContent.aspx.cs" Inherits="Trans.InfoList.NotificationContent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
	<script  type="text/javascript" language="javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="../js/js.js"></script>	
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<link href="../css/main_style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../themes/icon.css" />
	<link rel="Stylesheet" type="text/css" href="../css/demo.css" />
    
	<script type="text/javascript" src="../js/jquery.min.js"></script>
	<script type="text/javascript" src="../js/jquery.easyui.min.js"></script>

<script type="text/javascript">
    function notification_page_change() {
        $.post("ArticleItemsHandler.ashx", "2", function (item_count) {
            $('#pagination_manager_notification').pagination({
                total: item_count,
                pageSize: 10,
                layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                beforePageText: '第',
                afterPageText: '页，共 {pages}页',
                pageList: [10, 20, 50, 100],
                onSelectPage: function (pageNumber, pageSize) {
                    $('#notification_content_list').panel('refresh', 'ArticleListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + "&type=2");
                }
            });

        }, "text");
    }
</script>
</head>
<body onload="notification_page_change()">
    <form id="form1" runat="server">
    <div>
    <div id="notification_content_list" class="easyui-panel"> <%=this.NotificationFirstPageHtml%> </div>
    <div id="pagination_manager_notification" class="easyui-pagination" style="border:1px solid #ccc;" ></div>
                             
    </div>
    </form>
</body>
</html>
