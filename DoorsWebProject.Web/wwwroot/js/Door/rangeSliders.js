const rangeMin = document.getElementById('rangeMin');
const rangeMax = document.getElementById('rangeMax');
const minValue = document.getElementById('minValue');
const maxValue = document.getElementById('maxValue');
const progress = document.querySelector('.progress');



function updateSlider() {
    let min = parseInt(rangeMin.value);
    let max = parseInt(rangeMax.value);

    // Позволяваме курсорите да се "разменят"
    if (min > max) {
        [min, max] = [max, min];
    }

    minValue.textContent = min + " лв";
    maxValue.textContent = max + " лв";

    // Визуализираме правилно синята лента между двете стойности
    progress.style.left = (min / rangeMin.max) * 100 + "%";
    progress.style.right = 100 - (max / rangeMax.max) * 100 + "%";
}

rangeMin.addEventListener("input", updateSlider);
rangeMax.addEventListener("input", updateSlider);

updateSlider();
