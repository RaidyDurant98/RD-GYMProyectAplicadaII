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

    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="container">
                  <asp:GridView ID="UsuariosConsultaGridView" runat="server"></asp:GridView>                     
            </div>
            <div>
                <asp:Button ID="UsuarioConsultaButton" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="UsuarioConsultaButton_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
