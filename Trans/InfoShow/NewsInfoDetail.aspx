<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsInfoDetail.aspx.cs" Inherits="Trans.InfoShow.NewsInfoDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新闻公告内容</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css" \>
	<link href="../../css/main_style.css" rel="stylesheet" type="text/css" \>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" language="javascript" src="../js/js.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
</head>
<body>
    <form id="form1" runat="server">
    
    	<div id="top">
    <p style="display: block;" id="back-to-lastPage"><a href="../news.html"><span></span>返回上级</a></p>
    <p style="display: block;" id="back-to-top"><a href="#top"><span></span>返回顶部</a></p>
    <table width="100%">
      <tbody>
      <tr>
      <td id="logo">
      <img src="../../imgs/index/logo.png"/>
      </td>
      <td><ul class="nav nav-tabs floating">
      			<li><a href="../../index.html">返回首页</a></li>
                <li><a href="../info.html">信息共享</a></li>
                <li><a href="../logistics.html">物流黄页</a></li>
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
            	</div>
                <div class="searchSelectionFrame infoDetail">
                	<p class="newsTitle" id="title">河南省运输管理局一行考察川北物流平台</p>
                    <center><p>发布日期：<span id="deliverDate" class="gray">2015-4-20</span>&nbsp;&nbsp;访问次数：<span id="visitTimes" class="gray">2333</span></p></center><!--动态获取时间，访问次数--->
                    <table width="100%">
                      <tr>
                        <td class="preSwitch"><a class="green" href="#">上一篇:<span id="preArticle">部科学研究院来湘专题调研“湖南平台”建设与应用推进..</span></a></td>
                        <td class="nextSwitch"><a class="green" href="#">下一篇:<span id="nextArticle">部科学研究院来湘专题调研“湖南平台”建设与应用推进..</span></a></td><!--动态加载--若没有上一篇或者下一篇，则不显示-->
                      </tr>
                    </table>
                    <hr style="margin-top:5px;">
                    <div class="newsContent newsDetail">
                    	<div class="pictureNews"><img  id="newsPicture" src="../../imgs/newsPic.jpg"></div><!--动态添加新闻图片，若无图片则不显示-->			<div id="content"> 4月16日，河南省道路运输管理局副局长龚全武同志、河南省“八挂来网”信息平台总经理侯爱民同志一行到“湖南平台”进行考察交流。
双方就落实交通运输部“1+32+nX”区域节点部署工作、区域平台创新发展和运行模式、“互联网+物流+金融”物流生态系统建设等事项进行了深入交流与探讨。双方一致认为，应加大整合区域内交通行政信息资源和物流市场信息资源的力度。下阶段将在两省省际之间率先实现物流园区信息互联。
湖南省联合运输办公室副主任卢勤学同志出席交流会。
						</div><!--动态加载带格式的文章-->
                    </div>
                    <hr style="margin-bottom:0;">
                    <table width="100%">
                      <tr>
                        <td class="preSwitch"><a class="green" href="#">上一篇:<span id="preArticle">部科学研究院来湘专题调研“湖南平台”建设与应用推进..</span></a></td>
                        <td class="nextSwitch"><a class="green" href="#">下一篇:<span id="nextArticle">部科学研究院来湘专题调研“湖南平台”建设与应用推进..</span></a></td><!--动态加载--若没有上一篇或者下一篇，则不显示-->
                      </tr>
                    </table>
                </div>
            </div>
          </div>
	</div>









    </form>
</body>
</html>
