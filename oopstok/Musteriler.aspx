<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="oopstok.Musteriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
    
    <table class="table table-bordered">
        <tr>
            <th>MÜŞTERİ ID</th>
            <th>MÜŞTERİ ADI</th>
            <th>MÜŞTERİ SOYADI</th>
            <th>Sil</th>
            <th>Güncelle</th>

        </tr>
            
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                <tr>
                    <td><%#Eval("MUSTERIID")%> </td>
                    <td><%#Eval("MUSTERIAD") %></td>
                    <td><%#Eval("MUSTERISOYAD") %></td>
                   <td> <asp:HyperLink NavigateUrl='<%#"~/MusteriSilmeSayfasi.aspx?MUSTERIID="+Eval("MUSTERIID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">sil</asp:HyperLink></td>
                    <td><asp:HyperLink  NavigateUrl='<%#"~/MusteriGuncellemeSayfasi.aspx?MUSTERIID="+Eval("MUSTERIID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">güncelle</asp:HyperLink></td>

                </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </tbody>
                    </table>
    
    <a href="MusteriEklemeSayfasi.aspx" class="btn btn-info">Yeni Müşteri Ekle</a>

</asp:Content>
