<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosReporte.aspx.cs" Inherits="GimnacioTechWeb.UI.Reportes.UsuariosReporte" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reporte de Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="UsuariosScriptManager" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="UsuariosReportViewer" runat="server" ProcessingMode="Local" Height="800px" Width="967px">
          <ServerReport ReportPath="" ReportServerUrl="" />
        </rsweb:ReportViewer>
    </form>
</body>
</html>
