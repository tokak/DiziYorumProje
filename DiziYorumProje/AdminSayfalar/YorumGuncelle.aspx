<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <form runat="server" class="form-group">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı" Enabled="false" ></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="İçerik"></asp:TextBox>            
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="BLOGBASLIK" DataValueField="BLOGID"></asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary<asp:DropDownList runat=" server="" Text="Kaydet"  OnClick="Button1_Click" />
        </form>
    </div>
</asp:Content>
