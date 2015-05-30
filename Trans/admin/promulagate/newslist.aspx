<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newslist.aspx.cs" Inherits="Trans.admin.promulagate.newslist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新闻管理</title>
    <link rel="stylesheet" type="text/css" href="../../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../../themes/icon.css" />
	<link rel="stylesheet" type="text/css" href="../../css/demo.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/style.css" />
	<script type="text/javascript" src="../../js/jquery.min.js"></script>
	<script type="text/javascript" src="../../js/jquery.easyui.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div id="content" class="easyui-panel" style="height:400px" data-options="href:'NewsListHandler.ashx?pageNumber=1&pageSize=10'"> </div>
    <div class="easyui-pagination" style="border:1px solid #ccc;" data-options="
        total: 2000,
        pageSize: 10,
        onSelectPage: function(pageNumber, pageSize){
        $('#content').panel('refresh', 'NewsListHandler.ashx?pageNumber='+pageNumber+'&pageSize='+pageSize);
        }">



    </div>
    </form>
        

</body>
</html>
