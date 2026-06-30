function validarCPF(form) {
    var inputCpf = form.querySelector(".campo-cpf-cnpj");
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

//Função validarCNPJ possui compatibilidade com valores alfanumericos.
function validarCNPJ(form) {
    var inputCPNJ = form.querySelector(".campo-cpf-cnpj");
    if (!inputCPNJ) return false;

    var cnpj = inputCPNJ.value.toString().toUpperCase().replace(/[^A-Z0-9]/g, '');

    if (cnpj.length !== 14) return false;

    if (!/^[A-Z0-9]{12}[0-9]{2}$/.test(cnpj)) return false;

    if (cnpj === "00000000000000") return false;

    const pesos = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
    let somaDV1 = 0;
    let somaDV2 = 0;

    for (let i = 0; i < 12; i++) {
        const valorCaractere = cnpj.charCodeAt(i) - 48;
        somaDV1 += valorCaractere * pesos[i + 1];
        somaDV2 += valorCaractere * pesos[i];
    }

    const dv1 = (somaDV1 % 11) < 2 ? 0 : 11 - (somaDV1 % 11);
    somaDV2 += dv1 * pesos[12];

    const dv2 = (somaDV2 % 11) < 2 ? 0 : 11 - (somaDV2 % 11);
    const dvCalculado = `${dv1}${dv2}`;

    return cnpj.slice(-2) === dvCalculado;
}

function validarNome(form) {
    var inputNome = form.querySelector(".campo-nome");
    if (!inputNome || !inputNome.value.trim()) return false;

    if (inputNome.value.trim().length <= 1) return false;

    var Nome = inputNome.value;


    const caracteresInvalidos = /\d|&&|\|\||;|--|'|"/;
    var possuiInvalido = caracteresInvalidos.test(Nome);

    return !possuiInvalido;
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



function atualizarFormulario(form) {

    var inputCpf = form.querySelector(".campo-cpf-cnpj");
    var inputNome = form.querySelector(".campo-nome");
    var inputTelefone = form.querySelector(".campo-telefone");
    var inputEmail = form.querySelector(".campo-email");

    var formulario = form;
    var botaoSubmit = formulario.querySelector("button[type='submit']");

    var cpfValido = false;

    var valorLimpo = inputCpf.value.replace(/[^A-Z0-9]/gi, '').trim();

    if (valorLimpo.length === 11) {
        cpfValido = validarCPF(form);
    } else if (valorLimpo.length === 14) {
        cpfValido = validarCNPJ(form);
    }
    var nomeValido = validarNome(form);
    var telefoneValido = validarTelefone(inputTelefone.value);
    var emailValido = validarEmail(inputEmail.value);

    if (inputCpf.value.trim() != "") aplicarEstiloCampo(inputCpf, cpfValido);
    if (inputNome.value.trim() != "") aplicarEstiloCampo(inputNome, nomeValido);
    if (inputTelefone.value.trim() != "") aplicarEstiloCampo(inputTelefone, telefoneValido);
    if (inputEmail.value.trim() != "") aplicarEstiloCampo(inputEmail, emailValido);

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