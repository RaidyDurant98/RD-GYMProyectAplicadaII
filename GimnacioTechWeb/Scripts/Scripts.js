/*Modal Eliminar*/
function showModalEliminar() {
    $("#ModalEliminar").modal('show');
}

$(function () {
    $("#EnviarAlModalEliminar").click(function () {
        showModalEliminar();
    });
});

/*Modal Modificar*/
function showModalModificar() {
    $("#ModalModificar").modal('show');
}

$(function () {
    $("#EnviarAlModalModificar").click(function () {
        showModalModificar();
    });
});

/*var statSend = false;
$(function RegistroGuardado() {
    if (!statSend) {
        statSend = true;
        return true;
    } else {
        alert("El formulario ya se esta enviando...");
        return false;
    }
});*/

