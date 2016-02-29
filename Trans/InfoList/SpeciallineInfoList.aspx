<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpeciallineInfoList.aspx.cs" Inherits="Trans.InfoList.SpeciallineInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>专线信息列表</title>
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
    <script type="text/javascript" src="../js/mapformat.js"></script>
	<script type="text/javascript" charset="gb2312" src="../js/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../js/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop(); 
        });
	</script>
    <script type="text/javascript">
        function srcCounty() {
            countyChange($("#ddlCity"));
        }
        function dstCounty() {
            countyChange($("#ddlCityDst"));
        }
        function countyChange(countyElement) {
            var srcStr = $("#tmpStore").val();
            var jsonData = deJsonFormatLine(srcStr);
            jsonData.cityId = $(countyElement).val();
            var formatStr = jsonFormatLine(jsonData);
            $("#tmpStore").val(formatStr);
            line_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#line_content').panel('refresh', 'LineInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams='+$("#tmpStore").val());
        }
        function lineRestrict(typeId) {
            var srcStr = $("#tmpStore").val();
            var jsonData = deJsonFormatLine(srcStr);
            jsonData.typeId = typeId == '0' ? '0' : typeId;
            var formatStr = jsonFormatLine(jsonData);
            $("#tmpStore").val(formatStr);
            line_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#line_content').panel('refresh', 'LineInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function deparutreRestrict(typeId) {
            var srcStr = $("#tmpStore").val();
            var jsonData = deJsonFormatLine(srcStr);
            jsonData.departureId = typeId == '0' ? '0' : typeId;
            var formatStr = jsonFormatLine(jsonData);
            $("#tmpStore").val(formatStr);
            line_page_change(JSON.stringify(jsonData));
            $("#pagination_manager").pagination('refresh');
            $('#line_content').panel('refresh', 'LineInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=' + $("#tmpStore").val());
        }
        function initiate_load() {
            var parameters = {};
            var jsonStr = JSON.stringify(parameters);
            line_page_change(jsonStr);
            $("#tmpStore").val(jsonFormatLine(parameters));
        }
        function line_page_change(parameters) {
            $.post("LineInfoListHandler.ashx", parameters, function (data) {
                $('#pagination_manager').pagination({
                    total: data.items_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {//parameters format: typeId-cityid-departureId-transporttypeid
                        var getUrl = 'LineInfoListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + '&bitparams=' + data.params;
                        $('#line_content').panel('refresh', getUrl);
                    }
                });

            }, "json");
        }
    </script>
</head>
<body onload="initiate_load()">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

      <div class="searchFrame">
          <div  id="infoStatistic"  class="totalInfo">
          在线车源：<span id="totalLorry" class="red spanTotalLorry"> <%=this.TotalLorry %> </span>
          实时货源：<span id="totalGoods" class="red spanTotalGoods"><%=this.TotalGoods %></span>
          </div>
      </div>

      <div class="searchSelectionFrame">
  <!--当专线信息按钮被按下时显示该专线信息-->
   <table  id="lineSelect" class="selectTb">
    <tbody>
    <tr>
      <td width="14%" class="firstTd">起始城市：</td>
      <td width="84%" class="secondTd">
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
      <td width="2%"></td>
    </tr>
    <tr>
      <td width="14%" class="firstTd">目的城市：</td>
      <td width="84%" class="secondTd">
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
      <td width="2%"></td>
    </tr>
     <tr>
      <td class="firstTd"><span>发车班次：</span></td><!--该部分的信息无需从数据库获-->
      <td class="secondTd">
        <ul class="selectLi ulRunTimes">
          <li><a href="#" onclick="deparutreRestrict('0')">不限</a></li>
          <li><a href="#" onclick="deparutreRestrict('1')">不固定</a></li>
          <li><a href="#" onclick="deparutreRestrict('2')">每隔一天</a></li>
          <li><a href="#" onclick="deparutreRestrict('3')">每隔两天</a></li>
          <li><a href="#" onclick="deparutreRestrict('4')">每隔三天</a></li>
          <li><a href="#" onclick="deparutreRestrict('5')">每隔四天</a></li>
          <li><a href="#" onclick="deparutreRestrict('6')">每隔五天</a></li>
        </ul>
      </td>
      <td></td>
     </tr>
    </tbody>
  </table>
  </div>
<div class="infoListFrame" id="lineInfo">
    <div class="tableContainer TCline">
    <!-------------------专线信息显示---------------------------->
        <div id="line_content" class="easyui-panel" data-options="href:'LineInfoListHandler.ashx?pageNumber=1&pageSize=10&bitparams=0-0-0-0'">
        </div>
        <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>
   </div>
 </div>

    </form>
    <input id="tmpStore" type="hidden" value="" />
</body>
</html>
