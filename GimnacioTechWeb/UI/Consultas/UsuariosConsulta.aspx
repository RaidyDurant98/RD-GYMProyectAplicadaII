<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosConsulta.aspx.cs" Inherits="GimnacioTechWeb.Consultas.UsuariosConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <title></title>
</head>
<body>
    <nav class="navbar navbar-inverse navbar-static-top">
        <div class="container-fluid">
            <div>
                <a class="navbar-brand" href="http://localhost:50506/UI/Index.aspx#">RD-GYM</a>
            </div>
            <div>               
                <ul class="nav navbar-nav">
                    <li><a href="http://localhost:52411/UI/Formularios/UsuariosForm.aspx">Registro de Usuario</a></li>
                    <li><a href="#">Registro de Clientes</a></li> 
                    <li><a href="#">Registro de Productos</a></li> 
                    <li class="active"><a href="http://localhost:52411/UI/Consultas/UsuariosConsulta.aspx">Consulta de Usuarios</a></li> 
                    <li><a href="#">Consulta de Clientes</a></li> 
                    <li><a href="#">Consulta de Productos</a></li>
                    <li><a href="#">Factura</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <!--Header del Registro-->
    <header>
        <div class="page-header">
            <h1>Consulta de Usuario<span class="glyphicon glyphicon-user"></span></h1>
        </div>
    </header>

    <form id="form1" runat="server" class="form-inline" role="form">
        <asp:Label ID="FiltroLabel" runat="server" Text="Campos a Filtrar:"></asp:Label>
        <asp:DropDownList ID="FiltrarDropDownList" runat="server" class="form-control">
            <asp:ListItem>Todo</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Nombres</asp:ListItem>
            <asp:ListItem>Nombre de Usuario</asp:ListItem>
            <asp:ListItem>Fecha Ingreso</asp:ListItem>
            <asp:ListItem>Cargo Usuario</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="FiltroTextBox" runat="server" class="form-control"></asp:TextBox>
        <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-info" Text="Filtrar" OnClick="FiltroButton_Click" />

        <div class="container">
            <div class="table-responsive">
                <table class="table table-hover">
                    <asp:GridView ID="UsuariosConsultaGridView" runat="server">
                    </asp:GridView>  
                </table>
            </div>                              
        </div>
    </form>
</body>
</html>
