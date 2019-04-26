(function (cibertec) {
    cibertec.index = {
        currentYear: function () {
            var hoy = new Date();
            return hoy.getFullYear();
        }
    };
    document.getElementById("date").innerHTML =
        cibertec.index.currentYear();
})(window.cibertec = window.cibertec || {});//Si es nulo la primera vez
