let ubicacionPrincipal = window.pageYOffset;
window.onscroll = function () {
    let Desplazamiento_Actual = window.pageYOffset;
    if (ubicacionPrincipal >= Desplazamiento_Actual) {
        $("#menu").show();
    }
    else {
        $("#menu").hide();
    }
    ubicacionPrincipal = Desplazamiento_Actual;
}