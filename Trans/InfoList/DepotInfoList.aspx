<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepotInfoList.aspx.cs" Inherits="Trans.InfoList.DepotInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>存储信息列表</title>
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
          <asp:TextBox ID="keyword" placeholder="请输入关键字查询" class="inputSearchKey" runat="server"></asp:TextBox>

          </label>
          <%--<input id="searchBtn" class="anniu  inputSeachBtn" value="搜搜看" type="button">--%>
          <asp:Button ID="searchBtn" class="anniu  inputSeachBtn"  value="搜搜看" runat="server"  />

      </div>
  </div>
  <div class="searchSelectionFrame">
   <!--当仓储信息按钮被按下时显示该仓储信息-->
   <table  id="storeSelect" class="selectTb">
    <tbody>
    <tr><td class="firstTd">所在城市：</td><td class="secondTd"><ul class="selectLi">
    <%--<input type="text" id="inputStoreCity">--%>
    <asp:TextBox ID="inputStoreCity" runat="server"></asp:TextBox>
    
    </ul></td><td></td></tr>
      <tr>
        <td class="firstTd"><span>经营范围：</span></td>
        <td class="secondTd">
        <ul class="selectLi ulStorageScope">
        <li><a href="#" class="nolimit">不限</a></li>
        <li><a href="#">自有仓库</a></li>
        <li><a href="#">租用仓库</a></li>
        </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>仓库类型：</span></td>
        <td class="secondTd"><ul class="selectLi ulStorageType"><li><a href="#">不限</a></li><li><a href="#">普通</a></li><li><a href="#">综合</a></li><li><a href="#">冷藏</a></li><li><a href="#">保税</a></li><li><a href="#">恒温</a></li><li><a href="#">危险品</a></li><li><a href="#">立体</a></li><li><a href="#">露天</a></li><li><a href="#">货架</a></li><li><a href="#">堆场</a></li><li><a href="#">液体</a></li><li><a href="#">其他</a></li></ul></td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>面积范围：</span></td>
        <td class="secondTd"><ul class="selectLi ulStorageArea"><li><a href="#">不限</a></li><li><a href="#">10平米以下</a></li><li><a href="#">10-50平米</a></li><li><a href="#">50-90平米</a></li><li><a href="#">90-150平米</a></li><li><a href="#">150-250平米</a></li><li><a href="#">250-350平米</a></li><li><a href="#">350-550平米</a></li><li><a href="#">550平米以上</a></li></ul></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  </div>
  <div class="infoListFrame">
      <div class="tableContainer TC2">
       <!-----------------------------------仓储信息显示--------------------->
       <table class="table table-hover showStoreInfo">
            <caption><div id="tableCaption" style="padding-top:3px;"><img src="../../imgs/pack-2.png">仓储信息</div>
            <span class="tableMiddle"><div class="tableMiddle">相信您在这可以很快找到心仪的货源，祝您生活愉快！</div></span>
            </caption>
       <thead>
          <tr class="headTr">
             <th>信息内容</th>
             <th>发布时间</th>
             <th>参考报价</th>
             <th>立即查看</th>
          </tr>
       </thead>
        <tbody>

          <%--<tr>
             <td class="infoDeatil">
             <div class="storePic"></div>
             <div class="overFloat">
                 <a href="../InfoShow/DepotInfoDetail.aspx"><h4 class="infoTitle">福泰仓储5号库</h4></a>
                 <span class="light-info">面积：</span><span class="infos" id="totalArea">1500平米</span>|
                 <span class="light-info">可用面积：</span><span class="infos" id="useableArea">1300平米</span>|
                 <span class="light-info">经营范围：</span><span class="infos" id="storeScorp">自有仓库</span>
                 <p><span class="light-info">仓库类型：</span><span class="infos" id="storeType">冷藏</span>|
                 <span class="light-info">信息来源：</span><a  href="#" class="infos_companyN">湖南涟钢物流有限公司</a></p>
             </div>
             </td>
             <td><span class="infos" id="publishTime">14小时前</span></td>
             <td><span  id="prePrice">湖南长沙</span></td>
             <td><a class="moreBottn" href="#" target="_blank"><img src="../../imgs/plus_alt.png" id="moreBtn"></a></td>
          </tr>--%>

          <%=this.MessageHtmlDepot %>
        


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
