﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepotInfoDetail.aspx.cs" Inherits="Trans.InfoShow.DepotInfoDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>信息共享界面</title>

    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css" />
    <link rel="Stylesheet" type="text/css" href="../css/main_style.css" />
    <script language="javascript" src="../js/js.js"></script>
    <script type="text/javascript">
    $(document).ready(function ($) {
        $('.grid-container').gridQuote();

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
                <li><a href="../backup/infodeliver.html">我要发布</a></li>
                <li><a href="logistics.html">物流黄页</a></li>
                <li><a href="news.html">查看公告</a></li>
                <li><a href="news.html">查看新闻</a></li>
         	</ul></td>
      </tr>
      </tbody>
    </table>
    </div>
    <div id="shadow"><center><p id="announcement">紧要公告：本站于22222将进行维修</p></center></div><!--若无最新公告则不显示，最新公告显示时间至公告失效-->
	<div class="homepage-container">
		<div class="black-bg left-container">
			<div class="tm-left-inner-container">
            	<ul class="nav nav-stacked nav-tabs homepage-nav">

				  <li><a href="../index.aspx"><i class="fa fa-medium"></i>返回首页</a></li>
				  <li><a href="../InfoList/TrunkInfoList.aspx" target="infoMain" class="active" ><i class="fa  fa-medium"></i>车源信息</a></li>
				  <li><a href="../InfoList/GoodsInfoList.aspx" target="infoMain" ><i class="fa  fa-medium"></i>货源信息</a></li>
				  <li><a href="../InfoList/SpeciallineInfoList.aspx" target="infoMain" ><i class="fa  fa-medium"></i>专线信息</a></li>
				  <li><a href="../InfoList/DepotInfoList.aspx" target="infoMain" ><i class="fa  fa-medium"></i>仓储信息</a></li>
                  <li><a href="#" target="_blank"><i class="fa fa-medium"></i>个人中心</a></li><!--当用户成功登陆才显示-->

				</ul>
            </div>
		</div>
        <div class=" white-bg right-container">
			<div class="tm-right-inner-container" id="frameBox">
                <iframe src="infoShare/lorry.html" name="infoMain" frameborder="0" width="100%" id="frameInfoDetail" class="frameInfoDetail" onload="frameHeight()" scrolling="no"></iframe>
            </div>
        </div>
	</div>

    </form>
</body>
</html>