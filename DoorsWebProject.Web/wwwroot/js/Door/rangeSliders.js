document.addEventListener("DOMContentLoaded", () => {
    // Промени селектора към твоя (пример: ".range-slider" или "#priceRange")
    const sliders = document.querySelectorAll(".range-slider");

    if (!sliders || sliders.length === 0) return; // няма такива елементи — безопасно излизане

    sliders.forEach(slider => {
        // намираме input[type=range] вътре (примерна структура)
        const input = slider.querySelector("input[type='range']");
        const output = slider.querySelector(".range-value");

        if (!input) return; // няма range input вътре — прескачаме
        // ако output липсва, можем да създадем или да пропуснем
        if (!output) {
            // опция: създаваме .range-value елемент
            // const span = document.createElement("span");
            // span.className = "range-value";
            // slider.appendChild(span);
            // output = span;
            return;
        }

        // инициализация на стойността
        output.textContent = input.value;

        input.addEventListener("input", (e) => {
            output.textContent = e.target.value;
            // тук може да сложиш и допълнителна логика (например AJAX филтриране)
        });
    });
});