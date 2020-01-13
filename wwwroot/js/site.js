// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#modalAC').on('shown.bs.modal', function () {
    $('#Nombre').focus();
});

$().ready(() => {
    var URLactual = window.location;
    document.getElementById("filtrar").focus();
    switch (URLactual.pathname) {
        case "/Categorias":
            filtrarDatos(1, "nombre");
            break;
        case "/Cursos":
            getCategorias(0, 0);

            filtrarCurso(1, "nombre");
            break;
    }
});

$('#modalCS').on('shown.bs.modal', function () {
    $('#Nombre').focus();
});

var idCategoria; 
var funcion=0;
var idCurso;


//Categorias



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


//Codigo Cursos


var getCategorias = (id,fun) => {

    var action = 'Cursos/getCategorias'
    var cursos = new Cursos("", "", "", "", "", "", "", action)
    cursos.getCategorias(id,fun)
}


var agregarCurso = () => {

    if (funcion == 0) {
        var action = 'Cursos/agregarCurso';
    } else {
        var action = 'Cursos/editarCurso';
    }

    var nombre = document.getElementById("Nombre").value;
    var descripcion = document.getElementById("Descripcion").value;
    var creditos = document.getElementById("Creditos").value;
    var horas = document.getElementById("Horas").value;
    var costo = document.getElementById("Costo").value;
    var estado = document.getElementById("Estado").checked
    var categorias = document.getElementById('CategoriaCursos');
    var categoria = categorias.options[categorias.selectedIndex].value;
    console.log(idCurso)
    var cursos = new Cursos(nombre, descripcion, creditos, horas, costo, estado, categoria, action);
    cursos.agregarCurso(idCurso, funcion);
    funcion = 0;
}


var filtrarCurso = (numPagina, order) => {
    var valor = document.getElementById("filtrar").value;
    var action = 'Cursos/filtrarCurso';
    var cursos = new Cursos(valor, "", "", "", "", "", "", action);
    cursos.filtrarCurso(numPagina, order);
}



var editarEstadoCurso = (id, fun) => {
    funcion = fun;
    idCurso = id;
    var action = 'Cursos/getCursos';
    var cursos = new Cursos("", "", "", "", "", "", "", action);
    cursos.getCursos(id, fun);
}

var editarEstadoCurso1 = () => {
    var action = 'Cursos/editarCurso';
    var cursos = new Cursos("", "", "", "", "", "", "", action);
    cursos.editarEstadoCurso(idCurso, funcion);
}

var restablecer = () => {
    var cursos = new Cursos("", "", "", "", "", "", "", "");
    cursos.restablecer();
}