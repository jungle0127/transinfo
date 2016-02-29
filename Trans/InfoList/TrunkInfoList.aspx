<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrunkInfoList.aspx.cs" Inherits="Trans.InfoList.TrunkInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>车源信息列表</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../css/main_style.css" rel="stylesheet" type="text/css" />
    <meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<script type="text/javascript" src="../js/jquery.min.js"></script>
	<script  type="text/javascript" language="javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="../js/js.js"></script>	
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<link href="../css/main_style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../themes/icon.css" />
	<link rel="Stylesheet" type="text/css" href="../css/demo.css" />
	<script type="text/javascript" src="../js/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../js/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript" src="../js/trunkformat.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
    <script type="text/javascript">
        
        function trunk_page_change(parameters) {
            $.post("TrunkInfoListHandler.ashx", parameters, function (data) {
                $('#pagination_manager').pagination({
                    total: data.item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + '&bitparams=' + data.params);
                    }
                });

            }, "json");
        }
        function initiate_load() {
            var parameters = {};
            var jsonStr = JSON.stringify(parameters);
            trunk_page_change(jsonStr);
            $("#tmpStore").val(deformatJSON(parameters));
        }
        function srcCounty() {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.srcCityId = $("#ddlCity").val();
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function dstCounty() {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.dstCityId = $("#ddlCountyDst").val();
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function vanTypeRestrict(typeId) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.vanTypeId = typeId;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function trunkTypeRestrict(typeId) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.trunkTypeId = typeId;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function lengthRestrict(len) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.length = len;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function weightRestrict(data) {
            var srcStr = $("#tmpStore").val();
            var jsonData = formatJSON(srcStr);
            jsonData.weight = data;
            var formatStr = deformatJSON(jsonData);
            $("#tmpStore").val(formatStr);
            trunk_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
    </script>
</head>
<body onload="initiate_load()">
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
  <!--当车源信息按钮被按下时显示该车源信息-->
  <table  id="carSelect" class="selectTb">
    <tbody>
    <tr><td class="firstTd">出发地：</td>
    <td class="secondTd">
         <asp:UpdatePanel ID="updatePanelLocatedPlace" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlProvince_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True"  
                        onselectedindexchanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlCounty" runat="server" AutoPostBack="true"  onchange="srcCounty()"
                        onselectedindexchanged="ddlCounty_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtSrcPlaceCode" runat="server" Visible="false" ReadOnly="true"></asp:TextBox>
                </ContentTemplate>
        </asp:UpdatePanel>
    </td>
    <td></td></tr>
    <tr><td class="firstTd">目的地：</td><td class="secondTd">
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
    </td><td></td></tr>
      <tr>
        <td class="firstTd"><span>车辆类型：</span></td>
        <td class="secondTd">
          <ul class="selectLi ulLorryType">
            <li><a href="#" onclick="vanTypeRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="vanTypeRestrict('1')" >货车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('2')" >自卸车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('3')" >冷藏车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('4')" >保温车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('5')" >油罐车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('6')" >中型罐车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('7')" >铁笼车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('8')" >进口气囊避震车</a></li>
            <li><a href="#" onclick="vanTypeRestrict('9')" >不锈钢大槽罐车</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>车体状况：</span></td>
        <td class="secondTd">
          <ul class="selectLi ulLorryStatus">
            <li><a href="#" onclick="trunkTypeRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('1')">厢式</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('2')">敞蓬</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('3')">单桥</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('4')">三桥</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('5')">四桥</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('6')">高栏</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('7')">中栏</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('8')">低栏</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('9')">平板</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('10')">半挂</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('11')">全挂</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('12')">加长挂</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('13')">后八轮</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('14')">前四后八</a></li>
            <li><a href="#" onclick="trunkTypeRestrict('15')" >仓栏</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
      <tr>
        <td class="firstTd"><span>车长：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulLorryLength">
            <li><a href="#" onclick="lengthRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="lengthRestrict('1')" >3米以下</a></li>
            <li><a href="#" onclick="lengthRestrict('2')" >3-6米</a></li>
            <li><a href="#" onclick="lengthRestrict('3')" >6-10米</a></li>
            <li><a href="#" onclick="lengthRestrict('4')" >10-13米</a></li>
            <li><a href="#" onclick="lengthRestrict('5')" >13-16米</a></li>
            <li><a href="#" onclick="lengthRestrict('6')" >16米以上</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
       <tr>
        <td class="firstTd"><span>载重：</span></td><!--该部分的信息无需从数据库获取-->
        <td class="secondTd">
          <ul class="selectLi ulLorryWeight">
            <li><a href="#" onclick="weightRestrict('0')" class="nolimit">不限</a></li>
            <li><a href="#" onclick="weightRestrict('1')" >5吨以下</a></li>
            <li><a href="#" onclick="weightRestrict('2')" >5-9吨</a></li>
            <li><a href="#" onclick="weightRestrict('3')" >10-19吨</a></li>
            <li><a href="#" onclick="weightRestrict('4')" >20-29吨</a></li>
            <li><a href="#" onclick="weightRestrict('5')" >30-39吨</a></li>
            <li><a href="#" onclick="weightRestrict('6')" >40吨以上</a></li>
          </ul>
        </td>
        <td></td>
      </tr>
    </tbody>
  </table>

  </div>
  <div class="infoListFrame">
      <div class="tableContainer TC2">
       <div id="trunks_content" class="easyui-panel" data-options="href:'TrunkInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=0-0-0-0-0-0'">  </div>
       <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>

    </div>
   </div>
   <input id="tmpStore" type="hidden" value="" />
    </form>
</body>
</html>
