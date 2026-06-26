function iniciarImportar(inputId, formId) {
    const input = document.getElementById(inputId);
    const form = document.getElementById(formId);

    if (input && form) {
        input.addEventListener("change", function () {
            if (this.files.length > 0) {
                form.submit();
            }
        });
    }
}