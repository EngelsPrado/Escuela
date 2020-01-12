// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#modalAC').on('shown.bs.modal', function () {
    $('#Nombre').focus();
});

$().ready(() => {
    document.getElementById("filtrar").focus();
    filtrarDatos(1,"nombre");
});

var idCategoria; 
var funcion=0;

var agregarCategoria = () => {
   
    var nombre = document.getElementById("Nombre").value;
    var descripcion = document.getElementById("Descripcion").value;
    var estados = document.getElementById('Estado');
    var estado = estados.options[estados.selectedIndex].value;

    if (funcion == 0) {
        var action = 'Categorias/guardarCategoria';
    } else {
        var action = 'Categorias/editarCategoria';
    }

  
    var categoria = new Categorias(nombre, descripcion, estado, action);
    categoria.agregarCategoria(idCategoria, funcion);
    
}

var filtrarDatos = (numPagina,order) => {
    var valor = document.getElementById("filtrar").value;
    var action = 'Categorias/filtrarDatos';
    var categoria = new Categorias(valor, "", "", action);
    categoria.filtrarDatos(numPagina,order);
}

var editarEstado = (id,fun) => {
    console.log("editar"+id)
    idCategoria = id;
    funcion = fun;
    var action = 'Categorias/getCategorias';
    var categoria = new Categorias("", "", "", action);
    categoria.qetCategoria(id,funcion);
}

var editarCategoria = () => {
    var action = 'Categorias/editarCategoria';
    var categoria = new Categorias("", "", "", action);
    categoria.editarCategoria(idCategoria, funcion);
}