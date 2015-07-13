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
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
	<script  type="text/javascript" language="javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="../js/js.js"></script>	
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<link href="../css/main_style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../themes/icon.css" />
	<link rel="Stylesheet" type="text/css" href="../css/demo.css" />
    
	<script type="text/javascript" src="../js/jquery.min.js"></script>
	<script type="text/javascript" src="../js/jquery.easyui.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            backToTop();
        });
	</script>
    <script type="text/javascript">
        function depot_page_change() {
            $.post("DepotListHandler.ashx", "1", function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: 'Page',
                    afterPageText: 'of {pages}',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize) {
                        $('#depot_content').panel('refresh', 'DepotListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize);
                    }
                });

            }, "text");
        }
        
    </script>



</head>
<body onload="depot_page_change()" >
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
       
       <div id="depot_content" class="easyui-panel"> <%=this.DepotFirstPageHtml%> </div>
       <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>






    </div>
    
  </div>

    </form>
</body>
</html>
