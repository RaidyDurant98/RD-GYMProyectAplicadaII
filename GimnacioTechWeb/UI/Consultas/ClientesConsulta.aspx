<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesConsulta.aspx.cs" Inherits="GimnacioTechWeb.Consultas.ClientesConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusión de Bootstrap 4.0.0-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" ></script>

    <!--Inclusión de scripts Personales-->
    <script src="../../Scripts/Scripts.js"></script>

    <!--Inclusión de Style Sheet Personal-->
    <link rel="stylesheet" href="../../CSS/MyStyles.css"/>

    <title>Consulta de Clientes</title>
</head>
<body>
    <!--Menu -->
    <nav id="Navar" class="navbar bg-secondary navbar-expand-lg navbar-dark">
        <a class="navbar-brand" href="#">RD-GYM</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavDropdown">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="#">Inicio <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="UsuariosnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Usuarios
                    </a>
                    <div class="dropdown-menu" aria-labelledby="UsuariosnavbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/UsuariosForm.aspx">Registro</a>
                        <a class="dropdown-item" href="UsuariosConsulta.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown active">
                    <a class="nav-link dropdown-toggle" href="#" id="ClientesnavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Clientes
                    </a>
                    <div class="dropdown-menu" aria-labelledby="ClientesnavbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/ClientesForm.aspx">Registro</a>
                        <a class="dropdown-item" href="ClientesConsulta.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="CategoriaProductonavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Categorias de Productos
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
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="FacturanavbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Factura
                    </a>
                    <div class="dropdown-menu" aria-labelledby="FacturanavbarDropdownMenuLink">
                        <a class="dropdown-item" href="#">Registro</a>
                        <a class="dropdown-item" href="#">Consulta</a>
                    </div>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container-fluid">
        <div class="page-header text-center">
            <h1>Consulta de Clientes</h1>
            <br />
        </div>
        <form id="form1" runat="server" role="form">
            <div class ="container">
                <!--DropDowmList y TextBox-->
                <div class="row">
                    <div class="col-12 col-sm-5">
                        <asp:DropDownList ID="FiltrarDropDownList" runat="server" CssClass="form-control">
                            <asp:ListItem>Todo</asp:ListItem>
                            <asp:ListItem>ID</asp:ListItem>
                            <asp:ListItem>Nombres</asp:ListItem>
                            <asp:ListItem>Direccion</asp:ListItem>
                            <asp:ListItem>Fecha Ingreso</asp:ListItem>
                            <asp:ListItem>Sexo</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-12 col-sm-7">
                        <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control" autoComplete="off"></asp:TextBox> 
                    </div>
                </div>    
                <!--TextBox Fecha-->
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
            </div><!--Container-->
            <!--GridView-->
            <div class="container">
                <div class="col-12">
                    <!--Alertas-->
                    <div class="float-left col-sm-5">
                        <asp:Panel CssClass="alert alert-info text-center" ID="AlertInfoPanel" role="alert" runat="server">
                            <asp:Label ID="AlertInfoLabel" runat="server" Text=""></asp:Label>
                        </asp:Panel>
                        <asp:Panel CssClass="alert alert-success text-center" ID="AlertSuccessPanel"  role="alert" runat="server">
                            <asp:Label ID="AlertSuccessLabel" runat="server" Text=""></asp:Label>
                        </asp:Panel>
                        <asp:Panel CssClass="alert alert-danger text-center" ID="AlertDangerPanel" role="alert" runat="server">
                            <asp:Label ID="AlertDangerLabel" runat="server" Text=""></asp:Label>
                        </asp:Panel>
                    </div>
                    <br />
                    <br />
                    <div class="float-right">
                        <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-secondary" Text="Filtrar" OnClick="FiltroButton_Click"/>
                    </div>
                    <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None" ID="ClientesConsultaGridView" runat="server" 
                        AutoGenerateColumns="False" GridLines="Horizontal" DataKeyNames="ClienteId,Nombres" ShowFooter="true">
                        <HeaderStyle CssClass="bg-secondary"/>
                        <Columns>
                            <asp:BoundField DataField="ClienteId" HeaderText="Cliente Id"/>
                            <asp:BoundField DataField="Nombres" HeaderText="Nombres"/>
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion"/>
                            <asp:BoundField DataField="NumeroCelular" HeaderText="Numero Celular"/>
                            <asp:BoundField DataField="Email" HeaderText="Email"/>
                            <asp:BoundField DataField="Sexo" HeaderText="Sexo"/>
                            <asp:BoundField DataField="FechaInscripcion" DataFormatString="{0:d}" HeaderText="Fecha Inscripcion"/>     
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <!--<asp:Button ID="SeleccionButton" runat="server" CommandName="Select" CssClass="btn btn-secondary" Text="Eliminar"/>-->
                                    <asp:Button ID="EnviarAlModalEliminarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server" 
                                        Text="Eliminar" OnClick="EnviarAlModalEliminarButton_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="EnviarAlModalModificarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server" 
                                        Text="Modificar" OnClick="EnviarAlModalModificarButton_Click"/>                             
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle CssClass="bg-secondary"/>
                    </asp:GridView> 
                    <div class="float-left">
                        <asp:Button ID="ImprimirButton" runat="server" CommandName="Select" CssClass="btn btn-secondary" Text="Imprimir" OnClick="ImprimirButton_Click"/>
                    </div>
                </div>
            </div><!--Div grid view-->

            <!--Modal de confirmacion de eliminar-->
            <div class="modal" id="ModalEliminar">
                <div class="modal-dialog" role="document">
                    <div class="modal-content ">
                        <div class="modal-header bg-secondary">
                            <h5 class="modal-title">¡Atencion!</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <p>Esta seguro de eliminar este cliente?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Si" OnClick="EliminarButton_Click"/>
                            <asp:Button ID="CancelarEliminacionButton" runat="server" CssClass="btn btn-secondary" Text="No" OnClick="CancelarEliminacionButton_Click"/>
                        </div>
                    </div>
                </div>
            </div><!--Modal eliminar-->
            <!--Modal de confirmacion de modificar-->
            <div class="modal" id="ModalModificar">
                <div class="modal-dialog" role="document">
                    <div class="modal-content ">
                        <div class="modal-header bg-secondary">
                            <h5 class="modal-title">¡Atencion!</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <p>Esta seguro de modificar este usuario?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="ModificarButton" runat="server" CssClass="btn btn-secondary" Text="Si" OnClick="ModificarButton_Click"/>
                            <asp:Button ID="CancelarModificacionButton" runat="server" CssClass="btn btn-secondary" Text="No" OnClick="CancelarModificacionButton_Click"/>
                        </div>
                    </div>
                </div>
            </div><!--Modal modificar-->
        </form>
    </div>
</body>
</html>
