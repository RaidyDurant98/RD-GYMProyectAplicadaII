<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosConsulta.aspx.cs" Inherits="GimnacioTechWeb.Consultas.UsuariosConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <!--Inclusión de Bootstrap 4.0.0-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" ></script>

    <title>Consulta de Usuarios</title>
</head>
<body>
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
                        <a class="dropdown-item" href="http://localhost:52411/UI/Registros/UsuariosForm.aspx#">Registro</a>
                        <a class="dropdown-item" href="http://localhost:52411/UI/Consultas/UsuariosConsulta.aspx#">Consulta</a>
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
        <div class="page-header text-center">
            <h1>Consulta de Usuarios</h1>
            <br />
        </div>

        <form id="form1" runat="server" role="form">
            <div class ="container">
                <div class="row">
                    <div class="col-12 col-sm-5">
                        <asp:DropDownList ID="FiltrarDropDownList" runat="server" CssClass="form-control ">
                            <asp:ListItem>Todo</asp:ListItem>
                            <asp:ListItem>ID</asp:ListItem>
                            <asp:ListItem>Nombres</asp:ListItem>
                            <asp:ListItem>Nombre de Usuario</asp:ListItem>
                            <asp:ListItem>Fecha Ingreso</asp:ListItem>
                            <asp:ListItem>Cargo Usuario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-12 col-sm-7">
                        <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control text-center" autoComplete="off"></asp:TextBox> 
                    </div>
                </div>    
                <!--<div class="container">-->
                    <div class="row">
                        <div class="form-group col-12 col-sm-6">
                            <asp:Label ID="DesdeLabel" runat="server" Text="Desde:" CssClass=""></asp:Label>
                            <asp:TextBox type="date" CssClass="form-control" ID="FechaDesdeTextBox" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-12 col-sm-6">
                            <asp:Label ID="HastaLabel" runat="server" Text="Hasta:"></asp:Label>
                            <asp:TextBox type="date" CssClass="form-control" ID="FechaHastaTextBox" runat="server"></asp:TextBox>
                        </div>
                    </div>
                <!--</div>-->
            </div><!--Container-->

            <div class="container">
                <div class="col-12 col-sm-12 col-md-12">
                    <div class="float-right">
                        <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-secondary" Text="Filtrar" OnClick="FiltroButton_Click" />
                    </div>
                    <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None" ID="UsuariosConsultaGridView" runat="server" AutoGenerateColumns="False" GridLines="Horizontal">
                        <HeaderStyle CssClass="bg-secondary"/>     
                        <Columns>
                            <asp:BoundField DataField="UsuarioId" HeaderText="Usuario Id"/>
                            <asp:BoundField DataField="Nombres" HeaderText="Nombres"/>
                            <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario"/>
                            <asp:BoundField DataField="Cargo" HeaderText="Gargo"/>
                            <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso"/>                           
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" CssClass="btn btn-secondary" OnClick="EliminarButton_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="ModificarButton" runat="server" Text="Modificar" CssClass="btn btn-secondary"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView> 
                </div>
            </div>

        </form>
    </div>
</body>
</html>
