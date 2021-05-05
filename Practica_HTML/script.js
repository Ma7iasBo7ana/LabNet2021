document.getElementById("Boton1").addEventListener("click", function () {
    document.getElementById("fname").value = "";
    document.getElementById("lname").value = "";
    document.getElementById("age").value = "";
    document.getElementById("empresa").value = "";
});

var error = document.getElementById('error');
var nombre = document.getElementById('fname');
var Apellido = document.getElementById('lname');


document.getElementById("submit").addEventListener("click", function () {


    var mensajesError = [];

    if (nombre.value === null || nombre.value === '') {
        mensajesError.push("Debe Ingresar su nombre");
        

    }
    if (Apellido.value === null || Apellido.value === '') {
        mensajesError.push("Debe ingresar su apellido");
    }


    error.innerHTML = mensajesError.join(', ');
    return false   



});
