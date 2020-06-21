<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEklemeSayfasi.aspx.cs" Inherits="oopstok.UrunEklemeSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group"> <%--çalışması için runat server yazılmalı--%>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Urun Adı: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="urun adını giriniz..."></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="ürüm  adet: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="urun adet girniz..."></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="ürüm  fiyat: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="urun fiyat girniz..."></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="kaydet" runat="server" Text="Ürün Bilgilerini Kaydet" CssClass="btn btn-primary" OnClick="kaydet_Click"/>
        </div>

    </form>
</asp:Content>
