function respostaCerta(respCerta) {
    //alternativa correta
    document.querySelector("#respCerta").style.background = "#8aeb27"
    document.querySelector("#respCerta").style.border = "2px solid white"
    document.querySelector("#respCerta").style.color = "#06002e"

    //alternativas erradas depois de acertar as respostas
    document.querySelector("#resp1").style.background = "#5b0c9c";
    document.querySelector("#resp2").style.background = "#5b0c9c";
    document.querySelector("#resp3").style.background = "#5b0c9c";

    document.querySelector("#resp1").style.border = "2px solid white";
    document.querySelector("#resp2").style.border = "2px solid white";
    document.querySelector("#resp3").style.border = "2px solid white";

    document.querySelector("#resp1").style.color = "#7925bd";
    document.querySelector("#resp2").style.color = "#7925bd";
    document.querySelector("#resp3").style.color = "#7925bd";

    resp1.removeAttribute("onClick");
    resp2.removeAttribute("onClick");
    resp3.removeAttribute("onClick");

    popUpCerto()
}

function respostaErrada1(resp1) {
    //alternativa errada
    document.querySelector("#resp1").style.background = "red"
    document.querySelector("#resp1").style.border = "2px solid white"
    document.querySelector("#resp1").style.color = "#06002e"

    //alternativa certa
    document.querySelector("#respCerta").style.background = "#8aeb27"
    document.querySelector("#respCerta").style.border = "2px solid white"
    document.querySelector("#respCerta").style.color = "#06002e"

    //as demais alternativas erradas
    document.querySelector("#resp2").style.background = "#5b0c9c";
    document.querySelector("#resp3").style.background = "#5b0c9c";
    document.querySelector("#resp2").style.border = "2px solid white";
    document.querySelector("#resp3").style.border = "2px solid white";
    document.querySelector("#resp2").style.color = "#7925bd";
    document.querySelector("#resp3").style.color = "#7925bd";

    respCerta.removeAttribute("onClick");
    resp2.removeAttribute("onClick");
    resp3.removeAttribute("onClick");

    popUpErrado()
}

function respostaErrada2(resp2) {
    //alternativa errada
    document.querySelector("#resp2").style.background = "red"
    document.querySelector("#resp2").style.border = "2px solid white"
    document.querySelector("#resp2").style.color = "#06002e"

    //alternativa certa
    document.querySelector("#respCerta").style.background = "#8aeb27"
    document.querySelector("#respCerta").style.border = "2px solid white"
    document.querySelector("#respCerta").style.color = "#06002e"

    //as demais alternativas erradas
    document.querySelector("#resp1").style.background = "#5b0c9c";
    document.querySelector("#resp3").style.background = "#5b0c9c";
    document.querySelector("#resp1").style.border = "2px solid white";
    document.querySelector("#resp3").style.border = "2px solid white";
    document.querySelector("#resp1").style.color = "#7925bd";
    document.querySelector("#resp3").style.color = "#7925bd";

    respCerta.removeAttribute("onClick");
    resp1.removeAttribute("onClick");
    resp3.removeAttribute("onClick");

    popUpErrado()
}

function respostaErrada3(resp3) {
    //alternativa errada
    document.querySelector("#resp3").style.background = "red"
    document.querySelector("#resp3").style.border = "2px solid white"
    document.querySelector("#resp3").style.color = "#06002e"


    //alternativa certa
    document.querySelector("#respCerta").style.background = "#8aeb27"
    document.querySelector("#respCerta").style.border = "2px solid white"
    document.querySelector("#respCerta").style.color = "#06002e"

    //as demais alternativas erradas
    document.querySelector("#resp1").style.background = "#5b0c9c";
    document.querySelector("#resp2").style.background = "#5b0c9c";
    document.querySelector("#resp1").style.border = "2px solid white";
    document.querySelector("#resp2").style.border = "2px solid white";
    document.querySelector("#resp1").style.color = "#7925bd";
    document.querySelector("#resp2").style.color = "#7925bd";

    respCerta.removeAttribute("onClick");
    resp1.removeAttribute("onClick");
    resp2.removeAttribute("onClick");

    popUpErrado()
}

function popUpCerto() {
    document.querySelector("#modalCerto").style.display = "flex";
    document.querySelector("#opacidade").style.opacity = "50%";
    document.querySelector("#opacidade").style.filter = "blur(5px)";
}

function popUpErrado() {
    document.querySelector("#modalErrado").style.display = "flex";
    document.querySelector("#opacidade").style.opacity = "50%";
    document.querySelector("#opacidade").style.filter = "blur(5px)";
}

function fecharPopUp() {
    var display = document.querySelector("#modalCerto").style.display;
    var display2 = document.querySelector("#modalErrado").style.display;


    if (display = "flex") {
        document.querySelector("#modalCerto").style.display = "none";
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";

        if (display2 = "flex") {
            document.querySelector("#modalErrado").style.display = "none";
            document.querySelector("#opacidade").style.opacity = "100%";
            document.querySelector("#opacidade").style.filter = "blur(0px)";

        }
    }
} 
