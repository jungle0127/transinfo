﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotificationList.aspx.cs" Inherits="Trans.admin.promulagate.NotificationList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>公告管理</title>
    <link rel="stylesheet" type="text/css" href="../../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../../themes/icon.css" />
	<link rel="stylesheet" type="text/css" href="../../css/demo.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/style.css" />
	<script type="text/javascript" src="../../js/jquery.min.js"></script>
	<script type="text/javascript" src="../../js/jquery.easyui.min.js"></script>
    <script type="text/javascript">
        function delete_article(id) {
            $.post("ArticleDeleteHandler.ashx", String(id), function (msg) { alert(msg); }, "text");
            page_change();
        }
        function page_change() {
            $.post("ItemsCountHandler.ashx", "2", function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: 'Page',
                    afterPageText: 'of{pages}',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#content').panel('refresh', 'NewsListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + "&type=2");
                    }
                });

            }, "text");
        }
  </script>    
</head>
<body onload="page_change()">
    <form id="form1" runat="server">
        <div id="content" class="easyui-panel" style="height:400px" data-options="href:'NewsListHandler.ashx?pageNumber=1&pageSize=10&type=2'"> </div>
        <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" >


        </div>
    </form>
        

</body>
</html>
