document.addEventListener("DOMContentLoaded", () => {
    // Избираме всички елементи, към които искаме да добавим анимация или клик
    const doorButtons = document.querySelectorAll(".smooth-door-btn");

    // Ако няма такива елементи, скриптът просто няма да прави нищо
    if (doorButtons.length === 0) return;

    doorButtons.forEach(btn => {
        btn.addEventListener("click", (e) => {
            //e.preventDefault(); // Ако искаш да предотвратиш стандартния линк временно
            const href = btn.getAttribute("href");
            if (!href) return; // Ако няма href, нищо не правим

            // Пример: малка анимация преди пренасочване
            document.body.style.transition = "opacity 0.3s";
            document.body.style.opacity = "0";

            setTimeout(() => {
                window.location.href = href; // Пренасочване към линка
            }, 300);
        });
    });
});
