<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotificationList.aspx.cs" Inherits="Trans.InfoList.NotificationList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>新闻公告列表界面</title>
    <meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
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
    <script type="text/javascript" src="../js/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
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
        function news_show() {
            var btnSet = $("#article_type").attr("value", "1");
            $.get("ArticleListHandler.ashx?pageNumber=1&pageSize=10&type=1", function (data) {
                $("#news_content").html(data);
            });
            var article_type = $("#article_type").val();
            news_page_change(article_type);
        }
        function notification_show() {
            var btnSet = $("#article_type").attr("value", "2");
            $.get("ArticleListHandler.ashx?pageNumber=1&pageSize=10&type=2", function (data) {
                $("#news_content").html(data);
            });
            var article_type = $("#article_type").val();
            news_page_change(article_type);
        }
    </script>

</head>
<body  onload="news_show()">
    <form id="form1" runat="server">
	    <div id="top">
        <p style="display: block;" id="back-to-top"><a href="#top"><span></span>返回顶部</a></p>
    <table width="100%">
      <tbody>
      <tr>
      <td id="logo">
      <img src="../imgs/index/logo.png"/>
      </td>
      <td><ul class="nav nav-tabs floating">
      			<li><a href="../index.aspx">返回首页</a></li>
                <li><a href="info.html?type=car">信息共享</a></li>
                <li><a href="#">物流黄页</a></li>
                <li><a href="../admin/MainFrame.aspx">我要发布</a></li>
         	</ul></td>
      </tr>
      </tbody>
    </table>
    </div>
        <div id="shadow"><%--<center><p id="announcement">紧要公告：本站于22222将进行维修</p></center>--%></div><!--若无最新公告则不显示，最新公告显示时间至公告失效-->
	    <div class="homepage-container">
          <div class=" white-bg right-container">
			<div class="tm-right-inner-container">
            	<div class="picNewsFrame">
                <table width="100%">
                  <tr>
                    <%--<td id="newsPic">
                  		<img id="newsPicture" src="../imgs/index/baymax.png">
                    </td>--%>
                    <td width="3%">&nbsp;</td>
                    <td id="newsContent">
                    	<a  href="#" class="newsTitle" id="newsTitle">河南省运输管理局一行考察川北物流平台</a>
                        <h5 class="gray">发布日期：<span id="deliverDate">2015-4-20</span></h5>
                        <p class="newsContent">4月16日，河南省道路运输管理局副局长龚全武同志、河南省“八挂来网”信息平台总经理侯爱民同志一行到“湖南平台”进行考察交流。 双方就落实交通运输部“1+32+nX”区域节点部署工作、区域平台创新发展和运行模式、“互联网+物流+金融”物流生态系统建设等事项进行了深入交流与探讨。双方一致认为，..</p>
                     <input id="btnlookIntoNews" class="item btn120 btnGreen2" value="立即查看" type="button"/>
                  	</td>
                  </tr>
                </table>
            	</div>
                <div class='container-fluid infoList'>
    				<div class='tabL'>
                      <ul class="nav nav-tabs" id="myTab">
                          <li class="active"><a onclick="news_show()" data-toggle='tab'>新闻中心</a></li>
                          <li><a onclick="notification_show()" data-toggle='tab'>公告中心</a></li>
                      </ul>
                      <div class="tab-content">
                          <div class="tab-pane active" id="news">
                              <div class="tableContainer">
                                  <div id="news_content" class="easyui-panel">  </div>
                                  <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>
                                  <input type="hidden" id="article_type" name="article_type" />
                              </div>
                          </div>
                          
                      </div>
                   </div>
                </div>
            </div>
          </div>
	</div>
    </form>
</body>
</html>
