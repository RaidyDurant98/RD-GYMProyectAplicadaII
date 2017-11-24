<%@ Page Title="Consulta de usuarios" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="UsuariosConsulta.aspx.cs" Inherits="GimnacioTechWeb.UI.UsuariosConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header text-center">
            <h1>Consulta de Usuarios</h1>
            <br />
        </div>

        <div class="container">
            <!--DropDowmList y TextBox-->
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
        </div>
        <!--Container-->
        <!--GridView-->
        <div class="container">
            <div class="col-12">
                <div class="float-right">
                    <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-secondary" Text="Filtrar" OnClick="FiltroButton_Click" />
                </div>
                <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None" ID="UsuariosConsultaGridView" runat="server"
                    AutoGenerateColumns="False" GridLines="Horizontal" DataKeyNames="UsuarioId,Nombres" ShowFooter="true">
                    <HeaderStyle CssClass="bg-secondary" />
                    <Columns>
                        <asp:BoundField DataField="UsuarioId" HeaderText="Usuario Id" />
                        <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario" />
                        <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                        <asp:BoundField DataField="FechaIngreso" DataFormatString="{0:d}" HeaderText="Fecha Ingreso" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="EnviarAlModalEliminarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server"
                                    Text="Eliminar" OnClick="EnviarAlModalEliminarButton_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="EnviarAlModalModificarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server"
                                    Text="Modificar" OnClick="EnviarAlModalModificarButton_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle CssClass="bg-secondary" />
                </asp:GridView>
                <div class="float-left">
                    <asp:Button ID="ImprimirButton" runat="server" CommandName="Select" CssClass="btn btn-secondary" Text="Imprimir" OnClick="ImprimirButton_Click" />
                </div>
            </div>
        </div>
        <!--Div grid view-->

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
                        <asp:Button ID="CancelarEliminacionButton" runat="server" CssClass="btn btn-secondary" Text="No" OnClick="CancelarEliminacionButton_Click" />
                    </div>
                </div>
            </div>
        </div>

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
                        <asp:Button ID="ModificarButton" runat="server" CssClass="btn btn-secondary" Text="Si" OnClick="ModificarButton_Click" />
                        <asp:Button ID="CancelarModificacionButton" runat="server" CssClass="btn btn-secondary" Text="No" OnClick="CancelarModificacionButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
