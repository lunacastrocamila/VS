<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMVacunas.aspx.cs" Inherits="ExamenFinalPGIIVacunas.CapaVista.Inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Vacunas</title>
    <link href="~/Styles/menu.css" rel="stylesheet" />
</head>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestión de Vacunas</h2>
    <asp:GridView ID="gvVacunas" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="id_vacuna" HeaderText="ID" />
            <asp:BoundField DataField="nombre_vacuna" HeaderText="Vacuna" />
            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
            <asp:BoundField DataField="fecha_aplicacion" HeaderText="Fecha" />
            <asp:BoundField DataField="dosis" HeaderText="Dosis" />
            <asp:BoundField DataField="paciente" HeaderText="Paciente" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:TextBox ID="txtNombreVacuna" runat="server" Placeholder="Nombre Vacuna" /><br />
    <asp:TextBox ID="txtTipo" runat="server" Placeholder="Tipo" /><br />
    <asp:Calendar ID="calFecha" runat="server" /><br />
    <asp:TextBox ID="txtDosis" runat="server" Placeholder="Dosis" /><br />
    <asp:DropDownList ID="ddlPacientes" runat="server" /><br />
    <asp:Button ID="btnAgregarVacuna" runat="server" Text="Agregar" OnClick="btnAgregarVacuna_Click" />
</asp:Content>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="MainMenu" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="Inicio" NavigateUrl="~/FRMenu.aspx" />
                    <asp:MenuItem Text="Pacientes" NavigateUrl="~/FRMPacientes.aspx" />
                    <asp:MenuItem Text="Vacunas" NavigateUrl="~/FRMVacunas.aspx" />
                    <asp:MenuItem Text="Reportes" NavigateUrl="~/FRMReportes.aspx" />
                </Items>
            </asp:Menu>
            <asp:ContentPlaceHolder ID="MainContent" runat="server" />
        </div>
    </form>
</body>
</html>
