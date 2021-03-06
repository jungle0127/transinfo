﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usermanagement.aspx.cs" Inherits="Trans.admin.rightmanager.usermanagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" language= "javascript ">
            function QueryDelete() {
                if (!confirm("确认要删除吗？")) {
                    document.getElementById("rtVal").value = "false";
                }
                else {
                    document.getElementById("rtVal").value = "true";

                }
            }
        </script> 
</head>
<body>
    <form id="form1" runat="server">
        <table>
        <tr>
            <td style="width:50">&nbsp;</td>
            <td>
        <asp:GridView ID="gvUser" AutoGenerateColumns="false" runat="server" 
            CellPadding="4" ForeColor="#333333" 
            GridLines="None" onrowcommand="gvUser_RowCommand" Width="523px" Height="125px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <Columns>
                    <asp:BoundField DataField="UserId" SortExpression="UserId" ReadOnly="true" Visible="false" />
                    <asp:BoundField DataField="Roleid" SortExpression="Roleid" ReadOnly="true" Visible="false" />
                    <asp:BoundField DataField="Loginname" ReadOnly="true" HeaderText="登录名称" />
                    <asp:BoundField DataField="Username" ReadOnly="true" HeaderText="用户名称" />
                    <asp:BoundField DataField="Rolename" ReadOnly="true" HeaderText="角色名称" />
                    <asp:TemplateField HeaderText="操作" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="25%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkbtnUpdate" runat="server" Text="更新" CommandName="editUpdate" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"UserId").ToString() %>'></asp:LinkButton>
                            -
                            <asp:LinkButton ID="lnkbtnDelete" runat="server" OnClientClick="QueryDelete()" Text="删除" CommandName="delUser" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"UserId").ToString() %>'></asp:LinkButton>                        
                            <input type="hidden" id="rtVal" name="rtVal" />
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </asp:TemplateField>
            </Columns>


        </asp:GridView>
        </td>
        </tr>
        </table>

    <div class="formbody">
    
        <ul class="forminfo">
            <li>
               <label>&nbsp;</label><asp:Button runat="server" ID="btnSubmit" name="" 
            class="btn" Text="添加角色" onclick="btnSubmit_Click" ></asp:Button>
            </li>
        </ul>
    </div>
    </form>
</body>
</html>
