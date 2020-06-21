<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriGuncellemeSayfasi.aspx.cs" Inherits="oopstok.MusteriGuncellemeSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group"> <%--çalışması için runat server yazılmalı--%>
        <div>
        
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Müşteri id"></asp:TextBox>
       
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Musteri Adı: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Müşteri adını giriniz..."></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Musteri Soyadı: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Müşteri soyadını giriniz..."></asp:TextBox>
            
        </div>
        <div>
            <asp:Button ID="kaydet" runat="server" Text="Müşteri Bilgilerini Güncelle" CssClass="btn btn-primary" OnClick="kaydet_Click"/>
        </div>

    </form>
</asp:Content>
