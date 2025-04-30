<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMVacunas.aspx.cs" Inherits="ExamenFinalPGIIVacunas.CapaVista.FRMVacunas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Vacunas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registrar Vacuna</h2>

            <asp:Label runat="server" Text="Paciente:" AssociatedControlID="ddlPacientes" />
            <asp:DropDownList ID="ddlPacientes" runat="server" />

            <br /><br />

            <asp:Label runat="server" Text="Nombre de la vacuna:" AssociatedControlID="txtNombre" />
            <asp:TextBox ID="txtNombre" runat="server" />

            <br /><br />

            <asp:Label runat="server" Text="Tipo de vacuna:" AssociatedControlID="txtTipo" />
            <asp:TextBox ID="txtTipo" runat="server" />

            <br /><br />

            <asp:Label runat="server" Text="Fecha de aplicación:" AssociatedControlID="txtFechaAplicacion" />
            <asp:TextBox ID="txtFechaAplicacion" runat="server" TextMode="Date" />

            <br /><br />

            <asp:Label runat="server" Text="Dosis:" AssociatedControlID="txtDosis" />
            <asp:TextBox ID="txtDosis" runat="server" />

            <br /><br />

            <asp:Button ID="btnAgregar" runat="server" Text="Registrar Vacuna" OnClick="btnAgregar_Click" />

            <hr />

            <asp:GridView ID="gvVacunas" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>
