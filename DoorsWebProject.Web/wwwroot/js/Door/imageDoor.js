const container = document.getElementById('zoomContainer');
const lens = document.getElementById('zoomLens');
const zoomedImg = document.getElementById('zoomedImage');
const baseImg = document.getElementById('doorImage');

container.addEventListener('mousemove', moveLens);
container.addEventListener('mouseenter', () => (lens.style.display = 'block'));
container.addEventListener('mouseleave', () => (lens.style.display = 'none'));

function moveLens(e) {
    const rect = container.getBoundingClientRect();
    const x = e.clientX - rect.left;
    const y = e.clientY - rect.top;

    const lensSize = lens.offsetWidth / 2;

    let lensX = x - lensSize;
    let lensY = y - lensSize;

    // Ограничаваме движението в рамките на снимката
    if (lensX < 0) lensX = 0;
    if (lensY < 0) lensY = 0;
    if (lensX > rect.width - lens.offsetWidth)
        lensX = rect.width - lens.offsetWidth;
    if (lensY > rect.height - lens.offsetHeight)
        lensY = rect.height - lens.offsetHeight;

    lens.style.left = lensX + 'px';
    lens.style.top = lensY + 'px';

    // Позиционираме вътрешната увеличена снимка
    zoomedImg.style.left = -(x * 2 - lensSize) + 'px';
    zoomedImg.style.top = -(y * 2 - lensSize) + 'px';
}
