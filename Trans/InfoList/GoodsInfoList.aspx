<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsInfoList.aspx.cs" Inherits="Trans.InfoList.GoodsInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>货源信息列表</title>
    <link rel="stylesheet" type="text/css" href="../../css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../../css/main_style.css" />
    
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
          <asp:Button ID="searchBtn" class="anniu  inputSeachBtn" Text="搜搜看" runat="server"  />
      </div>
  </div>
  
  <div class="searchSelectionFrame">
  <!--当车源信息按钮被按下时显示该货源信息-->
  <table  id="goodsSelect" class="selectTb">
    <tbody>
    <tr><td class="firstTd">出发地：</td>
    <td class="secondTd"><ul class="selectLi">
    <%--<input type="text" id="starting" class="inputStartCity">--%>
    <asp:TextBox ID="starting" class="inputStartCity" runat="server" ></asp:TextBox>
    
    </ul></td><td></td></tr>
    <tr><td class="firstTd">目的地：</td><td class="secondTd"><ul class="selectLi">
    <%--<input type="text" id="ending" class="inputEndCity">--%>
    <asp:TextBox ID="ending" class="inputEndCity" runat="server" ></asp:TextBox>

    </ul></td><td></td></tr>
       <tr>
        <td class="firstTd"><span>货重：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulGoodsWeight">
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
      <tr>
        <td class="firstTd"><span>货物类型：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulGoodsType">
            <li><a href="#" class="nolimit">不限</a></li>
            <li><a href="#">普货</a></li>
            <li><a href="#">重货</a></li>
            <li><a href="#">泡货</a></li>
            <li><a href="#">整车</a></li>
            <li><a href="#">零担</a></li>
            <li><a href="#">设备</a></li>
            <li><a href="#">配件</a></li>
            <li><a href="#">电瓷</a></li>
            <li><a href="#">烟叶</a></li>
            <li><a href="#">棉纱</a></li>
            <li><a href="#">显像管</a></li>
            <li><a href="#">陶瓷</a></li>
            <li><a href="#">电器</a></li>
            <li><a href="#">建材</a></li>
            <li><a href="#">食品</a></li>
            <li><a href="#">车</a></li>
            <li><a href="#">农产品</a></li>
            <li><a href="#">其他</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>所需车长：</span></td><!--该部分的信息无需从数据库获取-->
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
    </tbody>
  </table>

  </div>
  <div class="infoListFrame">
      <div class="tableContainer TC2">
      <!-----------------------------------车源信息显示--------------------->
       <table class="table table-hover goodsList">
        <caption>
        <div id="tableCaption" style="padding-top:3px;"><img src="../../imgs/pack-2.png">货源信息</div>
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
             <a href="../InfoShow/GoodsInfoDetail.aspx" class="infoTitle goodsInfoTitle">湖南省长沙市→黑龙江省哈尔滨市,有17.5米半挂,求10吨货</a>
             <p><span class="light-info">所需车辆长度：</span><span class="infos spanNeedLength" id="carLength">17.5米</span>|
             <span class="light-info">货重：</span><span class="infos spanGoodsWeight" id="goodsWeight">13吨</span></p>
             <p><span class="light-info">信息来源：</span><a  href="#" class="goodsOrignLink">湖南涟钢物流有限公司</a></p>
             </td>
             <td><span class="infos goodsPublishTime" id="publishTime">14小时前</span></td>
             <td><span  class="spanGoodsPlace">湖南长沙</span></td>
             <td>
             <a class="moreBottn" href="#" target="_blank">
             <img src="../../imgs/plus_alt.png" id="moreBtn">
             <%--<asp:Image src="../../imgs/plus_alt.png" id="moreBtn" runat="server">
             
             </a>
             </td>
          </tr>--%>
          <%=this.MessageHtmlGoods %>


         
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
