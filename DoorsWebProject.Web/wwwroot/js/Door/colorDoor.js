const colorCircles = document.querySelectorAll('.color');
const textureLayer = document.getElementById('doorTexture');

colorCircles.forEach(circle => {
    circle.addEventListener('mouseenter', function () {
        const texture = this.getAttribute('data-texture-url');
        const color = this.getAttribute('data-color');
        console.log(texture);
        if (texture) {
            textureLayer.style.backgroundImage = `url(${texture})`;
        }

        if (color) {
            textureLayer.style.backgroundColor = color;
        }
    });

    circle.addEventListener('mouseleave', function () {
        textureLayer.style.background = "none"; // връща оригиналната снимка, когато махнеш мишката
    });
});