<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="oopstok.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
    
    <table class="table table-bordered">
        <tr>
            <th>Ürün ID</th>
            <th>Ürün ADI</th>
            <th>Ürün  Fiyatı</th>
            <th>Ürün Adedi</th>
        </tr>
            
        <tbody>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID")%> </td>
                    <td><%#Eval("URUNAD")%> </td>
                    <td><%#Eval("URUNFIYAT")%> </td>
                    <td><%#Eval("URUNADET")%> </td>


                </tr>
            </ItemTemplate>
        </asp:Repeater>

        </tbody>
    </table>
    <a href="UrunEklemeSayfasi.aspx" class="btn btn-info">Yeni Ürün Ekle</a>

</asp:Content>
