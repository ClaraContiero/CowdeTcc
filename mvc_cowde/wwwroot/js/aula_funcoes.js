//Pop-UP
function popUp() {
    document.querySelector("#modal-colar").style.display = "flex";
    document.querySelector("#opacidade").style.opacity = "50%";
    document.querySelector("#opacidade").style.filter = "blur(5px)";
}

var text_aula = document.querySelectorAll("#texto-aula"); //esse for é para selecionar todos os elementos que possuem o mesmo id, logo, é necessário criar um ciclo (array)
for (var i = 0; i < text_aula.length; i++) {
    text_aula[i].addEventListener("copy", function (e) {
        e.preventDefault(
            popUp()
        );
    });
}

//Fechar Pop-UP

function fecharPopUp1() {
    var modal = document.querySelector("#modal-colar").style.display;

    if (modal = 'flex') {
        document.querySelector("#modal-colar").style.display = 'none';
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";
    }
}

function fecharPopUp2() {
    var modal = document.querySelector("#modal-colar").style.display;

    if (modal = 'flex') {
        document.querySelector("#modal-colar").style.display = 'none';
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";
    }
}

function fecharPopUp3() {
    var modal = document.querySelector("#modal-colar").style.display;

    if (modal = 'flex') {
        document.querySelector("#modal-colar").style.display = 'none';
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";
    }
}

function fecharPopUp4() {
    var modal = document.querySelector("#modal-colar").style.display;

    if (modal = 'flex') {
        document.querySelector("#modal-colar").style.display = 'none';
        document.querySelector("#opacidade").style.opacity = "100%";
        document.querySelector("#opacidade").style.filter = "blur(0px)";
    }
}


//Avançar e voltar

function avancar_conteudo1() {
    var display = document.querySelector("#aula-pt1").style.display;

    if (display = 'flex') {
        document.querySelector("#aula-pt1").style.display = 'none';
        document.querySelector("#aula-pt2").style.display = 'flex';
        document.querySelector("#aula-pt3").style.display = 'none';
    }
}

function avancar_conteudo2() {
    var display = document.querySelector("#aula-pt2").style.display;

    if (display = 'flex') {
        document.querySelector("#aula-pt1").style.display = 'none';
        document.querySelector("#aula-pt2").style.display = 'none';
        document.querySelector("#aula-pt3").style.display = 'flex';
    }
}


function voltar_conteudo1() {
    var display = document.querySelector("#aula-pt2").style.display;

    if (display = 'flex') {
        document.querySelector("#aula-pt1").style.display = 'flex';
        document.querySelector("#aula-pt2").style.display = 'none';
        document.querySelector("#aula-pt3").style.display = 'none';
    }
}


function voltar_conteudo2() {
    var display = document.querySelector("#aula-pt3").style.display;

    if (display = 'flex') {
        document.querySelector("#aula-pt1").style.display = 'none';
        document.querySelector("#aula-pt2").style.display = 'flex';
        document.querySelector("#aula-pt3").style.display = 'none';
    }
}



