<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesReporte.aspx.cs" Inherits="GimnacioTechWeb.UI.Reportes.ClientesReporte" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ClientesScriptManager" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ClientesReportViewer" runat="server" ProcessingMode="Local" Height="800px" Width="967px">
            <ServerReport ReportPath="" ReportServerUrl="" />
        </rsweb:ReportViewer>
    </form>
</body>
</html>
