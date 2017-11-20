<%@ Page Title="Registro de usuarios" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="UsuariosRegistro.aspx.cs" Inherits="GimnacioTechWeb.UI.Registros.UsuariosRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header col-12">
            <h1>Registro de Usuarios</h1>
            <br />
        </div>
        <!--Formulario-->
        <div class="col-12 col-sm-8 col-md-6 col-lg-5">

            <div class="float-right">
                <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-secondary" Text="Buscar" OnClick="BuscarButton_Click" />
            </div>
            <br />
            <!--Usuario Id-->
            <div class="form-group">
                <asp:Label ID="UsuarioIdLabel" runat="server" Text="Usuario Id:"></asp:Label>
                <asp:TextBox ID="UsuarioIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Nombres-->
            <div class="form-group">
                <asp:Label ID="NombresLabel" runat="server" Text="Nombres:"></asp:Label>
                <asp:TextBox ID="NombresTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--NombreUsuario-->
            <div class="form-group">
                <asp:Label ID="NombreUsuarioLabel" runat="server" Text="Nombre Usuario:"></asp:Label>
                <asp:TextBox ID="NombreUsuarioTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Clave-->
            <div class="form-group">
                <asp:Label ID="ClaveLabel" runat="server" Text="Clave:"></asp:Label>
                <asp:TextBox type="Password" ID="ClaveTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--ConfirmarClave-->
            <div class="form-group">
                <asp:Label ID="ConfirmarClaveLabel" runat="server" Text="Confirmar Clave:"></asp:Label>
                <asp:TextBox type="Password" ID="ConfirmarClaveTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--Cargo-->
            <div class="form-group">
                <asp:Label ID="CargoLabel" runat="server" Text="Cargo:"></asp:Label>
                <asp:DropDownList ID="CargoDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Usuario">Usuario</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
            </div>
            <!--Fecha-->
            <div class="form-group">
                <asp:Label ID="FechaIngresoLabel" runat="server" Text="Fecha Ingreso:"></asp:Label>
                <asp:TextBox type="Date" ID="FechaIngresoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--Botones-->
            <div class="text-center">
                <asp:Button ID="NuevoButton" runat="server" CssClass="btn btn-secondary" Text="Nuevo" OnClick="NuevoButton_Click" />
                <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-secondary" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EnviarAlModalEliminarButton" CssClass="btn btn-secondary" runat="server" Text="Eliminar" OnClick="EnviarAlModalEliminarButton_Click" />
            </div>
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
                            <p>Esta seguro de eliminar este usuario?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Si" OnClick="EliminarButton_Click" />
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--Col formulario-->
    </div>
    <!--Contenedor-->
</asp:Content>
