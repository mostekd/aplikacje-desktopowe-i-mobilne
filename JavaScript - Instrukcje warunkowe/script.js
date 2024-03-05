// Obliczający wynik równania x = a/b. Wynik wypisuje na ekran. W przypadku, kiedy nie można obliczyć wyniku, wyświetli stosowny komunikat.
var a0 = Number(prompt("Podaj liczbe A: "))
var b0 = Number(prompt("Podaj liczbe b: "))
 
if (a0 > 0 && b0 > 0) {
      alert(`Iloczyn z liczb A i B to: ${a0/b0} `)
 }
else {
      alert("Zadna z liczb nie może być mniejsza lub równa zeru.")
}
 
// Obliczający wynik równania x = a/b + c/d . Wynik wypisuje na ekran. W przypadku, kiedy nie można obliczyć wyniku, wyświetli stosowny komunikat.
var a1 = Number(prompt("Podaj liczbe A: "))
var b1 = Number(prompt("Podaj liczbe B: "))
var c1 = Number(prompt("Podaj liczbe C: "))
var d1 = Number(prompt("Podaj liczbe D: "))
 
 
if (a1 > 0 && b1 > 0 && c1 > 0 && d1 > 0) {
      alert(`Suma z iloczynów A/B I C/D to: ${(a1/b1)+(c1/d1)}`)
 }
else {
      alert("Zadna z liczb nie może być mniejsza lub równa zeru.")
}
 
// Obliczający wynik równania x = (a+6) / (b – 4). Wynik wypisuje na ekran. W przypadku, kiedy nie można obliczyć wyniku, wyświetli stosowny komunikat.
var a2 = Number(prompt("Podaj liczbe A: "))
var b2 = Number(prompt("Podaj liczbe B: "))
 
if (a2 > 0 && b2 > 0) {
      alert(`Suma z iloczynów A/B I C/D to: ${(a2+6)/(b2-4)}`)
 }
else {
      alert("Zadna z liczb nie może być mniejsza lub równa zeru.")
}
 
// Sprawdzający czy wprowadzona liczba jest parzysta. Na ekran wypisuje stosowny komunikat.
var x = Number(prompt("Podaj liczbe: "))
 
if (x%2 == 0) {
      alert(`Liczba ${x} jest parzysta.`)
}
else {
      alert(`Liczba ${x} jest nieparzysta.`)
}
 
// Wczytujący dwie liczby. Sprawdza czy pierwsza jest podzielna przez drugą. Na ekran wypisuje stosowny komunikat.
var y = Number(prompt("Podaj liczbe y: "))
var z = Number(prompt("Podaj liczbe z: "))
 
if(y%z == 0) {
      alert(`Liczba ${y} jest podzielna przez ${z}`)
}
else {
      alert(`Liczba ${y} jest nie podzielna przez ${z}`)
}
 
// Sprawdzający czy wprowadzona liczba jest dodatnia, ujemna czy równa 0. Na ekran wypisuje stosowny komunikat.
var L = Number(prompt("Podaj liczbe L: "))
 
switch(true) {
 case (L < 0):
      alert(`Liczba L jest ujemna`);
 break;
 case (L == 0):
      alert(`Liczba L jest równa 0`);
 break;
 case (L > 0):
      alert(`Liczba L jest dodatnia`);
 break;
}
 
// Wypisujący na ekran największą spośród trzech wprowadzonych liczb.
var L1 = Number(prompt("Podaj liczbe L1: "))
var L2 = Number(prompt("Podaj liczbe L2: "))
var L3 = Number(prompt("Podaj liczbe L3: "))
 
switch(true) {
 case (L1 > L2 && L1 > L3):
      alert(`Liczba ${L1} jest największa spośród tych trzech`);
 break;
 case (L2 > L1 && L2 > L3):
      alert(`Liczba ${L2} jest największa spośród tych trzech`);
 break;
 case (L3 > L1 && L3 > L2):
      alert(`Liczba ${L3} jest największa spośród tych trzech`);
 break;
}
 
// Wypisujący trzy wprowadzone liczby w kolejności rosnącej.
var L1A = Number(prompt("Podaj liczbe L1: "))
var L2A = Number(prompt("Podaj liczbe L2: "))
var L3A = Number(prompt("Podaj liczbe L3: "))
 
const liczby = [L1A, L2A, L3A];
 
alert(`Liczby w kolejności rosnącej: ${liczby.sort((a, b) => b - a)}`)