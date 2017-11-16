<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GimnacioTechWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusión de Bootstrap 4.0.0-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"></script>

    <!--Inclusión de scripts Personales-->
    <script src="../../Scripts/MyScripts.js"></script>

    <!--Inclusión de Style Sheet Personal-->
    <link rel="stylesheet" href="../../CSS/MyStyles.css" />

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Menu Principal</title>
</head>
<body>
    <form id="form1" runat="server">
        <!--Menu -->
        <nav id="Navar" class="navbar bg-secondary navbar-expand-lg navbar-dark">
            <a class="navbar-brand" href="Default.aspx">RD-GYM</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavDropdown">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" href="Default.aspx">Inicio <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="UsuariosnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Usuarios
                        </a>
                        <div class="dropdown-menu" aria-labelledby="UsuariosnavbarDropdownMenuLink">
                            <a class="dropdown-item" href="Registros/UsuariosForm.aspx">Registro</a>
                            <a class="dropdown-item" href="Consultas/UsuariosConsulta.aspx">Consulta</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="ClientesnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Clientes
                        </a>
                        <div class="dropdown-menu" aria-labelledby="ClientesnavbarDropdownMenuLink">
                            <a class="dropdown-item" href="Registros/ClientesForm.aspx">Registro</a>
                            <a class="dropdown-item" href="Consultas/ClientesConsulta.aspx">Consulta</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="CategoriaProductonavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Categorias de Productos
                        </a>
                        <div class="dropdown-menu" aria-labelledby="CategoriaProductonavbarDropdownMenuLink">
                            <a class="dropdown-item" href="Registros/CategoriaProductosForm.aspx">Registro</a>
                            <a class="dropdown-item" href="Consultas/CategoriaProductosConsulta.aspx">Consulta</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="ProductosnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Productos
                        </a>
                        <div class="dropdown-menu" aria-labelledby="ProductosnavbarDropdownMenuLink">
                            <a class="dropdown-item" href="Registros/ProductosForm.aspx">Registro</a>
                            <a class="dropdown-item" href="Consultas/ProductosConsulta.aspx">Consulta</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="FacturanavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Factura
                        </a>
                        <div class="dropdown-menu" aria-labelledby="FacturanavbarDropdownMenuLink">
                            <a class="dropdown-item" href="#">Registro</a>
                            <a class="dropdown-item" href="#">Consulta</a>
                        </div>
                    </li>
                </ul>
                <span class="navbar-text">
                    <asp:Button CssClass="btn btn-outline-dark" ID="SingOutButton" runat="server" Text="Cerrar sesion" OnClick="SingOutButton_Click"/>
                </span>
            </div>
        </nav>
    </form>
</body>
</html>
