const canvas = document.getElementById('confetti')
let numSorteado;
let score = 100;
let highScore = localStorage.getItem("highScore") || 0;
const jsConfetti = new JSConfetti()

function SortearNumero() {
    return Math.floor(Math.random() * 10) + 1; 
}

function GenerarMensaje() {
    return "Adivina un número del 1 al 100.";
}
function GenerarPista(numIngresado) {
    if (numIngresado === "") {
        return "Por favor, ingresa un número.";
    }   
    const numero = parseInt(numIngresado, 10); 
    if (isNaN(numero)) {
        return "Ingresa un número.";
    }
    if (numero === numSorteado) {
        return "¡Adivinaste!";
    } else if (numero > numSorteado) {
        return "Muy alto.";
    } else {
        return "Muy bajo.";
    }
}

function DescontarPuntos(score) {
    score -= 5;
    return score < 0 ? 0 : score; 
}


function MostrarResultado(mensaje, finalizado = false) {
    const resultadoDiv = document.querySelector("#resultado");
    resultadoDiv.textContent = mensaje;
    if (finalizado) {
        resultadoDiv.style.color = "green"; // Cambia el color de resultado en caso de adivinar
    } else {
        resultadoDiv.style.color = "red"; // Cambia el color de resultado si no se adivina
    }
}

function IniciarJuego() {
    numSorteado = SortearNumero();
    document.querySelector("#score").textContent = score;
    document.querySelector("#highScore").textContent = highScore;
    document.querySelector("#mensaje").textContent = GenerarMensaje();
}

function AsignarNuevoScore(pista) {
    if (pista !== "¡Adivinaste!") {
        let scoreActualizado = DescontarPuntos(score);
        score = scoreActualizado;
        document.querySelector("#score").textContent = scoreActualizado;
    } else {
        if (score > highScore) {
            highScore = score;
            localStorage.setItem("highScore", highScore); 
            document.querySelector("#highScore").textContent = highScore; 
        }
    }
    
}

function NuevoJuego() {
    numSorteado = SortearNumero();
    score = 100;
    document.querySelector("#score").textContent = score;
    document.querySelector("#resultado").textContent = "";
    document.querySelector("#numIngresado").value = "";
    document.querySelector("#mensaje").textContent = GenerarMensaje();
}

// Evento para presionar Enter en lugar de hacer clic en el botón
document.querySelector("#numIngresado").addEventListener("keyup", function(event) {
    if (event.key === "Enter") {
        document.querySelector("#btnEnviar").click();
    }
});


document.querySelector("#btnEnviar").onclick = () => {
    let numIngresado = document.querySelector("#numIngresado").value;
    let pista = GenerarPista(numIngresado);
    AsignarNuevoScore(pista);
    MostrarResultado(pista, pista === "¡Adivinaste!");
    document.querySelector("#scores").style.visibility = "visible";

    if (pista === "¡Adivinaste!") {
        jsConfetti.addConfetti()
    }

    document.querySelector("#numIngresado").value = "";
};

document.querySelector("#btnReiniciar").onclick = () => {
    NuevoJuego();
};

window.addEventListener("load", () => {
    IniciarJuego();
});
