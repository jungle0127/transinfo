﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepositoryList.aspx.cs" Inherits="Trans.admin.InformationManager.DepositoryList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>仓储信息管理</title>
    <link rel="stylesheet" type="text/css" href="../../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../../themes/icon.css" />
	<link rel="stylesheet" type="text/css" href="../../css/demo.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/style.css" />
	<script type="text/javascript" src="../../js/jquery.min.js"></script>
	<script type="text/javascript" src="../../js/jquery.easyui.min.js"></script>
    <script type="text/javascript">
        function delete_item(id){
            $.get("DepositoryHandler.ashx?id=" + String(id),function(msg){alert(msg);},"text");
        }
        function get_user_id() {
            return <%=UserId %>;
        }
        function page_change(){
            var user_id = get_user_id();
            $.post("DepositoryHandler.ashx",String(user_id),function(item_count){
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: 'Page',
                    afterPageText: 'of{pages}',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#content').panel('refresh', 'DepositoryHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + "&userid=" + user_id);
                    }
                });
            },"text");
        }
    </script>
</head>
<body style="background:#f0f9fd;" onload="page_change()">
    <form id="form1" runat="server">
        <div id="content" class="easyui-panel" style="height:400px" data-options="href:'DepositoryHandler.ashx?pageNumber=1&pageSize=10&userid=' + get_user_id()">
        </div>
        <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" >
        
        </div>
    </form>
</body>
</html>
