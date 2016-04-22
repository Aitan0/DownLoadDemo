<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Request.aspx.cs" Inherits="firstWebApp.Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 89%;
            height: 224px;
        }
        .auto-style2 {
            width: 374px;
            text-align: left;
        }
        .新建样式1 {
            visibility: collapse;
            display: inline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table aria-orientation="horizontal" aria-pressed="undefined" class="auto-style1" style="border: medium groove #00FF00">
            <tr>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" Text="浏览器版本" />
                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton2_CheckedChanged" Text="计算机平台类型" />
                    <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton3_CheckedChanged" Text="主机名" />
                    <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton4_CheckedChanged" Text="主机IP地址" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="95px" TextMode="MultiLine" Width="322px"></asp:TextBox>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                            </asp:Timer>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
