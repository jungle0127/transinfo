<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsInformationList.aspx.cs" Inherits="Trans.InfoList.GoodsInformationList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>货源信息</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/main_style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../themes/icon.css" />
	<link rel="Stylesheet" type="text/css" href="../css/demo.css" />
	<script type="text/javascript" src="../js/jquery.min.js"></script>
	<script type="text/javascript" src="../js/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../js/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function page_change(){
            $.post("GoodsInformationHandler.ashx", "1", function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize);
                    }
                });
            },"text");
        }
    </script>
</head>
<body onload="page_change()">
    <form id="form1" runat="server">
        <div class="searchFrame">
      <div class="totalInfo">
      在线车源：<span id="totalLorry" class="red spanTotalLorry">333333</span>
      实时货源：<span id="totalGoods" class="red spanTotalGoods">888888</span>
      </div>
      <div class="dainput">
          <label class="left"><input id="keyword" placeholder="请输入关键字查询" class="inputSearchKey" type="text"></label>
          <input id="searchBtn" class="anniu  inputSeachBtn" value="搜搜看" type="button">
      </div>
  </div>
  
        <div class="searchSelectionFrame">
  <!--当车源信息按钮被按下时显示该货源信息-->
  <table  id="goodsSelect" class="selectTb">
    <tbody>
    <tr><td class="firstTd">出发地：</td><td class="secondTd"><ul class="selectLi"><input type="text" id="starting" class="inputStartCity"></ul></td><td></td></tr>
    <tr><td class="firstTd">目的地：</td><td class="secondTd"><ul class="selectLi"><input type="text" id="ending" class="inputEndCity"></ul></td><td></td></tr>
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
            <div id="front_goods_pagination_content" class="tableContainer TC2 easyui-panel">
                <%=this.FirstPageInformation %>
            </div>
            <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;"></div>
        </div>
    </form>
</body>
</html>
