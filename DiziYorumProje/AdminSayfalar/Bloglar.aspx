<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Bloglar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>BAŞLIk</th>
                <th>TARİH</th>
                <th>TÜR</th>
                <th>KATEGORİ</th>
                <th>SİL</th>
                <th>GÜNCELLE</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("BLOGID") %></td>
                        <td><%# Eval("BLOGBASLIK") %></td>
                        <td><%# Eval("BLOGTARIH", "{0:dd.MM.yyyy}") %></td>
                        <td><%# Eval("BLOGTUR") %></td>
                        <td><%# Eval("BLOGKATEGORI") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "BlogSil.aspx?BLOGID=" + Eval("BLOGID") %>' CssClass="btn btn-danger">SİL</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BlogGuncelle.aspx?BLOGID=" + Eval("BLOGID") %>' CssClass="btn btn-warning">GüNCELLE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="YeniBlog.aspx" class="btn btn-primary">Yeni Blog Ekle</a>
</asp:Content>
