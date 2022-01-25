// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function aumentarCantProducto(id) {
    var cantidad = parseInt(document.getElementById(id).value);
    cantidad++;
    document.getElementById(id).value = cantidad
}

function disminuirCantProducto(id) {
    var cantidad = parseInt(document.getElementById(id).value);

    if (cantidad > 1) {
        cantidad--;
        document.getElementById(id).value = cantidad
    }

}