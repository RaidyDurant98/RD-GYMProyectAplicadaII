<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosForm.aspx.cs" Inherits="GimnacioTechWeb.Formularios.UsuariosForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

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
                    <li class="active"><a href="http://localhost:52411/UI/Formularios/UsuariosForm.aspx">Registro de Usuario</a></li>
                    <li><a href="#">Registro de Clientes</a></li> 
                    <li><a href="#">Registro de Productos</a></li> 
                    <li><a href="http://localhost:52411/UI/Consultas/UsuariosConsulta.aspx">Consulta de Usuarios</a></li> 
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
            <h1>Registro de Usuario<span class="glyphicon glyphicon-user"></span></h1>
        </div>
    </header>

    <form id="form1" runat="server">
        <div class="container-fluid col-lg-4 col-md-4 col-sm-6 col-xs-10">   
            <!--Usuario Id-->
            <div class="form-group">
                <asp:Label ID="UsuarioIdLabel" runat="server" Text="Usuario Id:"></asp:Label>
                <asp:TextBox ID="UsuarioIdTextBox" runat="server" class="form-control text-center"></asp:TextBox>
                <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-warning col-md-2 col-md-offset-10" Text="Buscar" OnClick="BuscarButton_Click" />
            </div>
            <!--Nombres-->
            <div class="form-group">
                <asp:Label ID="NombresLabel" runat="server" Text="Nombres:"></asp:Label>
                <asp:TextBox ID="NombresTextBox" runat="server" class="form-control text-center"></asp:TextBox>
            </div>
            <!--NombreUsuario-->
            <div class="form-group">
                <asp:Label ID="NombreUsuarioLabel" runat="server" Text="Nombre Usuario:"></asp:Label>
                <asp:TextBox ID="NombreUsuarioTextBox" runat="server" class="form-control text-center"></asp:TextBox>
            </div>
            <!--Clave-->
            <div class="form-group">
                <asp:Label ID="ClaveLabel" runat="server" Text="Clave:"></asp:Label>
                <asp:TextBox ID="ClaveTextBox" runat="server" class="form-control text-center"></asp:TextBox>
            </div>
            <!--ConfirmarClave-->
            <div class="form-group">
                <asp:Label ID="ConfirmarClaveLabel" runat="server" Text="Confirmar Clave:"></asp:Label>
                <asp:TextBox ID="ConfirmarClaveTextBox" runat="server" class="form-control text-center"></asp:TextBox>
            </div>
            <!--Cargo-->
            <div class="form-group">
                <asp:Label ID="CargoLabel" runat="server" Text="Cargo:"></asp:Label>
                <asp:DropDownList ID="CargoDropDownList" runat="server" class="form-control">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem>Empleado</asp:ListItem>
                </asp:DropDownList>
            </div>
            <!--Botones-->
            <div role="tooltip">
                <asp:Button ID="NuevoButton" runat="server" CssClass="btn btn-info col-lg-2" Text="Nuevo" OnClick="NuevoButton_Click" />
                <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-success col-lg-2 col-lg-offset-3" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-danger col-lg-2 col-lg-offset-3" Text="Eliminar" OnClick="EliminarButton_Click" />
            </div>
        </div>
    </form>
</body>
</html>