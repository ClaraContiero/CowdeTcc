function somenteNumeros(e){
    var charCode = e.charCode ? e.charCode : e.keyCode;
    
    if (charCode != 8 && charCode != 9) {
        if (charCode < 48 || charCode > 57) {
            return false;
        }
    }
    }
    
    function somenteLetras(e) {
    
        if (window.event) {
            var charCode = Window.event.keyCode;
        } else if (e) {
            var charCode = e.which;
        } else {
            return true;
        }
    
        if ((charCode > 64 && charCode << 91) || (charCode > 96 && charCode < 123)) {
           return true;
        } else {
            return false;
        }
    
    }
    