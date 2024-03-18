    // Zadanie 1
    const kontener = document.getElementById('kontener');

    kontener.addEventListener('click', function() {
        const randomColor = Math.floor(Math.random()*16777215).toString(16);
        this.style.backgroundColor = "#" + randomColor;
    });

    kontener.addEventListener('mouseover', function() {
        this.style.fontSize = '2em';
    });

    kontener.addEventListener('mouseout', function() {
        this.style.fontSize = '';
    });

    // Zadanie 2
    const wyroznionyParagraf = document.querySelector('.wyroznione');

    wyroznionyParagraf.addEventListener('dblclick', function() {
        this.textContent = 'Nazwa Powiatu';
    });

    wyroznionyParagraf.addEventListener('mouseenter', function() {
        console.log(this.textContent);
    });

    // Zadanie 3
    const poleTekstowe = document.getElementById('artykul');
    const liczbaDiv = document.getElementById('liczba');

    poleTekstowe.addEventListener('keypress', function(event) {
        this.style.width = (this.value.length + 1) * 10 + 'px';
        const key = event.key;
        if (!isNaN(key)) {
            liczbaDiv.textContent += key;
        }
    });