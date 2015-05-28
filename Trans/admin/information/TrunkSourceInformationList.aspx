<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrunkSourceInformationList.aspx.cs" Inherits="Trans.admin.information.TrunkSourceInformationList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="tablelist">
        <thead>
    	<tr>
        <th>编号<i class="sort"><img src="../../images/px.gif" /></i></th>
        <th>标题</th>
        <th>用户</th>
        <th>籍贯</th>
        <th>操作</th>
        </tr>
        </thead>

        <tbody>
        <tr>
        <td>20130908</td>
        <td>王金平幕僚：马英九声明字字见血 人活着没意思</td>
        <td>admin</td>
        <td>江苏南京</td>
        <td><a href="#" class="tablelink">查看</a>     <a href="#" class="tablelink"> 删除</a></td>
        </tr> 
        
        <tr>
        <td>20130907</td>
        <td>温州19名小学生中毒流鼻血续：周边部分企业关停</td>
        <td>uimaker</td>
        <td>山东济南</td>
        <td><a href="#" class="tablelink">查看</a>     <a href="#" class="tablelink">删除</a></td>
        </tr>
        </tbody>
        </table>
    </div>
    </form>
</body>
</html>
