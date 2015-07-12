<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Trans.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>川北物流首页</title>

<script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
<link rel="stylesheet" type="text/css" href="css/index_login.css" />
<link rel="Stylesheet" type="text/css" href="css/bootstrap.min.css" />
<script type="text/javascript" src="js/jquery.gridquote.min.js"></script>
<script language="javascript" src="js/js.js"></script>
<script type="text/javascript">
    $(document).ready(function ($) {
        $("#background").fullBg();
        $('.grid-container').gridQuote();
    });
</script>
</head>
<body>
    <img id="background" src="imgs/bg.jpg" />
    <form id="form1" runat="server">
        <table width="100%" class="homeBg" cellspacing="0">
             <tbody>
    <tr>
    <td id="home_top">
     <table width="100%">
      <tbody>
      <tr>
      <td id="logo"><img src="imgs/index/logo.png" alt=""/> </td>
      <td>
       <div id="phoneContainer">
  			<img src="imgs/index/phone.png"/>
            <span class="whiteBold">028-8888-8888</span>
       </div>
       <div class="nothing"></div>
      </td>
      <td>
         <div id="userI">
         <a href="admin/login.aspx" id="login—index">登陆</a><br /><br />
         <a href="InfoList/NotificationList.aspx">注册</a>
        </div>
      </td>
      </tr>
      </tbody>
     </table>
     </td>
     </tr>
     <tr>
     <td id="home_middle">
    <div class="wrapper">
	<div class="popover top">
		<div class="arrow"></div>
		<div class="popover-inner">
			<div class="popover-content">
				<p>显示各项内容</p>
			</div>
		</div>
	</div>

	<div class="grid-container">
		<div class="thumb-container first-thumb " data-title="公告详情>>" data-bgcolor="green">
			<MARQUEE class=p131 scrollAmount=1 scrollDelay=60  direction=up onmouseover="this.stop()" onmouseout="this.start ()">
             <table width="250" border="0" class="announceContainer">
               <tbody>
               <tr>
                <td class="title"><p class="whiteBold">网站公告</p></td>
               </tr>
               <tr>
               <td class="content">
                <ul class="announce white">
                	<li><a href="InfoList/info.html">关于提高货源车源信息质量提高物</a></li>
                	<li><a href="InfoList/info.html">《满意度有奖调查》双重豪礼送给</a></li>
                	<li><a href="InfoList/info.html">关于近期物流企业会员被投诉的处</a></li>
                	<li><a href="InfoList/info.html">配货信息部（普通会员）车源发布</a></li>
                	<li><a href="InfoList/info.html">物流专线带“运价”优先排名通知</a></li>
                </ul>
                </td>
               </tr>
               </tbody>
             </table>
            </MARQUEE>
		   <div class="quote-container">
           <table>
             <tbody>
             <tr>
             <td>
			   <div class="listnr newAnnounce"><!--此处div 放置最新的一条公告部分内容父节点类名若需要，则调用 newAnnounce--->
                <ul>
                 <li> <a href="InfoList/info.html" target="_blank"><font class="newAnnounceTitle">关于提高货源车源信息质量提高物流币竞价通知</font></a>
                 <div class="listneir"><a href="#" target="_blank" class="newAnnounceContentLink links green">非常感谢广大用户长期对中国物通网的鼎力支持和关爱，竞价排名做为当前营销中效果最好的推广工具之一，深得客户青睐，但有部分客户利用竞价排名推广其虚假货源信息、车源线路，造成了广大用户搜索使用上的困扰。为了 <span class="more">...更多&gt;&gt;</span></a></div>
                 </li>
                 </ul>
                </div>
              </td>
              <td><a href="InfoList/NotificationList.aspx"><img alt="" src="imgs/plus_alt.png" /></a></td>
             </tr>
             </tbody>
            </table>
			</div>
		</div>
		<div class="thumb-container second-thumb" data-title="信息共享>>" data-bgcolor="blue">
        
			<div class="quote-container">
             <div id="tabs" class="floating">
               <ul class="nav nav-tabs infoShare">
                  <li><a href="InfoList/info.html?type=car" id="car" class="lorryInfoLink">车源信息</a></li>
                  <li><a href="InfoList/info.html?type=goods" id="goods" class="goodsInfoLink">货源信息</a></li><!--点击先跳转到info界面，判断当前点击对象，在info主frame中调用对应的html-->
                  <li><a href="InfoList/info.html?type=line" id="line" class="linesInfoLink">专线信息</a></li>
                  <li><a href="InfoList/info.html?type=store" id="store" class="storageInfoLink">仓储信息</a></li>
               </ul>
             </div>
           </div>
        </div>
		<div class="thumb-container third-thumb" data-title="物流黄页>>" data-bgcolor="pink" >
		
		    <div class="quote-container">
              <table>
               <tbody>
                <tr>
                 <td>
                 <div class="picNewsFrame" id="pic_roll">
                   <ul>		
                        <li><a href="html/thirdLevel/company.html"><img src="imgs/companys/img9.jpg"/></a></li><!--跳转至各个企业的页面-->
                        <li><a href="#"><img src="imgs/companys/img8.jpg"/></a></li>
                        <li><a href="#"><img src="imgs/companys/img1.jpg"/></a></li>
                        <li><a href="#"><img src="imgs/companys/img2.jpg"/></a></li>

                    </ul>	
                  </div>
                  </td>
                 <td>
                 <div id="toLogistics">
                 	<a href="html/logistics.html"><img src="imgs/plus_alt.png" /></a>
                    <span>前往物流黄页获取更多</span>
                  </div>
                 </td>
                </tr>
               </tbody>
              </table>
            </div>
		</div>
		<div class="thumb-container fourth-thumb" data-title="我要发布>>">
			<div class="quote-container">
			 <div id="tabs2">
             <ul class="nav nav-tabs infoDeliver">
                <li><a href="#" class="deliverLorry" id="deliverLorry">发布车源信息</a></li>
                <li><a href="#" class="deliverGoods" id="deliverGoods">发布货源信息</a></li>
                <li><a href="#" class="deliverLine" id="deliverGoods">发布专线信息</a></li>
                <li><a href="#" class="deliverStorage" id="deliverGoods">发布存储信息</a></li>
             </ul></div>	
			</div>
		</div>
		<div class="thumb-container fifth-thumb" data-title="关于我们>>" data-bgcolor="pink">
        
			<div class="quote-container">
				<p><span class="plateName">川北物流信息服务公司</span><hr />
               <span  class="green">我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！ <br/>我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！我们综合了多年的心得来设计这两个物流中心，坚信必定能让顾客感到满意。此外，我们更可按顾客的需求度身订造物流方案。除了基本的陆运及海运服务外，我们还可以满足顾客对报关、买卖等代理贸易以及提供作业设施等服务的需求。我们努力成为各位在中国的最佳物流伙伴！</span></p>
			</div>
		</div>
		<div class="thumb-container sixth-thumb" data-title="新闻播报>>" data-bgcolor="green">
           <MARQUEE class=p131 scrollAmount=1 scrollDelay=60  direction=up onmouseover="this.stop()" onmouseout="this.start ()">
             <table width="250" border="0" class="announceContainer">
               <tbody>
               <tr>
                <td class="title"><p class="whiteBold">新闻动态</p></td>
               </tr>
               <tr>
               <td class="content white">
                <ul class="news">
                <li><a href="InfoList/NewsList.aspx">关于提高货源车源信息质量提高物</a></li>
                <li><a href="InfoList/NewsList.aspx">《满意度有奖调查》双重豪礼送给</a></li>
                <li><a href="InfoList/NewsList.aspx">关于近期物流企业会员被投诉的处</a></li>
                <li><a href="InfoList/NewsList.aspx">配货信息部（普通会员）车源发布</a></li>
                <li><a href="InfoList/NewsList.aspx">物流专线带“运价”优先排名通知</a></li>
                </ul>
                </td>
               </tr>
               </tbody>
             </table>
            </MARQUEE>
			<div class="quote-container">
			<table>
             <tbody>
             <tr>
             <td>
				<div class="listnr news">
                <ul>
                 <li> <a href="InfoList/NewsList.aspx" target="_blank"><font class="newsTitle">关于提高货源车源信息质量提高物流币竞价通知</font></a>
                 <div class="listneir"><a href="#" target="_blank" class="newsContentLink links green">非常感谢广大用户长期对中国物通网的鼎力支持和关爱，竞价排名做为当前营销中效果最好的推广工具之一，深得客户青睐，但有部分客户利用竞价排名推广其虚假货源信息、车源线路，造成了广大用户搜索使用上的困扰。为了<span class="more green">...更多&gt;&gt;</span></a></div>
                 </li>
                 </ul>
                </div>
              </td>
              <td><a href="InfoList/NewsList.aspx"><img alt="" src="imgs/plus_alt.png" /></a></td>
             </tr>
             </tbody>
            </table>
			</div>
		</div>
        </div>
        </div>
      </td> 
    </tr>
  </tbody>
        </table>
        <div id="footer">
      <div class="footer-bg"></div>
      <div id="footer_about">
                    <a href="#" target="_blank">关于平台</a> | 
                    <a href="#" target="_blank">网站地图</a> | 
                    <a href="#" target="_blank">法律声明</a> | 
                    <a href="#" target="_blank">下载中心</a> | 
                    <a href="#" target="_blank">公司邮箱</a>
        </div>
        <div id="footer_copyright"> copyright©2015 川北物流信息服务有限公司 <a href="#" target="_blank">川ICP备13003937号-1</a></div>
        </div>
    </form>
</body>
</html>
