    // Zadanie 1
    const kontener = document.getElementById('kontener');

    kontener.addEventListener('click', function() {
        const r = Math.floor(Math.random()*255)
        const g = Math.floor(Math.random()*255)
        const b = Math.floor(Math.random()*255)
        this.style.backgroundColor = `rgb(${r},${g},${b})`
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
        this.textContent = 'Częstochowski';
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
