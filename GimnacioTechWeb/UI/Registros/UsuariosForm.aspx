<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosForm.aspx.cs" Inherits="GimnacioTechWeb.Formularios.UsuariosForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusión de Bootstrap 4.0.0-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"></script>
   
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Registro de Usuario</title>
</head>
<body>
    <!--Menu -->
    <nav class="navbar bg-secondary navbar-expand-lg navbar-light">
        <a class="navbar-brand" href="#">RD-GYM</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavDropdown">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="#">Inicio <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item dropdown active">
                    <a class="nav-link dropdown-toggle" href="#" id="UsuariosnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Usuarios
                    </a>
                    <div class="dropdown-menu" aria-labelledby="UsuariosnavbarDropdownMenuLink">
                        <a class="dropdown-item" href="http://localhost:52411/UI/Registros/UsuariosForm.aspx">Registro</a>
                        <a class="dropdown-item" href="http://localhost:52411/UI/Consultas/UsuariosConsulta.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="ClientesnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Clientes
                    </a>
                    <div class="dropdown-menu" aria-labelledby="ClientesnavbarDropdownMenuLink">
                        <a class="dropdown-item" href="#">Registro</a>
                        <a class="dropdown-item" href="#">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="ProductosnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Productos
                    </a>
                    <div class="dropdown-menu" aria-labelledby="ProductosnavbarDropdownMenuLink">
                        <a class="dropdown-item" href="#">Registro</a>
                        <a class="dropdown-item" href="#">Consulta</a>
                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Factura</a>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container-fluid">
        <div class="page-header col-12">
            <h1>Registro de Usuario</h1>
        </div>
        <!--Formulario-->
        <div class="col-12 col-sm-8 col-md-6 col-lg-5">
            <form id="form1" runat="server">
                <!--Usuario Id-->
                <div class="form-group">
                    <asp:Label ID="UsuarioIdLabel" runat="server" Text="Usuario Id:"></asp:Label>
                    <div class="form-inline">
                        <asp:TextBox ID="UsuarioIdTextBox" runat="server" CssClass="form-control text-center col-8 col-sm-9 col-xl-10" autocomplete="off"></asp:TextBox>
                        <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-secondary col-4 col-sm-3 col-xl-2" Text="Buscar" OnClick="BuscarButton_Click" />
                    </div>
                </div>
                <!--Nombres-->
                <div class="form-group">
                    <asp:Label ID="NombresLabel" runat="server" Text="Nombres:"></asp:Label>
                    <asp:TextBox ID="NombresTextBox" runat="server" CssClass="form-control text-center" autocomplete="off"></asp:TextBox>
                </div>
                <!--NombreUsuario-->
                <div class="form-group">
                    <asp:Label ID="NombreUsuarioLabel" runat="server" Text="Nombre Usuario:"></asp:Label>
                    <asp:TextBox ID="NombreUsuarioTextBox" runat="server" CssClass="form-control text-center" autocomplete="off"></asp:TextBox>
                </div>
                <!--Clave-->
                <div class="form-group">
                    <asp:Label ID="ClaveLabel" runat="server" Text="Clave:"></asp:Label>
                    <asp:TextBox type="Password" ID="ClaveTextBox" runat="server" CssClass="form-control text-center"></asp:TextBox>
                </div>
                <!--ConfirmarClave-->
                <div class="form-group">
                    <asp:Label ID="ConfirmarClaveLabel" runat="server" Text="Confirmar Clave:"></asp:Label>
                    <asp:TextBox type="Password" ID="ConfirmarClaveTextBox" runat="server" CssClass="form-control text-center"></asp:TextBox>
                </div>
                <!--Cargo-->
                <div class="form-group">
                    <asp:Label ID="CargoLabel" runat="server" Text="Cargo:"></asp:Label>
                    <asp:DropDownList ID="CargoDropDownList" runat="server" CssClass="form-control text-center">
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>Empleado</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <!--Fecha-->
                <div class="form-group">
                    <asp:Label ID="FechaIngresoLabel" runat="server" Text="Fecha Ingreso:"></asp:Label>
                    <asp:TextBox type="date" ID="FechaIngresoTextBox" runat="server" CssClass="form-control text-center"></asp:TextBox>
                </div>
                <!--Botones-->
                <div class="text-center">
                    <asp:Button ID="NuevoButton" runat="server" CssClass="btn btn-secondary" Text="Nuevo" OnClick="NuevoButton_Click" />
                    <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-secondary" Text="Guardar" OnClick="GuardarButton_Click" />
                    <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Eliminar" OnClick="EliminarButton_Click" />
                </div>
            </form>
        </div>
    </div>    
</body>
</html>