<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <div style="font-size:x-large" align="center">
        <br />
        Kullanıcı Bilgileri Yönetim Formu<br />
        <br />
        <table class="nav-justified">
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">KullanıcıID</td>
                <td style="width: 195px">
                    <asp:TextBox ID="TextBoxID" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button5_Click" Text="GET" />
                </td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">AdSoyad</td>
                <td style="width: 195px">
                    <asp:TextBox ID="TextBoxAdSoyad" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">Eposta</td>
                <td style="width: 195px">
                    <asp:TextBox ID="TextBoxEposta" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 34px; width: 919px"></td>
                <td style="height: 34px; width: 420px">Şifre</td>
                <td style="width: 195px; height: 34px">
                    <asp:TextBox ID="TextBoxŞifre" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">Rol</td>
                <td style="width: 195px">
                    <asp:TextBox ID="TextBoxRol" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 34px; width: 919px"></td>
                <td style="height: 34px; width: 420px">OluşturulmaTarihi</td>
                <td style="width: 195px; height: 34px">
                    <asp:TextBox ID="TextBoxTarih" runat="server" Font-Size="Medium" Width="202px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">&nbsp;</td>
                <td style="width: 195px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 919px; height: 34px;"></td>
                <td style="width: 420px; height: 34px;"></td>
                <td style="width: 195px; height: 34px;">
                    <asp:Button ID="Button1" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Ekle" Width="79px" />
&nbsp;<asp:Button ID="Button2" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" Text="Güncelle" />
                    <asp:Button ID="Button3" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" Text="Sil" Width="84px" />
                &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" Text="Ara" Width="97px" />
                &nbsp;<asp:Button ID="Button6" runat="server" BackColor="#9933FF" BorderColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button6_Click" Text="Temizle" />
                </td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">&nbsp;</td>
                <td style="width: 195px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 919px">&nbsp;</td>
                <td style="width: 420px">&nbsp;</td>
                <td style="width: 195px">
                    <asp:GridView ID="GridView1" runat="server" Width="537px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    <br />
</div>
</asp:Content>
