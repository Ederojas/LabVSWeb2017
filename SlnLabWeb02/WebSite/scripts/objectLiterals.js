var miModulo = {
    miPropiedad: "Valor0",
    miConfiguracion: {
        usaEspanol: true,
        usaMarcara: false,
    },
    miMetodo1: function () {
        console.log("miMetodo1");
    },
    miMetodo2: function () {
        console.log("La mascara esta " + (this.miConfiguracion.usaMarcara) ? 'Habilitada' : 'Deshabilitada');
    },
    miMetodo3: function (configuracion) {
        if (typeof configuracion == 'object') {
            this.miConfiguracion = configuracion;
            console.log(this.miConfiguracion.usaEspanol);
        }
    }
};
console.log(miModulo.miPropiedad);
miModulo.miMetodo1();