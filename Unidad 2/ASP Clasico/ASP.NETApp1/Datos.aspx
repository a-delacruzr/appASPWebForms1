<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="ASP.NETApp1.Datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblNumeroControl" runat="server" Text="Número de control: "></asp:Label>
    <asp:TextBox ID="txtNumeroControl" runat="server"></asp:TextBox>
    Nombre:
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Carrera"></asp:Label>
    <asp:DropDownList ID="ddlCarrera" runat="server">
        <asp:ListItem>Sistemas</asp:ListItem>
        <asp:ListItem>Industrial</asp:ListItem>
        <asp:ListItem>Electrónica</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btnAgregar" CssClass="btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />

    <asp:Label ID="lblMostrarNoControl" runat="server"></asp:Label>

    <asp:GridView ID="gvAlumnos" runat="server">
    </asp:GridView>

</asp:Content>
