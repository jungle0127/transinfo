<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrunkInfoList.aspx.cs" Inherits="Trans.InfoList.TrunkInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>车源信息列表</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="../../css/main_style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
      <div class="searchFrame">
      <div class="totalInfo">
      在线车源：<span id="totalLorry" class="red spanTotalLorry">333333</span>
      实时货源：<span id="totalGoods" class="red spanTotalGoods">888888</span>
      </div>
      <div class="dainput">
          <label class="left">
          <%--<input id="keyword" placeholder="请输入关键字查询" class="inputSearchKey" type="text">--%>
          <asp:TextBox ID="keyword" placeholder="请输入关键字查询" class="inputSearchKey"  runat="server"></asp:TextBox>
          </label>
          <%--<input id="searchBtn" class="anniu  inputSeachBtn" value="搜搜看" type="button">--%>
          <asp:Button ID="Button1" class="anniu  inputSeachBtn" Text="搜搜看" runat="server"  />
      </div>
  </div>
  
  <div class="searchSelectionFrame">
  <!--当车源信息按钮被按下时显示该车源信息-->
  <table  id="carSelect" class="selectTb">
    <tbody>
    <tr><td class="firstTd">出发地：</td><td class="secondTd"><ul class="selectLi">
    <%--<input type="text" id="starting" class="inputStartCity">--%>
    <asp:TextBox ID="starting" class="inputStartCity"  runat="server"></asp:TextBox>

    </ul></td><td></td></tr>
    <tr><td class="firstTd">目的地：</td><td class="secondTd"><ul class="selectLi">
    <%--<input type="text" id="ending" class="inputEndCity">--%>
    <asp:TextBox ID="ending" class="inputEndCity"  runat="server"></asp:TextBox>

    </ul></td><td></td></tr>
      <tr>
        <td class="firstTd"><span>车辆类型：</span></td>
        <td class="secondTd">
          <ul class="selectLi ulLorryType">
            <li><a href="#" class="nolimit">不限</a></li>
            <li><a href="#">货车</a></li>
            <li><a href="#">自卸车</a></li>
            <li><a href="#">冷藏车</a></li>
            <li><a href="#">油罐车</a></li>
            <li><a href="#">保温车</a></li>
            <li><a href="#">起重车</a></li>
            <li><a href="#">铁笼车</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>车体状况：</span></td>
        <td class="secondTd">
          <ul class="selectLi ulLorryStatus">
            <li><a href="#" class="nolimit">不限</a></li>
            <li><a href="#">平板车</a></li>
            <li><a href="#">前四后八</a></li>
            <li><a href="#">半挂</a></li>
            <li><a href="#">箱式</a></li>
            <li><a href="#">单桥</a></li>
            <li><a href="#">四桥</a></li>
            <li><a href="#">低栏</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>车长：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulLorryLength">
            <li><a href="#" class="nolimit">不限</a></li>
            <li><a href="#">3米以下</a></li>
            <li><a href="#">3-6米</a></li>
            <li><a href="#">6-10米</a></li>
            <li><a href="#">10-13米</a></li>
            <li><a href="#">13-16米</a></li>
            <li><a href="#">16米以上</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
       <tr>
        <td class="firstTd"><span>载重：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulLorryWeight">
            <li><a href="#" class="nolimit">不限</a></li>
            <li><a href="#">5吨以下</a></li>
            <li><a href="#">5-9吨</a></li>
            <li><a href="#">10-19吨</a></li>
            <li><a href="#">20-29吨</a></li>
            <li><a href="#">30-39吨</a></li>
            <li><a href="#">40吨以上</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
    </tbody>
  </table>

  </div>
  <div class="infoListFrame">
      <div class="tableContainer TC2">
      <!-----------------------------------车源信息显示--------------------->
       <table class="table table-hover lorryList">
        <caption>
        <div id="tableCaption" style="padding-top:3px;"><img src="../../imgs/lorry.png">车源信息</div>
        <span class="tableMiddle"><div class="tableMiddle">相信您在这可以很快找到心仪的货源，祝您生活愉快！</div></span>
        </caption>
        <thead>
          <tr class="headTr">
             <th>信息内容</th>
             <th>发布时间</th>
             <th>所在地</th>
             <th>立即查看</th>
          </tr>
        </thead>
        <tbody>
          <%--<tr>
             <td>
             <a href="../InfoShow/TrunkInfoDetail.aspx" class="infoTitle h4LorryInfoTitle">湖南省长沙市→黑龙江省哈尔滨市,有17.5米半挂,求10吨货</a>
             <p><span class="light-info">车辆长度：</span><span class="infos spanLorryLength" id="carLength">17.5米</span>|
             <span class="light-info">载重：</span><span class="infos spanLorryWeight" id="carWeight">13吨</span></p>
             <p><span class="light-info">信息来源：</span><a  href="#" class="lorryCompanyLink">湖南涟钢物流有限公司</a></p>
             </td>
             <td><span class="infos lorryPublishTime" id="publishTime">14小时前</span></td>
             <td><span  class="spanLorryPlace">湖南长沙</span></td>
             <td>
             <a class="moreBottn" href="#" target="_blank"><img src="../../imgs/plus_alt.png" id="moreBtn"></a>
             </td>
          </tr>--%>
          <%=this.Message1 %>
          
       </tbody>
    </table>
    </div>
    <div class="fenye"><!-----分页-------->
      <div id="page">
          <a class="now_page">1</a>
          <a href="# p=2">2</a>
          <a href="# p=3">3</a>
          <a href="#?p=4">4</a>
          <a href="#?p=5">5</a>
          <span>...</span>
          <a href="#?p=14">14</a>
          <a href="#?p=2">&gt;</a>
      </div>
   </div>
   </div>

    </form>
</body>
</html>
