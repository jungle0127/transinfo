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
    <script type="text/javascript" src="../js/goodsformat.js"></script>
    <script type="text/javascript">
        function page_change(parameters) {
            $.post("GoodsInformationHandler.ashx", parameters, function (data) {
                $('#pagination_manager').pagination({
                    total: data.item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + '&bitparams=' + data.params);
                    }
                });
            },"json");
        }
        function initiate_load() {
            var parameters = {};
            var jsonStr = JSON.stringify(parameters);
            page_change(jsonStr);
            $("#tmpStore").val(deformatJSON(parameters));
        }
        function srcCityRestrict() {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.srcCityId = $("#ddlCity").val();
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function dstCityRestrict() {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.dstCityId = $("#ddlCityDst").val();
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function weightRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.weight = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function typeRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.typeId = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#front_goods_pagination_content').panel('refresh', 'GoodsInformationHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
    </script>
</head>
<body onload="initiate_load()">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <div class="searchFrame">
      <div class="totalInfo">
      在线车源：<span id="totalLorry" class="red spanTotalLorry">333333</span>
      实时货源：<span id="totalGoods" class="red spanTotalGoods">888888</span>
      </div>
  </div>
  
        <div class="searchSelectionFrame">
  <!--当车源信息按钮被按下时显示该货源信息-->
  <table  id="goodsSelect" class="selectTb">
    <tbody>
    <tr>
        <td class="firstTd">出发地：</td>
        <td class="secondTd">
            <asp:UpdatePanel ID="updatePanelLocatedPlace" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlProvince_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True"  
                        onselectedindexchanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCounty" runat="server" AutoPostBack="true"  onchange="srcCityRestrict()"
                        onselectedindexchanged="ddlCounty_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtSrcPlaceCode" runat="server" Visible="false" ReadOnly="true"></asp:TextBox>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="firstTd">目的地：</td>
        <td class="secondTd">
          <asp:UpdatePanel ID="updatePanelDstPlace" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="ddlProvinceDst" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlProvinceDst_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlCityDst" runat="server" AutoPostBack="True"  
                    onselectedindexchanged="ddlCityDst_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlCountyDst" runat="server" AutoPostBack="true" onchange="dstCounty()" 
                    onselectedindexchanged="ddlCountyDst_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:TextBox ID="txtDstPlaceCode" runat="server" Visible="false" ReadOnly="true"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
        </td>
        <td></td>
    </tr>
       <tr>
        <td class="firstTd"><span>货重：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulGoodsWeight">
            <li><a href="#" onclick="weightRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="weightRestrict('1')">5吨以下</a></li>
            <li><a href="#" onclick="weightRestrict('2')">5-9吨</a></li>
            <li><a href="#" onclick="weightRestrict('3')">10-19吨</a></li>
            <li><a href="#" onclick="weightRestrict('4')">20-29吨</a></li>
            <li><a href="#" onclick="weightRestrict('5')">30-39吨</a></li>
            <li><a href="#" onclick="weightRestrict('6')">40吨以上</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>货物类型：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulGoodsType">
            <li><a href="#" onclick="typeRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="typeRestrict('1')">设备</a></li>
            <li><a href="#" onclick="typeRestrict('2')">煤炭</a></li>
            <li><a href="#" onclick="typeRestrict('3')">矿产</a></li>
            <li><a href="#" onclick="typeRestrict('4')">钢材</a></li>
            <li><a href="#" onclick="typeRestrict('5')">饲料</a></li>
            <li><a href="#" onclick="typeRestrict('6')">建材</a></li>
            <li><a href="#" onclick="typeRestrict('7')">木材</a></li>
            <li><a href="#" onclick="typeRestrict('8')">粮食</a></li>
            <li><a href="#" onclick="typeRestrict('9')">食品</a></li>
            <li><a href="#" onclick="typeRestrict('10')">饮料</a></li>
            <li><a href="#" onclick="typeRestrict('11')">蔬菜</a></li>
            <li><a href="#" onclick="typeRestrict('12')">电器</a></li>
            <li><a href="#" onclick="typeRestrict('13')">化工产品</a></li>
            <li><a href="#" onclick="typeRestrict('14')">畜产品</a></li>
            <li><a href="#" onclick="typeRestrict('15')">其他</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
    </tbody>
  </table>
  </div>
        
        <div class="infoListFrame">
            <div id="front_goods_pagination_content" class="tableContainer TC2 easyui-panel" data-options="href:'GoodsInformationHandler.ashx?pageNumber=1&pageSize=10&bitparams=0-0-0-0'">  </div>
            <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;"></div>
        </div>
        <input id="tmpStore" type="hidden" value="" />
    </form>
</body>
</html>
