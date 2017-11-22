<%@ Page Title="Registro de categoria de productos" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="CategoriaProductosRegistro.aspx.cs" Inherits="GimnacioTechWeb.UI.CategoriaProductosRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header col-12">
            <br />
            <h1>Registro de Categorias</h1>
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
                <asp:Label ID="CategoriaIdLabel" runat="server" Text="Categoria Id:"></asp:Label>
                <asp:TextBox type="number" ID="CategoriaIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Nombres-->
            <div class="form-group">
                <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion:"></asp:Label>
                <asp:TextBox ID="DescripcionTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
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
                            <p>Esta seguro de eliminar esta categoria?</p>
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
