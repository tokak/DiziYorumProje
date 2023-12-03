<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="istatistik.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.istatistik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        span{
            font-weight:700;
        }
    </style>

    <table class="table table-bordered">
        <tr>
            <td>
               Toplam BLog Sayısı <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
               Toplam Yorum Sayısı <asp:Label style="font-weight" ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
               Toplam Film Sayısı <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
               Toplam Belgesel Sayısı <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
               En Fazla Yorumlu Blog Sayısı <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
               Toplam Animasyon Sayısı <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>



</asp:Content>
