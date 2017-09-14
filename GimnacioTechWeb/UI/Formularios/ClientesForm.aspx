<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesForm.aspx.cs" Inherits="GimnacioTechWeb.ClientesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ClienteIdLabel" runat="server" Text="Cliente Id:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="ClienteIdTextBox" runat="server"></asp:TextBox>
        </div>

         <div>
            <asp:Label ID="NombreClienteLabel" runat="server" Text="Nombres:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="NombreClienteTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="SexoLabel" runat="server" Text="Sexo:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="SexoTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="DireccionLabel" runat="server" Text="Direccion:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>
        </div>
        
        <div>
            <asp:Label ID="NumeroCelularLabel" runat="server" Text="Numero Celular:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="NumeroCelularTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="EmailLabel" runat="server" Text="Email:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="FechaLabel" runat="server" Text="Fecha:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <br />
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
        </div>
    </form>
</body>
</html>
