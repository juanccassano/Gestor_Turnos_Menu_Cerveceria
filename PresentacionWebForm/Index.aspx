<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PresentacionWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Reserva mesas</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</head>
<body>
    <style>
        .body-content {
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
    <%  %>
    <h1>Formulario para reservas</h1>


    <form id="form1" runat="server">
        <div>
            <h2>Datos reserva:</h2>
        </div>
        <asp:Label ID="lblNombreApellido" runat="server" Text="Nombre y apellido: "></asp:Label>
        <asp:TextBox ID="txtNombreApellido" runat="server"></asp:TextBox>
        <div>
        <asp:Label ID="lblCantidadPersonas" runat="server" Text="Cantidad de personas: "></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
        <asp:Calendar ID="cldFechaHora" runat="server"></asp:Calendar>
        </div>
        <div>
        <asp:Label ID="lblHora" runat="server" Text="Hora: "></asp:Label>
        <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
        </div>

    </form>

    <button id="btnAceptar" onclick="aceptar()">Aceptar</button>
    <button id="btnCancelar" onclick="cancelar()">Cancelar</button>
</body>
</html>
