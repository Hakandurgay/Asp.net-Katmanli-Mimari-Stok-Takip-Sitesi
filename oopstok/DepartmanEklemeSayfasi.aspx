<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanEklemeSayfasi.aspx.cs" Inherits="oopstok.DepartmanEklemeSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
    <form runat="server" class="form-group"> <%--çalışması için runat server yazılmalı--%>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Departman Adı: " Font-Bold="True"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Departman adını giriniz..."></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="kaydet" runat="server" Text="Departmanı Kaydet" CssClass="btn btn-primary" OnClick="kaydet_Click"/>
        </div>

    </form>
    
    

</asp:Content>
