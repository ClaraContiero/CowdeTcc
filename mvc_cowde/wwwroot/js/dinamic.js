//-- BARRA DE PROGRESSO --

//variáveis 
const barra = document.querySelectorAll(".barra-progresso")
const botao = document.querySelectorAll(".btn-progresso")

//evento
addEventListener("click", (e) => {

    e.preventDefault(
        subirValorBarra(e)
    )
});

const subirValorBarra = (e) => {
    const targetEl = e.target;

    for (let i = 0; i < 3; i++) {
        //ESTILIZAÇÃO DA PRIMEIRA BARRA
        if (contador === 1) {//se for o primeiro click no botão
            if (targetEl === botao[0]) {//se o elemento clicado for o primeiro botão
                barra[0].setAttribute("style", "--progresso: 33;");//muda a estilização da barra 
            }
        }
        if (contador == 2) {
            if (targetEl == botao[0]) {
                barra[0].setAttribute("style", "--progresso: 66;");
            }
        }
        if (contador == 3) {
            if (targetEl == botao[0]) {
                barra[0].setAttribute("style", "--progresso: 100;");
            }
        }

        //ESTILIZAÇÃO DA SEGUNDA BARRA
        if (contador === 4) {//se for o primeiro click no botão
            if (targetEl === botao[1]) {//se o elemento clicado for o primeiro botão
                barra[1].setAttribute("style", "--progresso: 33;");//muda a estilização da barra 
            }
        }
        if (contador == 5) {
            if (targetEl == botao[1]) {
                barra[1].setAttribute("style", "--progresso: 66;");
            }
        }
        if (contador == 6) {
            if (targetEl == botao[1]) {
                barra[1].setAttribute("style", "--progresso: 100;");
            }
        }

        //ESTILIZAÇÃO DA TERCEIRA BARRA
        if (contador === 7) {//se for o primeiro click no botão
            if (targetEl === botao[2]) {//se o elemento clicado for o primeiro botão
                barra[2].setAttribute("style", "--progresso: 33;");//muda a estilização da barra 
            }
        }
        if (contador == 8) {
            if (targetEl == botao[2]) {
                barra[2].setAttribute("style", "--progresso: 66;");
            }
        }
        if (contador == 9) {
            if (targetEl == botao[2]) {
                barra[2].setAttribute("style", "--progresso: 100;");
            }
        }

        //ESTILIZAÇÃO DA QUARTA BARRA
        if (contador === 10) {//se for o primeiro click no botão
            if (targetEl === botao[3]) {//se o elemento clicado for o primeiro botão
                barra[3].setAttribute("style", "--progresso: 33;");//muda a estilização da barra 
            }
        }
        if (contador == 11) {
            if (targetEl == botao[3]) {
                barra[3].setAttribute("style", "--progresso: 66;");
            }
        }
        if (contador == 12) {
            if (targetEl == botao[3]) {
                barra[3].setAttribute("style", "--progresso: 100;");
            }
        }
    }
}

//-- CONTADOR --
var contador = 0;
const label = document.querySelector(".but-progresso")

//Foi preciso usar um foreach, pois o querySelectorAll retorna um objeto do tipo
//NodeList e este objeto não possui o método addEventListener 
botao.forEach(elemento => {
    elemento.addEventListener("click", () => {
        incremento()
    })
});


const incremento = () => {
    if (botao) {
        ++contador;
    }
    console.log(contador)
}


//-- REDIRECIONAMENTO --

//introducoes
const linkIntroducao = document.querySelector(".link-introducao")
const linkIntroducao2 = document.querySelector(".link-introducao2")
const linkIntroducao3 = document.querySelector(".link-introducao3")
const linkIntroducao4 = document.querySelector(".link-introducao4")

//aulas
const linkAula = document.querySelector(".link-aula")
const linkAula2 = document.querySelector(".link-aula2")
const linkAula3 = document.querySelector(".link-aula3")
const linkAula4 = document.querySelector(".link-aula4")

//questionarios
const linkQuestionario = document.querySelector(".link-questionario")
const linkQuestionario2 = document.querySelector(".link-questionario2")
const linkQuestionario3 = document.querySelector(".link-questionario3")
const linkQuestionario4 = document.querySelector(".link-questionario4")

//outros
const linkPerfil = document.querySelector(".link-perfil")
const linkPerfil2 = document.querySelector(".link-perfil2")
const linkModulos = document.querySelector(".link-modulos")

//introduções
linkIntroducao.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarIntro()
    )
});

linkIntroducao2.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarIntro2()
    )
});

linkIntroducao3.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarIntro3()
    )
});

linkIntroducao4.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarIntro4()
    )
});



//aulas
linkAula.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarAula()
    )
});

linkAula2.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarAula2()
    )
});

linkAula3.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarAula3()
    )
});

linkAula4.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarAula4()
    )
});


//questionarios
linkQuestionario.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarQues()
    )
});

linkQuestionario2.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarQues2()
    )
});

linkQuestionario3.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarQues3()
    )
});

linkQuestionario4.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarQues4()
    )
});

//outros
linkPerfil.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarPerfil()
    )
});

linkPerfil2.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarPerfil2()
    )
});

linkModulos.addEventListener("click", (e) => {
    e.preventDefault(
        redirecionarModulos()
    )
});


//introducoes
const redirecionarIntro = () => {
    window.location.href = 'Introducao'
}

const redirecionarIntro2 = () => {
    window.location.href = 'Introducao2'
}

const redirecionarIntro3 = () => {
    window.location.href = 'Introducao3'
}

const redirecionarIntro4 = () => {
    window.location.href = 'Introducao4'
}


//aulas
const redirecionarAula = () => {
    window.location.href = 'Aula'
}

const redirecionarAula2 = () => {
    window.location.href = 'Aula2'
}

const redirecionarAula3 = () => {
    window.location.href = 'Aula3'
}

const redirecionarAula4 = () => {
    window.location.href = 'Aula4'
}


//questionarios
const redirecionarQues = () => {
    window.location.href = 'Questionario'
}

const redirecionarQues2 = () => {
    window.location.href = 'Questionario2'
}

const redirecionarQues3 = () => {
    window.location.href = 'Questionario3'
}

const redirecionarQues4 = () => {
    window.location.href = 'Questionario4'
}



//outros
const redirecionarPerfil = () => {
    window.location.href = 'Perfil'
}

const redirecionarPerfil2 = () => {
    window.location.href = 'Perfil'
}

const redirecionarModulos = () => {
    window.location.href = 'Modulos'
}


