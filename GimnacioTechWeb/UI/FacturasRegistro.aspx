<%@ Page Title="Factura" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="FacturasRegistro.aspx.cs" Inherits="GimnacioTechWeb.UI.FacturasRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-7 col-sm-9 col-md-10">
            </div>
            <div class="col-5 col-sm-3 col-md-2">
                <asp:Label ID="FechaFacturaLabel" runat="server" Font-Size="Large" CssClass="h4"></asp:Label>
            </div>
        </div>

        <div class="page-header col-12">
            <h1>Factura</h1>
            <br />
        </div>

        <!--Formulario-->
        <div class="col-12 col-sm-8 col-md-6 col-lg-5">
            <div class="float-right">
                <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-secondary" Text="Buscar" OnClick="BuscarButton_Click" />
            </div>
            <br />
            <!--Factura Id-->
            <div class="form-group">
                <asp:Label ID="FacturaIdLabel" runat="server" Text="Factura Id:"></asp:Label>
                <asp:TextBox type="number" ID="FacturaIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
            </div>
            <!--Cliente-->
            <div class="form-group">
                <asp:Label ID="ClienteIdLabel" runat="server" Text="Cliente Id:"></asp:Label>
                <div class="row">
                    <div class="col-10 col-md-3">
                        <asp:TextBox type="number" ID="ClienteIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="BuscarClienteButton" runat="server" CssClass="btn btn-secondary" OnClick="BuscarClienteButton_Click" Text="B" />
                    </div>
                    <div class="col-10 col-md-6">
                        <asp:TextBox ID="NombreClienteTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="CrearClienteButton" runat="server" CssClass="btn btn-secondary" OnClick="CrearClienteButton_Click" Text="A" />
                    </div>
                </div>
            </div>
            <!--Comentario-->
            <div class="form-group">
                <asp:Label ID="ComentarioLabel" runat="server" Text="Comentario:"></asp:Label>
                <asp:TextBox ID="ComentarioTextBox" runat="server" CssClass="form-control" autocomplete="off" TextMode="MultiLine"></asp:TextBox>
            </div>
            <!--Forma de Pago-->
            <div class="form-group">
                <asp:Label ID="FormaPagoLabel" runat="server" Text="Forma de Pago:"></asp:Label>
                <asp:DropDownList CssClass="form-control" ID="FormaPagoDropDownList" runat="server" OnSelectedIndexChanged="FormaPagoDropDownList_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem>Contado</asp:ListItem>
                    <asp:ListItem>Credito</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <!--Container-->
        <div class="container-fluid">
            <!--Producto-->
            <div class="form-group">
                <asp:Label ID="ProductoIdLabel" runat="server" Text="Producto Id:"></asp:Label>
                <div class="row">
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox type="number" ID="ProductoIdTextBox" runat="server" CssClass="form-control" autocomplete="off" OnTextChanged="ProductoIdTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="BuscarProductoButton" runat="server" CssClass="btn btn-secondary" OnClick="BuscarProductoButton_Click" Text="B" />
                    </div>
                    <div class="col-10 col-sm-6 col-md-4">
                        <asp:TextBox ID="DescripcionProductoTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox ID="PrecioProductoTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox type="number" ID="CantidadProductoTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="AgregarProductoButton" runat="server" CssClass="btn btn-secondary" OnClick="AgregarProductoButton_Click" Text="A" />
                    </div>
                </div>
            </div>
            <!--Grid Detalle-->
            <div class="form-group">
                <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None"
                    ID="DetalleGridView" runat="server" GridLines="Horizontal" ShowFooter="true">
                    <HeaderStyle CssClass="bg-secondary text-white" />
                    <FooterStyle CssClass="bg-secondary" />
                </asp:GridView>
            </div>
            <!--Monto-->
            <div class="row">
                <div class="col-12 col-md-8"></div>
                <div class="col-10 col-md-2">
                    <div class="form-group">
                        <asp:Label ID="MontoLabel" runat="server" Text="Monto:"></asp:Label>
                        <asp:TextBox type="number" ID="MontoTextBox" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="row">
                    <div class="col-12 col-md-7"></div>
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox type="number" ID="DineroPagadoTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="CalcularDevueltaButton" runat="server" CssClass="btn btn-secondary" OnClick="CalcularDevueltaButton_Click" Text="C" />
                    </div>
                    <div class="col-10 col-sm-6 col-md-2">
                        <asp:TextBox ID="DevueltaTextBox" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-12 col-sm-8 col-md-6 col-lg-5">
            <!--Botones-->
            <div class="text-center">
                <asp:Button ID="NuevoButton" runat="server" CssClass="btn btn-secondary" Text="Nuevo" OnClick="NuevoButton_Click" />
                <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-secondary" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EnviarAlModalEliminarButton" CssClass="btn btn-secondary" runat="server" Text="Eliminar" OnClick="EnviarAlModalEliminarButton_Click" />
            </div>
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
                        <p>Esta seguro de eliminar esta factura?</p>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Si" OnClick="EliminarButton_Click" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
