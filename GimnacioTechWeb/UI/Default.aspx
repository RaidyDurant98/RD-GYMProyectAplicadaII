<%@ Page Title="RD-GYM" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GimnacioTechWeb.UI.DefaultP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 col-md-4">
                <div class="form-group">
                    <div class="card">
                        <h4 class="card-header bg-secondary text-white">Productos</h4>
                        <div class="card-body">
                            <h4 class="card-title">Vista de Productos</h4>
                            <p class="card-text">En la vista de productos puedes encontrar el registro de productos donde guardas los productos y su consulta para filtrar los productos guardados.</p>
                            <asp:Button ID="RegistroProductoButton" class="btn btn-secondary" runat="server" Text="Registro" OnClick="RegistroProductoButton_Click" />
                            <asp:Button ID="ConsultaProductoButton" class="btn btn-primary" runat="server" Text="Consulta" OnClick="ConsultaProductoButton_Click" />
                        </div>
                        <div class="card-footer bg-primary"></div>
                    </div>
                </div>
            </div>
            <div class="col-12 col-md-4">
                <div class="form-group">
                    <div class="card">
                        <h4 class="card-header bg-secondary text-white">Factura</h4>
                        <div class="card-body">
                            <h4 class="card-title">Vista de Factura</h4>
                            <p class="card-text">En la vista de factura puedes encontrar el registro de factura donde realizaras las facturas y su consulta para filtrar las facturas guardadas.</p>
                            <asp:Button ID="RegistroFacturaButton" class="btn btn-secondary" runat="server" Text="Registro" OnClick="RegistroFacturaButton_Click" />
                            <asp:Button ID="ConsultaFacturaButton" class="btn btn-primary" runat="server" Text="Consulta" OnClick="ConsultaFacturaButton_Click" />
                        </div>
                        <div class="card-footer bg-primary"></div>
                    </div>
                </div>
            </div>
            <div class="col-12 col-md-4">
                <div class="form-group">
                    <div class="card">
                        <h4 class="card-header bg-secondary text-white">Clientes</h4>
                        <div class="card-body">
                            <h4 class="card-title">Vista de Clientes</h4>
                            <p class="card-text">En la vista de clientes puedes encontrar el registro de clientes donde guardas los clientes y su consulta para filtrar los clientes guardados.</p>
                            <asp:Button ID="RegistroClientesButton" class="btn btn-secondary" runat="server" Text="Registro" OnClick="RegistroClientesButton_Click" />
                            <asp:Button ID="ConsultaClientesButton" class="btn btn-primary" runat="server" Text="Consulta" OnClick="ConsultaClientesButton_Click" />
                        </div>
                        <div class="card-footer bg-primary"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
