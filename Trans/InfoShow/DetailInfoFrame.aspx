<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailInfoFrame.aspx.cs" Inherits="Trans.InfoShow.DetailInfoFrame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>合作企业信息</title>
<link  rel="stylesheet" type="text/css" href="../css/style_thirdP.css" />
<link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css" />
<script type="text/javascript" src="../js/js.js"></script>
<script type="text/javascript" src="../js/jquery.min.js"></script>
<script type="text/javascript">
	 function get_url_parameter(param_name) { 
         var reg = new RegExp("(^|&)" + param_name + "=([^&]*)(&|$)", "i"); 
         var r = window.location.search.substr(1).match(reg); 
         if (r != null) return (r[2]); return null; 
     } 
	
	function switch_page(){
		var type = get_url_parameter("type");
        var id = get_url_parameter("id");
        if (type == "depot") {
            $("#frameInfoDetail").attr("src", "DepotInfoDetail.aspx?id=" + id);
        }
        else if (type == "goods") {
            $("#frameInfoDetail").attr("src", "GoodsInfoDetail.aspx?id=" + id);
        }
        else if (type == "line") {
            $("#frameInfoDetail").attr("src", "SpeciallineInfoDetail.aspx?id=" + id);
        }
        else if (type == "trunk") {
            $("#frameInfoDetail").attr("src", "TrunkInfoDetail.aspx?id=" + id);
        }
        else if (type == "news") {
            $("#frameInfoDetail").attr("src", "newsinfodetail.aspx?id=" + id);
        }
	}
</script>
</head>

<body onload="switch_page()">
<div class="top">
    <table>
    <tbody>
    <tr>
    <td  class="logo">
    <a href="#"><img alt="" src="../imgs/companys/company3.jpg" /></a></td>
    <td class="tab">
     <ul class="menus">
     <li><a href="Corporation/CompanyIntroduction.aspx" target="infoDetails" >公司简介</a></li>
     <li><a href="Corporation/CompanyHornor.aspx" target="infoDetails">荣誉资质</a></li>
     <li><a href="Corporation/CompanyContact.aspx" target="infoDetails">联系我们</a></li>
     <li><a href="companyInfoHistory.html" target="infoDetails">仓储信息</a></li>
     <li><a href="companyInfoHistory.html" target="infoDetails">专线信息</a></li>
     <li><a href="companyInfoHistory.html" target="infoDetails">车源信息</a></li>
     </ul>
    </td>
    </tr>
    </tbody>
    </table>
</div>
<table width="100%" height="100%">
	<tbody>
    	<tr>
        	<td class="left-side">
            <div class="banner">
              <div class="backMain">
                    <ul class="nav nav-stacked templatemo-nav">
                      <li class="titles"><i class="fa fa-medium"></i>平台导航</li>
                      <li><a href="../index.aspx"><i class="fa fa-medium"></i>返回首页</a></li>
                      <li><a href="../InfoList/info.html?type=car"><i class="fa fa-medium"></i>信息共享</a></li>
                      <li><a href="../InfoList/NotificationList.aspx"><i class="fa  fa-medium"></i>新闻中心</a></li>
                      <li><a href="../InfoList/NotificationList.aspx"><i class="fa fa-medium"></i>公告中心</a></li>
                      <li><a href="../admin/MainFrame.aspx"><i class="fa fa-medium"></i>我要发布</a></li>
                      <li><a href="../admin/MainFrame.aspx"><i class="fa fa-medium"></i>个人中心</a></li>
                    </ul>
              </div>
            </div>   
            </td>
            <td  class="right-side" id="frameBox">
				<div class="companyPic"><img alt="" src="../imgs/companys/2.jpg" class="imgComPic"/></div>
              	<iframe src="#" name="infoDetails" frameborder="0" width="100%" id="frameInfoDetail" class="frameInfoDetail" onload="frameHeight()" scrolling="no"></iframe>
            </td>
        </tr>
      </tbody>
</table>
<div class="bottom">
</div>
</body>
</html>
