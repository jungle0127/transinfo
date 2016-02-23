<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsContent.aspx.cs" Inherits="Trans.InfoList.NewsContent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
    function news_page_change(article_type) {
            $.post("ArticleItemsHandler.ashx", article_type, function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#news_content').panel('refresh', 'ArticleListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + "&type=" + article_type);
                    }
                });

            }, "text");
        }
        function set() {
            var btnSet = $("#article_type").attr("value", "2");
            $.get("ArticleListHandler.ashx?pageNumber=1&pageSize=10&type=2", function (data) {
                $("#news_content").html(data);
            });
            get();
        }
        function get() {
            var article_type = $("#article_type").val();
            news_page_change(article_type);
        }
</script>
</head>

<body onload="news_page_change('1')">
    <form id="form1" runat="server">
        <div>
            <hr />
            <input type="button" id="setTest" onclick="set()" value="Set" /> <input onclick="get()" type="button" id="getTest" value="Get" />
            <hr />
            <div id="news_content" class="easyui-panel"> <%=this.NewsFirstPageHtml%> </div>
            <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>
            <input type="hidden" id="article_type" name="article_type" />
        </div>
    </form>
  
</body>
</html>