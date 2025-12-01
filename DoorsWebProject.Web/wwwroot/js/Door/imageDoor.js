document.addEventListener("DOMContentLoaded", () => {

    // Променяш селектора към твоя елемент!
    // Например: const imgInput = document.querySelector("#doorImage");
    const imgInput = document.querySelector("#doorImage");

    if (!imgInput) {
        console.warn("imageDoor.js: #doorImage не е намерен в DOM");
        return; // спираме, без да хвърля грешка
    }

    imgInput.addEventListener("change", function () {
        const file = this.files?.[0];
        if (!file) return;

        const reader = new FileReader();

        reader.onload = function (e) {
            const preview = document.querySelector("#doorImagePreview");
            if (!preview) {
                console.warn("imageDoor.js: #doorImagePreview липсва");
                return;
            }
            preview.src = e.target.result;
        };

        reader.readAsDataURL(file);
    });
});