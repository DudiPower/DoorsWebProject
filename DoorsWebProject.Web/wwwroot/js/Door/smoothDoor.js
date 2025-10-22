document.getElementById("filterBtn").addEventListener("click", function () {
    const categoryId = document.getElementById("categoryId").value;
    //const color = document.getElementById("color").value;
    const minPrice = document.getElementById("minPrice").value;
    const maxPrice = document.getElementById("maxPrice").value;

    const params = new URLSearchParams({
        categoryId,
        minPrice,
        maxPrice
    });

    fetch("/Door/Filter?" + params.toString())
        .then(res => res.text())
         .then(html => {
                document.getElementById("doorsContainer").innerHTML = html;
    })
        });
