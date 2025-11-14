let quantity = 1;
const quantityInput = document.getElementById('quantity');

function increase() {
    if (quantity < 10) { // максимум 10 врати
        quantity++;
        quantityInput.value = quantity;
    }
}

function decrease() {
    if (quantity > 1) { // минимум 1 врата
        quantity--;
        quantityInput.value = quantity;
    }
}

