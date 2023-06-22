function mudar() {
    document.querySelector("#perfil").style.display = "none";
    document.querySelector("#perfil-update").style.display = "flex";
    document.querySelector("#avatares").style.display = "flex";
}

function mudarAvatar() {
    var display = document.querySelector("#avatarzinho").style.display;

    if (display = "none") {
        document.querySelector("#avatarzinho").style.display = "flex";
    }

}