<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpeciallineInfoDetail.aspx.cs" Inherits="Trans.InfoShow.SpeciallineInfoDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>车源详细信息页面</title>
    <link  rel="stylesheet" type="text/css" href="../../css/style_thirdP.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="currentLoc">您当前浏览的是：<span class="spancurrentLoc">专线详细信息</span></div>
<table class="right-bottom">
 <tbody>
    <tr>
        <td class="right-leftSide">
            <table>
                <%--<tbody>
                  <tr class="infoTitle">
                      <td><p id="infoTitle" class="pInfoTitle">湖南省长沙市<-->山西省太原市</p><hr class="hr1" /></td>
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
                                              <td class="secTd"><span class="spanBeginAdr">湖南省常德市临澧县</span></td>
                                              </tr>
                                              <tr>
                                              <td class="firstTd">目的地：</td>
                                              <td class="secTd"><span class="spanEndAdr">浙江省金华市义乌市</span></td>
                                              </tr>
                                              <tr>
                                              <td class="firstTd">有效时间：</td>
                                              <td class="secTd"><span class="spanTimelimit">长期有效</span></td>
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
                    <td>
                      <table>
                          <caption></caption>
                          <tbody>
                              <tr>
                              <td class="firstTd">重货价格：</td>
                              <td class="secTd"><span class="spanHeavyPrice">1.3元/吨</span></td>
                              <td class="firstTd">泡货价格：</td>
                              <td class="secTd"><span class="spanPaoPrice">234元/公斤</span></td>
                              </tr>
                              <tr>
                              <td class="firstTd">运输方式：</td>
                              <td class="secTd"><span class="spanTransWay">公路运输</span></td>
                              <td class="firstTd">发车班次：</td>
                              <td class="secTd"><span class="spanTransTimes">1天1次</span></td>
                              </tr>
                              <tr>
                              <td class="firstTd">路途耗时：</td>
                              <td class="secTd"><span class="spanTransHover">5小时</span></td>
                              <td class="firstTd">运输货物类型：</td>
                              <td class="secTd"><span class="spanEndAdr">不限,普通货物,大件货物,搬家货物</span></td>
                              </tr>
                              <tr>
                              <td class="firstTd">始发地址：</td>
                              <td class="secTd"><span class="spanBeginPlace"> 湖南省常德市临澧县207国道旁</span></td>
                              <td class="firstTd">联系人：</td>
                              <td class="secTd"><span class="spanBeginPlaceCont"> 13875153835  周业平</span></td>
                              </tr>
                              <tr>
                              <td class="firstTd">目的地址：</td>
                              <td class="secTd"><span class="spanEndPlace">湖南省常德市临澧县207国道旁</span></td>
                              <td class="firstTd">联系人：</td>
                              <td class="secTd"><span class="spanEndPlaceCont"> 13875153835  周三国</span></td>
                              </tr>
                          </tbody>
                       </table>
                    </td>
                  </tr>
                </tbody>--%>

                <%=this.HtmlMessageBodyPage%>


            </table>
        </td>


        <td class="right-rightSide">
        	<div class="deliverInfoNum">已发布信息：<span class="spanLorryInfoNum">2222</span>条</div>
            <div></div>
        </td>
		</td>
    </tr>
 </tbody>
</table>





    </form>
</body>
</html>
