<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepositoryList.aspx.cs" Inherits="Trans.admin.InformationManager.DepositoryList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>仓储信息管理</title>
    <link rel="stylesheet" type="text/css" href="../../themes/default/easyui.css" />
	<link rel="stylesheet" type="text/css" href="../../themes/icon.css" />
	<link rel="stylesheet" type="text/css" href="../../css/demo.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/style.css" />
	<script type="text/javascript" src="../../js/jquery.min.js"></script>
	<script type="text/javascript" src="../../js/jquery.easyui.min.js"></script>
    <script type="text/javascript">
        function get_user_id() {
            return <%=UserId %>;
        }
        function test(){
            var user_id = get_user_id();
            $.post("DepositoryHandler.ashx",String(user_id),function(msg){alert(msg);},"text");
        }
    </script>
</head>
<body style="background:#f0f9fd;" onclick="test()">
    <form id="form1" runat="server">
    <div id="content" class="easyui-panel" style="height:400px" data-options="href:'DepositoryHandler.ashx?pageNumber=1&pageSize=10&userid=1'"> </div>
    <div id="pagination_manager" class="easyui-pagination" style="border:1px solid #ccc;" >
        
    </div>
    </form>
</body>
</html>
