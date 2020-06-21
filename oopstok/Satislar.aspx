<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="oopstok.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
     
    <table class="table table-bordered">
        <tr>
            <th>Satış ID</th>
            <th>Ürün ADI</th>
            <th>Personel ADI</th>
            <th>Müşteri ADI</th>


        </tr>
            
        <tbody>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SATISID")%> </td>
                    <td><%#Eval("URUNAD")%> </td>
                    <td><%#Eval("PERSONELAD")%> </td>  <%-- BURADA TAGİ YAZMAYIP DİREKT PERSONEL AD YAZMASININ SEBEBİ, PERSONEL ADIN PERSONEL TAGINA BAĞLI OLMASI VE O TAGDAKİ DİĞER ŞEYLERİ DE OTOMATİK OLARAK GETİRMESİ--%>
                    <td><%#Eval("MUSTERIAD")%> </td>
             
                </tr>
            </ItemTemplate>
        </asp:Repeater>

        </tbody>
    </table>
</asp:Content>
