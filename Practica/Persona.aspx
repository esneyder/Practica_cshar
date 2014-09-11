<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="Practica.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <table class="nav-justified">
        <tr>
            <td style="width: 170px">Cedula *</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Nombre *</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="208px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Apellido *</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Fecha Nacimiento *</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" Width="204px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Edad *</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Ciudad *</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="189px"></asp:TextBox>
            </td>
        </tr>
    </table>


</asp:Content>
