<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsInfoDetail.aspx.cs" Inherits="Trans.InfoShow.GoodsInfoDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>详细信息页面</title>
    <link  rel="stylesheet" type="text/css" href="../../css/style_thirdP.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="currentLoc">您当前浏览的是：<span class="spancurrentLoc">货源详细信息</span></div><!--可选，根据之前点击的对象由程序生成当前的位置信息--->
<table class="right-bottom">
<tbody>
    <tr>
        <td class="right-leftSide">
            <table>
                <tbody>
                <tr class="infoTitle">
                    <td><p id="infoTitle" class="pInfoTitle">湖南省长沙市→山西省太原市,有13吨设备,求17.5米前四后八1辆</p><hr class="hr1" /></td>
                </tr>
                <tr>
                  <td class="infoDetail">
                    <table>
                        <tbody>
                            <tr>
                                <td class="infoPic">
                                <div id="infoPic"><img src="../../imgs/companys/4.jpg" class="imgInfoPic" /></div></td>
                                <td class="infoContacts">
                                	<table>
                                    	<tbody>
                                        	<tr>
                                            <td class="firstTd">发布时间：</td>
                                            <td class="secTd"><span class="spanInfotime">10小时前</span></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">联系人：</td>
                                            <td class="secTd"><span class="spanContactor">张先生</span></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">联系电话：</td>
                                            <td class="secTd"><span class="spanContacts">12345678901</span></td>
                                            </tr>
                                            <tr>
                                            <td><hr /></td>
                                            <td><hr /></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">启运地：</td>
                                            <td class="secTd"><span class="spanBeginAdr">成都</span></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">目的地：</td>
                                            <td class="secTd"><span class="spanEndAdr">湖北武汉</span></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">类型：</td>
                                            <td class="secTd"><span class="spanType">设备</span></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">何时需要：</td>
                                            <td class="secTd"><span class="spanTimeToUse">随时</span></td>
                                            </tr>
                                            <tr>
                                            <td><hr /></td>
                                            <td><hr /></td>
                                            </tr>
                                            <tr>
                                            <td class="firstTd">特殊说明 ：</td>
                                            <td class="secTd"><span class="spanPrice">价格面议</span></td>
                                            </tr>
                                        </tbody>
                                     </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                  </td>
                </tr>
                <tr>
                <td></td>
                </tr>
                </tbody>
            </table>
        </td>
        <td class="right-rightSide">
        	<div class="deliverInfoNum">已发布信息：<span class="spanLorryInfoNum">2222</span>条</div>
            <div></div>
        </td>
    </tr>
</tbody>
</table>

    </form>
</body>
</html>
