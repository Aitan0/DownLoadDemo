<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebForm.aspx.cs" Inherits="firstWebApp.MainWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 129px;
            height: 103px;
        }
        .auto-style2 {
            width: 129px;
            height: 35px;
        }
        .auto-style3 {
            height: 35px;
        }
        .auto-style4 {
            width: 129px;
            height: 37px;
        }
        .auto-style5 {
            height: 37px;
        }
        .auto-style6 {
            height: 103px;
        }
        .auto-style7 {
            width: 129px;
            height: 38px;
        }
        .auto-style8 {
            height: 38px;
        }
        .auto-style9 {
            height: 368px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style9">
    
        请输入数字：<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        输出奇数/偶数<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="44px" Width="148px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="中国梦" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="内涵" />
        <table style="padding: inherit; margin: inherit; border: medium groove #00FFFF; width: 44%; height: 135px; list-style-type: disc;">
            <tr>
                <td class="auto-style4">文艺类：</td>
                <td class="auto-style5">
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="音乐" />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="表演" />
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="交谊舞" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">运动类：</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="篮球" />
                    <asp:CheckBox ID="CheckBox6" runat="server" Text="足球" />
                    <asp:CheckBox ID="CheckBox7" runat="server" Text="乒乓球" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">其它类：</td>
                <td class="auto-style8">
                    <asp:CheckBox ID="CheckBox8" runat="server" Text="摄影" />
                    <asp:CheckBox ID="CheckBox9" runat="server" Text="养花" />
                    <asp:CheckBox ID="CheckBox10" runat="server" Text="旅游" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="全选" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="显示" />
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox4" runat="server" Height="55px" TextMode="MultiLine" Width="369px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        从编写程序中找到乐趣，加油！<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="登陆界面" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Requ界面" />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
