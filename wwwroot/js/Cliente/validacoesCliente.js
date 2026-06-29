
function validarCPF() {
    var inputCpf = document.getElementById("CpfCnpj");
    if (!inputCpf || !inputCpf.value) return false;

    var cpf = inputCpf.value.replace(/[^\d]+/g, '');

    if (cpf.length !== 11) return false;

    var digitoMultiplicador = 10;
    var soma = 0;
    var digitoVerificador1 = 0;

    cpf.split('').forEach(function (digito) {
        if (digitoMultiplicador >= 2) {
            soma += parseInt(digito) * digitoMultiplicador;
            digitoMultiplicador--;
        }
    });

    if (soma % 11 < 2) {
        digitoVerificador1 = 0;
    } else {
        var valorResto = soma % 11;
        digitoVerificador1 = 11 - valorResto;
    }

    digitoMultiplicador = 11;
    soma = 0;

    cpf.split('').forEach(function (digito) {
        if (digitoMultiplicador >= 2) {
            soma += parseInt(digito) * digitoMultiplicador;
            digitoMultiplicador--;
        }
    });

    var digitoVerificador2 = 0;
    if (soma % 11 < 2) {
        digitoVerificador2 = 0;
    } else {
        var valorResto = soma % 11;
        digitoVerificador2 = 11 - valorResto;
    }

    return digitoVerificador1 === parseInt(cpf[9]) && digitoVerificador2 === parseInt(cpf[10]);
}

function validarNome() {
    var inputNome = document.getElementById("NomeClienteCadastro");
    if (!inputNome || !inputNome.value.trim()) return false;

    var Nome = inputNome.value;

    // Sua regex excelente de proteção contra números e caracteres suspeitos
    const caracteresInvalidos = /\d|&&|\|\||;|--|'|"/;
    var possuiInvalido = caracteresInvalidos.test(Nome);

    return !possuiInvalido; // Retorna true se NÃO possuir inválidos
}

function validarTelefone(telefone) {
    if (!telefone) return false;
    const numeroLimpo = telefone.replace(/\D/g, '');
    const regexValidador = /^[1-9]{2}9?[1-9]\d{7}$/;

    return regexValidador.test(numeroLimpo);
}

function validarEmail(email) {
    if (!email) return false;
    const emailLimpo = email.trim().toLowerCase();
    const regexValidador = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    return regexValidador.test(emailLimpo);
}


function atualizarFormulario() {

    var inputCpf = document.getElementById("CpfCnpj");
    var inputNome = document.getElementById("NomeClienteCadastro");
    var inputTelefone = document.getElementById("Telefone");
    var inputEmail = document.getElementById("Email");

    var formulario = document.getElementById("FormularioCliente");
    var botaoSubmit = formulario.querySelector("button[type='submit']");

    var cpfValido = validarCPF();
    var nomeValido = validarNome();
    var telefoneValido = validarTelefone(inputTelefone.value);
    var emailValido = validarEmail(inputEmail.value);

    aplicarEstiloCampo(inputCpf, cpfValido);
    aplicarEstiloCampo(inputNome, nomeValido);
    aplicarEstiloCampo(inputTelefone, telefoneValido);
    aplicarEstiloCampo(inputEmail, emailValido);

    if (cpfValido && nomeValido && telefoneValido && emailValido) {
        botaoSubmit.removeAttribute("disabled");
    } else {
        botaoSubmit.setAttribute("disabled", "disabled");
    }
}

function aplicarEstiloCampo(elemento, campoValido) {
    if (!elemento) return;

    if (campoValido) {
        elemento.classList.add("is-valid");
        elemento.classList.remove("is-invalid");
        elemento.style.borderColor = "#198754"; // Verde Bootstrap
    } else {
        elemento.classList.add("is-invalid");
        elemento.classList.remove("is-valid");
        elemento.style.borderColor = "#dc3545"; // Vermelho Bootstrap
    }
}