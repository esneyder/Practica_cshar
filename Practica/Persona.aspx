<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="Practica.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />

    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
    <table class="nav-justified">
        <tr>
            <td style="width: 170px">Cedula *</td>
            <td>
                <asp:TextBox ID="txtcedula" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Nombre *</td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server" Width="208px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Apellido *</td>
            <td>
                <asp:TextBox ID="txtapellido" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Fecha Nacimiento *</td>
            <td>
                <asp:TextBox ID="txtfechanacimiento" runat="server" TextMode="Date" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Edad *</td>
            <td>
                <asp:TextBox ID="txtedad" runat="server" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">Ciudad *</td>
            <td>
                <asp:TextBox ID="txtciudad" runat="server" Width="204px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
    <asp:Button ID="Button3" runat="server" Text="Consultar" />
    <asp:Button ID="Button2" runat="server" Text="Actualizar" />
    <asp:Button ID="Button4" runat="server" Text="Eliminar" />

    <br />
    <asp:GridView ID="dgPersona" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
</asp:Content>
