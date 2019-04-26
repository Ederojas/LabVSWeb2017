var igv = 18;
var igv2 = "18";

console.log(igv);
console.log(igv2);
console.log(igv == igv);
console.log(igv === igv2);


var dias = ["Lunes", "Martes", , "Miercoles"];
console.log(dias[1]);//martes
console.log(dias[5]);//error

var verdad = true;
console.log(verdad);

var fecha = new Date();
var fecha2 = new Date("8/29/2019");
console.log(fecha);
console.log(fecha2);

var visible = true;
var cantidad = 0;//false
var cantidad2 = 3;//>0 true
var mensaje = "";//false
var mensaje2 = "ejemplo";//true
console.log(!visible);
console.log(!cantidad);
console.log(!cantidad2);
console.log(!mensaje);
console.log(!mensaje2);

//if
var edad = 10;
if (edad < 12) {
    console.log("eres pequeño");
} else if (edad < 19) {
    console.log("eres adolescente");
} else if (edad < 35) {
    console.log("eres joven");
} else {
    console.log("a cuidarse");
}

//switch
var diasemana = 3
switch (diasemana) {
    case 1:
        console.log("Lunes");
        break;
    case 2:
        console.log("Martes")
        break;
    default:
        console.log("es Otro dia")
}

//for 
for (var i = 0; i < 5; i++) {
    console.log(i);
}

//while
var count = 0;
while (count < 5) {
    console.log(count);
    count++;
}

//do while
count = 0;
do {
    console.log(count);
    count++;
}
while (count < 5);

//for echa for in
for (i in dias) {
    console.log(dias[i]);
}

//Objetos
var miAuto = new Object();
miAuto.marca = "Toyota";
miAuto.modelo = "Yaris";
miAuto["fabricacion"] = 2011;

console.log(miAuto.marca);
console.log(miAuto["modelo"]);
console.log(miAuto.fabricacion);

var miHonda = { color: "rojo", ruedas: 4, motor: { cilindros: 4, tamanio: 2 } };

//métodos
var miObjeto = new Object();
miObjeto.miMetodo = function () {
    console.log("Hola miMetodo");
}
miObjeto.miMetodo;

var miObjeto2 = {
    miMetodo2: function (parametro) {
        console.log("Hola miMetodo2:" + parametro);
    }
}
miObjeto2.miMetodo2("miparam");

//Eliminar Propiedad de miAuto
delete miAuto.marca;
console.log(miAuto.marca);//undefined
console.log("marca" in miAuto);//false