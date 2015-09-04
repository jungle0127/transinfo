<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpeciallineInfoList.aspx.cs" Inherits="Trans.InfoList.SpeciallineInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>专线信息列表</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../css/main_style.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="../../js/bootstrap.min.js"></script>
    <meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
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
        function line_page_change(typeName) {
            $.post("LineInfoListHandler.ashx", "1", function (item_count) {
                $('#pagination_manager').pagination({
                    total: item_count,
                    pageSize: 10,
                    layout: ['list', 'sep', 'first', 'prev', 'sep', 'manual', 'sep', 'next', 'last', 'sep', 'refresh'],
                    beforePageText: '第',
                    afterPageText: '页，共 {pages}页',
                    pageList: [10, 20, 50, 100],
                    onSelectPage: function (pageNumber, pageSize, typeName) {
                        $('#line_content').panel('refresh', 'LineInfoListHandler.ashx?pageNumber=' + pageNumber + '&pageSize=' + pageSize + '&typeName=' + typeName);
                    }
                });

            }, "text");
        }
        
    </script>




</head>
<body onload="line_page_change('1')">
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
  <!--当专线信息按钮被按下时显示该专线信息-->
   <table  id="lineSelect" class="selectTb">
    <tbody>
    <tr>
      <td width="14%" class="firstTd">所在城市：</td>
      <td width="84%" class="secondTd">
          <ul class="selectLi">
          <%--<input type="text" class="inputLinePlace">--%>
          <asp:TextBox  class="inputLinePlace"  runat="server"></asp:TextBox>
          
          </ul>
      </td>
      <td width="2%"></td>
    </tr>
     <tr>
      <td class="firstTd"><span>发车班次：</span></td><!--该部分的信息无需从数据库获-->
      <td class="secondTd">
        <ul class="selectLi ulRunTimes">
          <li><a href="#">不限</a></li>
          <li><a href="#">不固定</a></li>
          <li><a href="#">每隔一天</a></li>
          <li><a href="#">每隔两天</a></li>
          <li><a href="#">每隔三天</a></li>
          <li><a href="#">每隔四天</a></li>
          <li><a href="#">每隔五天</a></li>
        </ul>
      </td>
      <td></td>
     </tr>
     <tr>
       <td class="firstTd"><span>运输时长：</span></td><!--该部分的信息无需从数据库获-->
       <td class="secondTd">
         <ul class="selectLi">
           <li><a href="#">不限</a></li>
           <li><a href="#">1天</a></li>
           <li><a href="#">2天</a></li>
           <li><a href="#">3天</a></li>
           <li><a href="#">4天</a></li>
           <li><a href="#">5天</a></li>
           <li><a href="#">5天以上</a></li>
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
 
    <div id="line_content" class="easyui-panel"> <%=this.TotalPageHtml%> </div>
       <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" ></div>


   </div>
  </div>

    </form>
</body>
</html>
