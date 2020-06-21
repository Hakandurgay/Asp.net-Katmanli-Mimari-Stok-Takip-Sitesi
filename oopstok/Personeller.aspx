<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="oopstok.Personeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
      
    <table class="table table-bordered">
        <tr>
            <th>Personel ID</th>
            <th>Personel ADI</th>
            <th>Personel SOYADI</th>
            <th>Personel Departmanı</th>
            <th>Personel Maaşı</th>
        </tr>
            
        <tbody>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("PERSONELID")%> </td>
                    <td><%#Eval("PERSONELAD")%> </td>
                    <td><%#Eval("PERSONELSOYAD")%> </td>
                    <td><%#Eval("PERSONELDEPARTMANAD")%> </td> <%--buradaki yazılanlar entiy personelde yazılan prop--%>
                    <td><%#Eval("PERSONELMAAS")%> </td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>

        </tbody>
    </table>
</asp:Content>
