<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpeciallineInfoList.aspx.cs" Inherits="Trans.InfoList.SpeciallineInfoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>专线信息列表</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="../../css/main_style.css" rel="stylesheet" type="text/css">
    <script src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="../../js/bootstrap.min.js"></script>
</head>
<body>
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
 <div class='container-fluid' id="showLineInfo">
  <div class='tabL'>
    <ul class="nav nav-tabs" id="myTab">
        <li class="active"><a href="#all" data-toggle='tab' class="allLineLink" id="allLineLink">全部</a></li>
        <li><a href="#one-way" data-toggle='tab' class="singleLineLink" id="singleLineLink">单程</a></li>
        <li><a href="#round-way" data-toggle='tab' class="roundWayLineLink" id="roundWayLineLink">往返</a></li>
    </ul>
   <div class="tab-content">
      <div class="tab-pane active all" id="all" class="allLineDiv"><!----所有---->
            <%--<div id="line_infos" class="line_infos"><!--动态加载--->
                <p class="NEWSline_text">常德市 <span id="line_kuai"><img class="imgSingleLine" src="../../imgs/signle.jpg" /></span>广州市</p>
                <p class="title"><a href="http://search.jt56.org/hnftwl.jt56.org" target="_blank">湖南福泰物流有限公司</a></p>
                <div class="align_left">
                    <p class="title">发车班次：<span id="Dark">不固定</span></p>
                    <p class="title">运输时长：<span id="Dark">1天</span></p>
                    <p class="title">重货：<span id="huo_color">1.05</span>元/公斤</p>
                </div>
                <div class="align_left">
                    <p class="title">是否直达：<span id="Dark">直达</span></p>
                    <p class="title">运输方式：<span id="Dark">公路运输</span></p>
                    <p class="title">泡货：<span id="huo_color">221</span>元/方</p>
                </div>
                <div class="clear"></div>
                <div class="NEWS_button"><a href="../InfoShow/SpeciallineInfoDetail.aspx" target="_blank">查看详情</a></div>
            </div>--%>
            <%=this.MessageStringhtml%>>

        </div>
            <div class="tab-pane" id="one-way" class="singleLineDiv"><!------单程------>

              <%--<div id="line_infos" class="line_infos"><!--动态加载--->
                    <p class="NEWSline_text">常德市 <span id="line_kuai">→</span>广州市</p>
                    <p class="title"><a href="http://search.jt56.org/hnftwl.jt56.org" target="_blank">湖南福泰物流有限公司</a></p>
                    <div class="align_left">
                        <p class="title">发车班次：<span id="Dark">不固定</span></p>
                        <p class="title">运输时长：<span id="Dark">1天</span></p>
                        <p class="title">重货：<span id="huo_color">1.05</span>元/公斤</p>
                    </div>
                    <div class="align_left">
                        <p class="title">是否直达：<span id="Dark">直达</span></p>
                        <p class="title">运输方式：<span id="Dark">公路运输</span></p>
                        <p class="title">泡货：<span id="huo_color">221</span>元/方</p>
                    </div>
                    <div class="clear"></div>
                    <div class="NEWS_button"><a href="#" target="_blank">查看详情</a></div>
                </div>--%>
                <%=this.MessageStringSinglehtml%>


            </div>
            <div class="tab-pane" id="round-way" class="roundWayLineDiv"><!------双程----->

              <%--<div id="line_infos" class="line_infos"><!--动态加载--->
                    <p class="NEWSline_text">常德市 <span id="line_kuai"><img class="imgRoundWayLine" src="../../imgs/round-way.jpg" /></span>广州市</p>
                    <p class="title"><a href="http://search.jt56.org/hnftwl.jt56.org" target="_blank">湖南福泰物流有限公司</a></p>
                    <div class="align_left">
                        <p class="title">发车班次：<span id="Dark">不固定</span></p>
                        <p class="title">运输时长：<span id="Dark">1天</span></p>
                        <p class="title">重货：<span id="huo_color">1.05</span>元/公斤</p>
                    </div>
                    <div class="align_left">
                        <p class="title">是否直达：<span id="Dark">直达</span></p>
                        <p class="title">运输方式：<span id="Dark">公路运输</span></p>
                        <p class="title">泡货：<span id="huo_color">221</span>元/方</p>
                    </div>
                    <div class="clear"></div>
                    <div class="NEWS_button"><a href="#" target="_blank">查看详情</a></div>
                </div>--%>
                <%=this.MessageStringGBHtml%>

            </div>
      </div>
    </div>
   </div>
  </div>
  <div class="fenye"><!-----分页-------->
    <div id="page">
        <a class="now_page">1</a>
        <a href="# p=2">2</a>
        <a href="# p=3">3</a>
        <a href="#?p=4">4</a>
        <a href="#?p=5">5</a>
        <span>...</span>
        <a href="#?p=14">14</a>
        <a href="#?p=2">&gt;</a>
    </div>
 </div>
  </div>

    </form>
</body>
</html>
