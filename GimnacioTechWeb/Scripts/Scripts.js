function showModal() {
    $("#ModalEliminar").modal('show');
}

$(function () {
    $("#EnviarAlModal").click(function () {
        showModal();
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

