<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="oopstok.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <table class="table table-hover">
        
        <tr><th>Departman Id</th>
            <th>Departman Adı</th>
        </tr>
        <tbody>
        
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("DepertmanId")%></td>
                        <td><%#Eval("DepartmanAd")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
      
        </tbody>

    </table>
    <a href="DepartmanEklemeSayfasi.aspx" class="btn btn-info">Yeni Departman Ekle</a>
</asp:Content>
