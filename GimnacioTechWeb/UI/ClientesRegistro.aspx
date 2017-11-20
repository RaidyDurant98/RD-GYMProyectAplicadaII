<%@ Page Title="Registro de clientes" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="ClientesRegistro.aspx.cs" Inherits="GimnacioTechWeb.UI.ClientesRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header col-12">
            <h1>Registro de Clientes</h1>
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
                <asp:Label ID="ClienteIdLabel" runat="server" Text="Cliente Id:"></asp:Label>
                <asp:TextBox ID="ClienteIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Nombres-->
            <div class="form-group">
                <asp:Label ID="NombresLabel" runat="server" Text="Nombres:"></asp:Label>
                <asp:TextBox ID="NombresTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Direccion-->
            <div class="form-group">
                <asp:Label ID="DireccionLabel" runat="server" Text="Direccion:"></asp:Label>
                <asp:TextBox ID="DireccionTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--NumeroCelular-->
            <div class="form-group">
                <asp:Label ID="NumeroCelularLabel" runat="server" Text="Numero Celular:"></asp:Label>
                <asp:TextBox ID="NumeroCelularTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Email-->
            <div class="form-group">
                <asp:Label ID="EmailLabel" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Fecha-->
            <div class="form-group">
                <asp:Label ID="FechaInscripcionLabel" runat="server" Text="Fecha Inscripcion:"></asp:Label>
                <asp:TextBox type="Date" ID="FechaInscripcionTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--Sexo-->
            <div class="form-group">
                <asp:Label ID="SexoLabel" runat="server" Text="Sexo:"></asp:Label>
                <div class="form-check">
                    <div class="row">
                        <div class="col-6">
                            <asp:RadioButton ID="MasculinoRadioButton" runat="server" Text="Masculino" GroupName="Sexo" />
                        </div>
                        <div class="col-6">
                            <asp:RadioButton ID="FemeninoRadioButton" runat="server" Text="Femenino" GroupName="Sexo" />
                        </div>
                    </div>
                </div>
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
                            <p>Esta seguro de eliminar este cliente?</p>
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
