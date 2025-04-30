<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMReportes.aspx.cs" Inherits="ExamenFinalPGIIVacunas.CapaVista.FRMReportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Reporte de Vacunas por Tipo</h2>
    <asp:GridView ID="gvReporte" runat="server" AutoGenerateColumns="true" />
    <br />
    <asp:Button ID="btnCargarReporte" runat="server" Text="Ver Reporte" OnClick="btnCargarReporte_Click" />
</asp:Content>

<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
