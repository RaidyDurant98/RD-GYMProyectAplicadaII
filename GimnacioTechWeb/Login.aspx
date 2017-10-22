<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GimnacioTechWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusión de Bootstrap 4.0.0-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"></script>

    <!--Inclusión de scripts Personales-->
    <script src="../../Scripts/Scripts.js"></script>

    <!--Inclusión de Style Sheet Personal-->
    <link rel="stylesheet" href="../../CSS/MyStyles.css" />

    <title>Login</title>
</head>
<body>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container">
        <form id="Loginform" runat="server">
            <div class="card border-secondary mb-3" style="max-width: 30rem;">
                <div class="card-header">LOGIN</div>
                <div class="card-body text-secondary">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Nombre Usuario"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="NombreUsuarioTextBox" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="ClaveTextBox" runat="server"></asp:TextBox>
                    </div>

                    <div class="text-center">
                        <asp:Button ID="LoginButton" runat="server" CssClass="btn btn-secondary" Text="Login" OnClick="LoginButton_Click" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
