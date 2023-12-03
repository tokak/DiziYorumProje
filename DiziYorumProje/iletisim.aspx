<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="DiziYorumProje.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--
Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
    <!DOCTYPE HTML>
    <html>
    <body>

        <div class="contact-content">
            <div class="container">
                <div class="contact-info">
                    <h2>İletişim</h2>

                </div>
                <div class="contact-details">
                    <form runat="server" style="flex: auto">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" Style="margin: auto" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required="" TextMode="MultiLine" Height="100px"></asp:TextBox>

                        <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
                    </form>
                </div>
                <div class="contact-details">
                    <div class="col-md-8 contact-map">
                        <h4>Burdayız</h4>
                        <div style="overflow: hidden; resize: none; max-width: 100%; width: 100%; height: 500px;">
                            <div id="embedded-map-display"
                                style="height: 100%; width: 100%; max-width: 100%;">
                                <iframe style="height: 100%; width: 100%; border: 0;" frameborder="0"
                                    src="https://www.google.com/maps/embed/v1/place?q=Hürrempalangası,+Erzincan+Binali+Yıldırım+Üniversitesi+Yalnızbağ+Yerleşkesi,+Yalnızbağ+yerleşkesi,+Sivas+Erzincan+Yolu,+Yalnızbağ/Erzincan+Merkez/Erzincan,+Türkiye&key=AIzaSyBFw0Qbyq9zTFTd-tUY6dZWTgaQzuU17R8"></iframe>
                            </div>
                            <a class="google-map-code-enabler" rel="nofollow" href="https://www.bootstrapskins.com/themes" id="make-map-data"></a><style>
                                                                                                                                                                              #embedded-map-display img.text-marker {
                                                                                                                                                                                  max-width: none !important;
                                                                                                                                                                                  background: none !important;
                                                                                                                                                                              }

                                                                                                                                                                              img {
                                                                                                                                                                                  max-width: none
                                                                                                                                                                              }
                                                                                                                                                                          </style>
                        </div>

                    </div>
                    <div class="col-md-4 company_address">
                        <h4>Adress</h4>
                        <p>Erzincan Üniversitesi Mühendislik Fakültesi</p>
                       
                    </div>
                    <div class="clearfix"></div>
                </div>


            </div>
        </div>
</asp:Content>
