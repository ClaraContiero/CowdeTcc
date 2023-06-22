function ajuda() {
    document.querySelector("#modal").style.display = "flex";
    document.querySelector("#opacidade").style.opacity = "50%";
    document.querySelector("#opacidade").style.filter = "blur(5px)";
    document.querySelector("#but-ajuda").style.display = "none";

}

function fecharPopUp() {
    var modal = document.querySelector("#modal").style.display;
    document.querySelector("#but-ajuda").style.display = "flex";


    if (modal = 'flex') {
        document.querySelector("#modal").style.display = "none";
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";
    }
}