<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="depositorysourcestatistic.aspx.cs" Inherits="Trans.admin.statistic.depositorysourcestatistic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../js/jquery.min.js" type="text/javascript"></script>
    <script src="../../js/Chart.js" type="text/javascript"></script>
    <script type="text/javascript">
        function init() {
            // Get context with jQuery - using jQuery's .get() method.
            var ctx = $("#myChart").get(0).getContext("2d");
            // This will get the first returned node in the jQuery collection.
            var myNewChart = new Chart(ctx);

        }
    </script>
</head>
<body onload="init()">
    <form id="form1" runat="server">
    <div>
        <p>线型</p>
        <canvas id="myChart" width="400" height="400"></canvas>
        <br />
        <hr />
    </div>
    </form>
</body>
</html>
