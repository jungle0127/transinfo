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
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
    <script type="text/javascript">
        function trunk_page_change() {
            $.post("TrunkInfoListHandler.ashx", "1", function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#trunks_content').panel('refresh', 'TrunkInfoListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize);
                    }
                });

            }, "text");
        }
        
    </script>




</head>


<body onload="trunk_page_change()">
    <form id="form1" runat="server">
      <div class="searchFrame">
      <div class="totalInfo">
      在线车源：<span id="totalLorry" class="red spanTotalLorry">333333</span>
      实时货源：<span id="totalGoods" class="red spanTotalGoods">888888</span>
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
       <div id="trunks_content" class="easyui-panel"> <%=this.TrunksFirstPageHtml%> </div>
       <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>

    </div>
   </div>

    </form>
</body>
</html>
