<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Trans.InfoList.NewsList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新闻公告列表界面</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
	<script language="javascript" src="../js/bootstrap.min.js"></script>
    <script language="javascript" src="../js/js.js"></script>	
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="../css/main_style.css" rel="stylesheet" type="text/css">
    <script >
        $(document).ready(function () {
            backToTop();
        });
	</script>
</head>
<body>
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
                <li><a href="info.html">信息共享</a></li>
                <li><a href="logistics.html">物流黄页</a></li>
                <li><a href="#">我要发布</a></li>
         	</ul></td>
      </tr>
      </tbody>
    </table>
    </div>
    <div id="shadow"><center><p id="announcement">紧要公告：本站于22222将进行维修</p></center></div><!--若无最新公告则不显示，最新公告显示时间至公告失效-->
	<div class="homepage-container">
          <div class=" white-bg right-container">
			<div class="tm-right-inner-container">
            	<div class="picNewsFrame">
                <table width="100%">
                  <tr>
                    <td id="newsPic">
                  		<img id="newsPicture" src="../imgs/index/baymax.png">
                    </td>
                    <td width="3%">&nbsp;</td>
                    <td id="newsContent">
                    	<a  href="#" class="newsTitle" id="newsTitle">河南省运输管理局一行考察川北物流平台</a>
                        <h5 class="gray">发布日期：<span id="deliverDate">2015-4-20</span></h5>
                        <p class="newsContent">4月16日，河南省道路运输管理局副局长龚全武同志、河南省“八挂来网”信息平台总经理侯爱民同志一行到“湖南平台”进行考察交流。 双方就落实交通运输部“1+32+nX”区域节点部署工作、区域平台创新发展和运行模式、“互联网+物流+金融”物流生态系统建设等事项进行了深入交流与探讨。双方一致认为，..</p>
                     <%--<input id="btnlookIntoNews" class="item btn120 btnGreen2" value="立即查看" type="button">--%>
                     <asp:Button ID="btnlookIntoNews" class="item btn120 btnGreen2" Text="立即查看" runat="server"  />
                  	</td>
                  </tr>
                </table>
            	</div>
                <div class='container-fluid infoList'>
    				<div class='tabL'>
                      <ul class="nav nav-tabs" id="myTab">
                          <li class="active"><a href="#news" data-toggle='tab'>新闻中心</a></li>
                          <li><a href="#notice" data-toggle='tab'>公告中心</a></li>
                      </ul>
                      <div class="tab-content">
                          <div class="tab-pane active" id="news">
                              <div class="tableContainer">
                                  <table class="table table-hover newsList">
                                      <tbody>
                                      <tr>
                                      <td width="90%"><a href="thirdLevel/newsContent.html">促进湖南内河航运发展研讨会在长沙召开【图】</a></td>
                                      <td width="10%">2015-5-2</td>
                                      </tr>
                                      
                                      </tbody>
                                  </table>
                                 
                              </div>
                          </div>
                          <div class="tab-pane" id="notice">
                             <div class="tableContainer">
                                  <table class="table table-hover noticeList">
                                      <tbody>
                                      <tr>
                                      <td width="90%"><a href="#">促进湖南内河航运发展研讨会在长沙召开</a></td>
                                      <td width="10%">2015-5-2</td>
                                      </tr>
                                      
                                      </tbody>
                                  </table>
                              </div>
                          </div>
                      </div>
                   </div>
                   <div class="newPage">放置翻页按钮</div><!--只当显示条数超过一定数量时才显示---->
                </div>
            </div>
          </div>
	</div>


    </form>
</body>
</html>
