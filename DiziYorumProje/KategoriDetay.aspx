<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="single">
            <div class="container">
                <div class="col-md-8 single-main">
                    <div class="single-grid">
                        <h2>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                        </h2>

                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <img src="FilmResimler/<%# Eval("BLOGGORSER") %>.jpg" style="height: 350px; width: 750px; margin-bottom: 20px;" alt="" />
                                <h3><%# Eval("BLOGBASLIK") %></h3>
                                <p><%# Eval("BLOGICERIK") %></p>
                                <br />
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>



                </div>

                
            </div>
        </div>












</asp:Content>
