<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GimnacioTechWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta lang="es-ES" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="Description" content="RD-GYM" />
    <meta name="author" content="Raidy Duran Garcia" />
    <link rel="icon" href="../favicon.ico" />

    <!--Inclusión de Bootstrap-->
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <!--Inclusión de JQuery-->
    <script src="../../Scripts/jquery-3.2.1.min.js"></script>

    <!--Inclusión de poppers-->
    <script src="../../Scripts/popper.min.js"></script>

    <!--Inclusión de Bootstrap Js-->
    <script src="../../Scripts/bootstrap.min.js"></script>

    <!--Inclusión de scripts Personales-->
    <script src="../../Scripts/MyScripts.js"></script>

    <!--Inclusión de CSS toast-->
    <link href="../../Content/toastr.css" rel="stylesheet" />

    <!--Inclusión de Style Sheet Personal-->
    <link rel="stylesheet" href="../../CSS/MyStyles.css" />

    <!--Inclusión de JS toast-->
    <script src="../../Scripts/toastr.js"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Inicio de sesion</title>
</head>
<body>
    <div class="container">
        <div class="jumbotron jumbotron-fluid bg-secondary">
            <div class="container">
                <h1 class="display-3 text-white">RD-GYM</h1>
                <p class="lead text-white">Nunca pares, nunca te conformes, hasta que lo bueno sea mejor y lo mejor excelente.</p>
            </div>
        </div>
    </div>

    <div class="text-center">
        <div class="page-header col-12">
            <h1>Inicio de sesion</h1>
            <br />
        </div>
    </div>
    <div class=" container-fluid">
        <div class="text-center">
            <form id="Loginform" runat="server">
                <div class="row">
                    <div class="col-12 col-sm-2 col-md-3 col-lg-4">
                    </div>
                    <div class="col-12 col-sm-8 col-md-6 col-lg-4">
                        <div class="form-group">
                            <asp:Label ID="NombreUsuarioLabel" runat="server" Text="Nombre Usuario"></asp:Label>
                            <asp:TextBox CssClass="form-control text-center" ID="NombreUsuarioTextBox" runat="server" AutoComplete="off"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="ClaveLabel" runat="server" Text="Clave"></asp:Label>
                            <asp:TextBox CssClass="form-control text-center" type="password" ID="ClaveTextBox" runat="server" AutoComplete="off"></asp:TextBox>
                        </div>

                        <div class="text-center">
                            <asp:Button ID="LoginButton" runat="server" CssClass="btn btn-primary" Text="Iniciar sesion" OnClick="LoginButton_Click" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
