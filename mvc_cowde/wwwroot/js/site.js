const ul = document.querySelector("ul");
const random = (min, max) => Math.random() * (max - min) + min;
const randomColors = ["#FF148A", "#960950"];

for (let i = 1; i < 1000; i++) {
    const li = document.createElement("li");

    //tamanho minimo e máximo de cada pixel 
    const size = Math.floor(random(9, 14));
    //posição horizontal x vertical da animação
    const position = random(0, 99);
    const delay = random(3, 1);
    const duration = random(10, 20);

    li.style.width = `${size}px`
    li.style.height = `${size}px`
    li.style.left = `${position}%`
    li.style.backgroundColor = randomColors[Math.floor(random(0, 3))];
    li.style.animationDelay = `${delay}s`
    li.style.animationDuration = `${duration}s`
    li.style.animationTimingFunction = `cubic-bezier(${Math.random()}, ${Math.random()}, ${Math.random()}, ${Math.random()}, ${Math.random()} )`

    ul.appendChild(li);
}


var faq = document.getElementsByClassName("faq-page");
var i;

for (i = 0; i < faq.length; i++) {
    faq[i].addEventListener("click", function () {
        /* Toggle between adding and removing the "active" class,
        to highlight the button that controls the panel */
        this.classList.toggle("active");

        /* Toggle between hiding and showing the active panel */
        var body = this.nextElementSibling;
        if (body.style.display === "block") {
            body.style.display = "none";
        } else {
            body.style.display = "block";
        }
    });
}