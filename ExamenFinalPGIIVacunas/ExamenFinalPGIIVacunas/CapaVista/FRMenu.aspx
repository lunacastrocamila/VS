<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMenu.aspx.cs" Inherits="ExamenFinalPGIIVacunas.CapaVista.FRMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Vacunas</title>
    <link href="~/Styles/menu.css" rel="stylesheet" />
</head>
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
