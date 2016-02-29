<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepotInfoList.aspx.cs" Inherits="Trans.InfoList.DepotInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>存储信息列表</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../css/main_style.css" rel="stylesheet" type="text/css" />
    <meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<script type="text/javascript" src="../js/jquery.min.js"></script>
	<script type="text/javascript" charset="gb2312" src="../js/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../js/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript" src="../js/depotformat.js"></script>
	<script  type="text/javascript" language="javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="../js/js.js"></script>	
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<link href="../css/main_style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../themes/icon.css" />
	<link rel="Stylesheet" type="text/css" href="../css/demo.css" />
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
    <script type="text/javascript">
        function countyRestrict() {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.cityId = $("#ddlCity").val();
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            depot_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function initiate_load() {
            var parameters = {};
            var jsonStr = JSON.stringify(parameters);
            depot_page_change(jsonStr);
            $("#tmpStore").val(deformatJSON(parameters));
        }
        function depot_page_change(data) {
            $.post("DepotListHandler.ashx", data, function (jsonData) {
                $('#pagination_manager').pagination({
                    total: jsonData.item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + '&bitparams=' + jsonData.params);
                    }
                });

            }, "json");
        }
        function scopeRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.scopeId = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            depot_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function typeRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.typeId = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            depot_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function areaRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.area = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            depot_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
    </script>
</head>
<body onload="initiate_load()" >
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <div class="searchFrame">
      <div class="totalInfo">
      在线车源：<span id="totalLorry" class="red spanTotalLorry"><%=this.TotalLorry %></span>
      实时货源：<span id="totalGoods" class="red spanTotalGoods"><%=this.TotalGoods %></span>
      </div>
  </div>
  <div class="searchSelectionFrame">
   <!--当仓储信息按钮被按下时显示该仓储信息-->
   <table  id="storeSelect" class="selectTb">
    <tbody>
    <tr>
        <td class="firstTd">所在城市：</td>
        <td class="secondTd">
        <asp:UpdatePanel ID="updatePanelLocatedPlace" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlProvince_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True"  
                        onselectedindexchanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCounty" runat="server" AutoPostBack="true"  onchange="countyRestrict()"
                        onselectedindexchanged="ddlCounty_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtSrcPlaceCode" runat="server" Visible="false" ReadOnly="true"></asp:TextBox>
                </ContentTemplate>
        </asp:UpdatePanel>
        </td>
        <td></td>
    </tr>
      <tr>
        <td class="firstTd">产权<span>类型：</span></td>
        <td class="secondTd">
        <ul class="selectLi ulStorageScope">
        <li><a href="#" onclick="scopeRestrict('0')" class="nolimit">不限</a></li>
        <li><a href="#" onclick="scopeRestrict('1')">自有仓库</a></li>
        <li><a href="#" onclick="scopeRestrict('2')">租用仓库</a></li>
        </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>仓库类型：</span></td>
        <td class="secondTd">
            <ul class="selectLi ulStorageType">
                <li><a href="#" onclick="typeRestrict('0')">不限</a></li>
                <li><a href="#" onclick="typeRestrict('1')">普通</a></li>
                <li><a href="#" onclick="typeRestrict('2')">综合</a></li>
                <li><a href="#" onclick="typeRestrict('3')">保税</a></li>
                <li><a href="#" onclick="typeRestrict('4')">冷藏</a></li>
                <li><a href="#" onclick="typeRestrict('5')">恒温</a></li>
                <li><a href="#" onclick="typeRestrict('6')">危险品</a></li>
                <li><a href="#" onclick="typeRestrict('7')">立体</a></li>
                <li><a href="#" onclick="typeRestrict('8')">露天</a></li>
                <li><a href="#" onclick="typeRestrict('9')">货架</a></li>
                <li><a href="#" onclick="typeRestrict('10')">液体</a></li>
                <li><a href="#" onclick="typeRestrict('11')">堆场</a></li>
                <li><a href="#" onclick="typeRestrict('12')">其他</a></li>
                </ul></td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>面积范围：</span></td>
        <td class="secondTd">
            <ul class="selectLi ulStorageArea">
                <li><a href="#" onclick="areaRestrict('0')">不限</a></li>
                <li><a href="#" onclick="areaRestrict('1')">10平米以下</a></li>
                <li><a href="#" onclick="areaRestrict('2')">10-50平米</a></li>
                <li><a href="#" onclick="areaRestrict('3')">50-90平米</a></li>
                <li><a href="#" onclick="areaRestrict('4')">90-150平米</a></li>
                <li><a href="#" onclick="areaRestrict('5')">150-250平米</a></li>
                <li><a href="#" onclick="areaRestrict('6')">250-350平米</a></li>
                <li><a href="#" onclick="areaRestrict('7')">350-550平米</a></li>
                <li><a href="#" onclick="areaRestrict('8')">550平米以上</a></li>
             </ul></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  </div>
  <div class="infoListFrame">
      <div class="tableContainer TC2">
       <!-----------------------------------仓储信息显示--------------------->
       
       <div id="depot_content" class="easyui-panel"  data-options="href:'DepotListHandler.ashx?pageNumber=1&pageSize=10&bitparams=0-0-0-0'"> </div>
       <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>






    </div>
    
  </div>

    </form>
    <input id="tmpStore" type="hidden" value="" />
</body>
</html>
