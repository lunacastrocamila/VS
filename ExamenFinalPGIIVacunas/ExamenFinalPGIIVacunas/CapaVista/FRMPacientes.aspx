<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMPacientes.aspx.cs" Inherits="ExamenFinalPGIIVacunas.CapaVista.FRMPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestión de Pacientes</h2>
    <asp:GridView ID="gvPacientes" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="id_paciente" HeaderText="ID" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="dni" HeaderText="DNI" />
            <asp:BoundField DataField="fecha_nacimiento" HeaderText="Nacimiento" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label Text="Nombre:" runat="server" />
    <asp:TextBox ID="txtNombre" runat="server" /><br />
    <asp:Label Text="DNI:" runat="server" />
    <asp:TextBox ID="txtDNI" runat="server" /><br />
    <asp:Label Text="Fecha de Nacimiento:" runat="server" />
    <asp:Calendar ID="calNacimiento" runat="server" /><br />
    <asp:Button Text="Agregar" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" />
    <asp:Button Text="Modificar" ID="btnModificar" runat="server" OnClick="btnModificar_Click" />
    <asp:Button Text="Eliminar" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" />
</asp:Content>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
