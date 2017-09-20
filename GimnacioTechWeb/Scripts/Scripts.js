function showModal() {
    $("#ModalEliminar").modal('show');
}

$(function () {
    $("#EnviarAlModal").click(function () {
        showModal();
    });
});