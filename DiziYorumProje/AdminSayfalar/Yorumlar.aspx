<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Yorulmar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>#</th>
                    <th>KULLANICI</th>
                    <th>MAIL</th>
                    <th>İÇERİK</th>
                    <th>BLOG</th>
                    <th>SİL</th>
                    <th>GÜNCELLE</th>

                </tr>

            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("YORUMID") %></td>
                            <td><%# Eval("KULLANICIAD") %></td>
                            <td><%# Eval("MAIL") %></td>
                            <td><%# Eval("YORUMICERIK") %></td>
                            <td><%# Eval("BLOGBASLIK") %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YorumSil.aspx?YORUMID=" + Eval("YORUMID") %>' CssClass="btn btn-danger">SİL</asp:HyperLink>

                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# "YorumGuncelle.aspx?YORUMID=" + Eval("YORUMID") %>' CssClass="btn btn-warning">GÜ    NCELLE</asp:HyperLink>
                            </td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>


</asp:Content>
