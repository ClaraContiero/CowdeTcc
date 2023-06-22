//Chamar elementos
const consoleLogList = document.querySelector(".editor__console-logs");
const executeCodeBtn = document.querySelector(".editor__run");
const resetCodeBtn = document.querySelector(".editor__reset");

//Setup do Ace
let codeEditor = ace.edit("editorCode");
let defaultCode = "";
let consoleMessages = [];

let editorLib = {
    clearConsoleScreen() {
        consoleMessages.length = 0;

        //Remove todos os elementos na lista log
        while (consoleLogList.firstChild) {
            consoleLogList.removeChild(consoleLogList.firstChild);
        }
    },

    printToConsole() {
        consoleMessages.forEach((log) => {
            const newLogItem = document.createElement("li");
            const newLogText = document.createElement("pre");

            newLogText.className = log.class;
            newLogText.textContent = `${log.message}`;

            newLogItem.appendChild(newLogText);

            consoleLogList.appendChild(newLogItem);
        });
    },

    init() {
        //Configurando o Ace

        //Tema
        codeEditor.setTheme("ace/theme/xcode");

        //Definir linguagem
        codeEditor.session.setMode("ace/mode/javascript");

        //Definir opções
        codeEditor.setOptions({
            fontFamily: "Courier Prime",
            fontSize: "13pt",
            enableBasicAutocompletion: true,
            enableLiveAutocompletion: true,
        });

        //Definir os parâmetros
        codeEditor.setValue(defaultCode);
    },
};

//Eventos dos botões
executeCodeBtn.addEventListener("click", () => {
    //Limpar o console
    editorLib.clearConsoleScreen();
    //Pegando os valores no editor
    const userCode = codeEditor.getValue();

    //Executar o código
    try {
        new Function(userCode)();
    } catch (err) {
        console.error(err);
    }

    //Para aparecer no console
    editorLib.printToConsole();
});

resetCodeBtn.addEventListener("click", () => {
    //Limpando o editor
    codeEditor.setValue(defaultCode);

    //Limpar o console
    editorLib.clearConsoleScreen();
});

editorLib.init();
