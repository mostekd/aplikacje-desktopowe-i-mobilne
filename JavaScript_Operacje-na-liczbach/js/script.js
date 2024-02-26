// Wprowadzenie danych przez użytkownika
const liczba1 = parseFloat(prompt("Wprowadź pierwszą liczbę:"));
const liczba2 = parseFloat(prompt("Wprowadź drugą liczbę:"));
const liczba3 = parseFloat(prompt("Wprowadź trzecią liczbę:"));

// Obliczenia dla pierwszej liczby
const przeciwnyZnak1 = -liczba1;
const suma151 = liczba1 + 15;
const suma051 = liczba1 + 0.5;
const kwadrat1 = liczba1 ** 2;
const podzielonaPrzez21 = liczba1 / 2;
const resztaZDzieleniaPrzez21 = liczba1 % 2;
const wiekszaO11 = liczba1 + 1;
const mniejszaO11 = liczba1 - 1;
const zaokraglonaWdol1 = Math.floor(liczba1 / 3);
const zaokraglonaWgore1 = Math.ceil(liczba1 / 3);
const zaokraglona1 = Math.round(liczba1 / 3);
const pierwiastek1 = Math.sqrt(liczba1);
const losowaLiczba1 = Math.random() * 50;
const iloczyn1 = liczba1 * losowaLiczba1;
const wartoscAbsolutna1 = Math.abs(liczba1);
const podwojonaWartosc1 = liczba1 * 2;

// Obliczenia dla drugiej i  trzeciej liczby
const pierwiastekSumy = Math.sqrt(liczba2 + liczba3);
const roznicaKwadratow3 = Math.pow(liczba2, 2) - Math.pow(liczba3, 2);
const potegaTrzecia3 = Math.pow(liczba3, 3);
const kwadrat3 = Math.pow(liczba3, 2);
const pierwiastekSzescienny3 = Math.pow(liczba3, 1/3);
const sredniaArytmetyczna3 = (liczba2 + liczba3) / 2;
const pomnozPrzez103 = liczba3 * 10;
let suma3 = 0;
for (let i = 1; i <= liczba3; i++) {
    suma3 += i;
}

// Wyświetlenie wyników na stronie
const wynikiDiv = document.getElementById("wyniki");
wynikiDiv.innerHTML = `
  <p>Dla pierwszej liczby:</p>
  <ul>
    <li>Przeciwny znak: ${przeciwnyZnak1}</li>
    <li>Suma z 15: ${suma151}</li>
    <li>Suma z 0.5: ${suma051}</li>
    <li>Kwadrat: ${kwadrat1}</li>
    <li>Podzielona przez 2: ${podzielonaPrzez21}</li>
    <li>Reszta z dzielenia przez 2: ${resztaZDzieleniaPrzez21}</li>
    <li>Większa o 1: ${wiekszaO11}</li>
    <li>Mniejsza o 1: ${mniejszaO11}</li>
    <li>Zaokrąglona w dół: ${zaokraglonaWdol1}</li>
    <li>Zaokrąglona w górę: ${zaokraglonaWgore1}</li>
    <li>Zaokrąglona: ${zaokraglona1}</li>
    <li>Pierwiastek: ${pierwiastek1}</li>
    <li>Iloczyn z losową liczbą: ${iloczyn1}</li>
    <li>Wartość absolutna: ${wartoscAbsolutna1}</li>
    <li>Podwojona wartość: ${podwojonaWartosc1}</li>
  </ul>
  
  <p>Dla drugiej i trzeciej liczby:</p>
  <ul>
    <li>Pierwiastek sumy: ${pierwiastekSumy}</li>
    <li>Różnica kwadratów: ${roznicaKwadratow3}</li>
    <li>Potęga trzecia: ${potegaTrzecia3}</li>
    <li>Kwadrat liczby: ${kwadrat3}</li>
    <li>Pierwiastek sześcienny: ${pierwiastekSzescienny3}</li>
    <li>Średnia arytmetyczna: ${sredniaArytmetyczna3}</li>
    <li>Wartość pomnożona przez 10: ${pomnozPrzez103}</li>
    <li>Suma liczb całkowitych od 1 do podanej liczby: ${suma3}</li>
  </ul>
`;