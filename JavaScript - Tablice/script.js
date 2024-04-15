var outputDiv = document.getElementById("output");
// Utwórz tablicę tab1
var tab1 = [7, 3, 1, 6, 9, 5, 4, 10, 2, 2];

// Wypisz zawartość 5 komórek tablicy
outputDiv.innerHTML += "<p>5 komórka tab1: " + tab1.slice(4, 5) + "</p>";

// Zmień zawartość 7 komórki tablicy na 12
tab1[6] = 12;
outputDiv.innerHTML += "<p>Zmodyfikowane tab1: " + tab1 + "</p>";

// Utwórz tablicę tab2 i przepisz zawartość tab1 do tab2
var tab2 = tab1.slice();
outputDiv.innerHTML += "<p>Tablica tab2: " + tab2 + "</p>";

// Utwórz tablicę tab3 - suma komórek o tych samych indeksach tab1 i tab2
var tab3 = [];
for (var i = 0; i < tab1.length; i++) {
    tab3.push(tab1[i] + tab2[i]);
}
outputDiv.innerHTML += "<p>Tablica tab3: " + tab3 + "</p>";

// Przepisz zawartość tab1 do tab2 w odwrotnej kolejności
tab2 = tab1.slice().reverse();
outputDiv.innerHTML += "<p>Tablica tab2 po przepisaniu w odwrotnej kolejności: " + tab2 + "</p>";

// Utwórz tablicę i wypełnij ją wartościami podanymi przez użytkownika
var userArray = [];
for (var i = 0; i < 10; i++) {
    var userInput = parseInt(prompt("Podaj wartość elementu nr " + (i+1) + " tablicy:"));
    userArray.push(userInput);
}

// Znajdź najmniejszy i największy element w tablicy
var min = Math.min(...userArray);
var max = Math.max(...userArray);
outputDiv.innerHTML += "<p>Najmniejszy element: " + min + "</p>";
outputDiv.innerHTML += "<p>Największy element: " + max + "</p>";

// Oblicz średnią wartość elementów tablicy
var sum = userArray.reduce((a, b) => a + b, 0);
var average = sum / userArray.length;
outputDiv.innerHTML += "<p>Średnia wartość elementów: " + average + "</p>";

// Wylicz ilość wystąpień cyfry 3 w tablicy
var count3 = userArray.filter(x => x === 3).length;
outputDiv.innerHTML += "<p>Ilość wystąpień cyfry 3: " + count3 + "</p>";

// Dowolnym sposobem posortuj elementy tablicy w porządku rosnącym
userArray.sort((a, b) => a - b);
outputDiv.innerHTML += "<p>Posortowana tablica: " + userArray + "</p>";

// Znajdź medianę elementów tablicy
var median;
if (userArray.length % 2 === 0) {
    median = (userArray[userArray.length / 2 - 1] + userArray[userArray.length / 2]) / 2;
} else {
    median = userArray[(userArray.length - 1) / 2];
}
outputDiv.innerHTML += "<p>Mediana: " + median + "</p>";

// Wypisz 3 najmniejsze i trzy największe elementy tablicy
outputDiv.innerHTML += "<p>Trzy najmniejsze elementy: " + userArray.slice(0, 3) + "</p>";
outputDiv.innerHTML += "<p>Trzy największe elementy: " + userArray.slice(-3) + "</p>";

// Zwiększ wartość każdego elementu tablicy podnosząc go do kwadratu
var squaredArray = userArray.map(x => x * x);
outputDiv.innerHTML += "<p>Tablica po podniesieniu do kwadratu: " + squaredArray + "</p>";

// Policz ilość liczb parzystych i nieparzystych w tablicy
var evenCount = userArray.filter(x => x % 2 === 0).length;
var oddCount = userArray.length - evenCount;
outputDiv.innerHTML += "<p>Ilość liczb parzystych: " + evenCount + "</p>";
outputDiv.innerHTML += "<p>Ilość liczb nieparzystych: " + oddCount + "</p>";

// Podaj ile liczb zawartych w tablicy jest podzielna bez reszty przez 3
var divisibleBy3 = userArray.filter(x => x % 3 === 0).length;
outputDiv.innerHTML += "<p>Ilość liczb podzielnych przez 3: " + divisibleBy3 + "</p>";

// Utwórz tablicę liter i wypełnij ją literami wprowadzonymi przez użytkownika
var lettersArray = [];
for (var i = 0; i < 10; i++) {
    var letterInput = prompt("Podaj literę dla elementu nr " + (i+1) + " tablicy:");
    lettersArray.push(letterInput);
}

// Wypełnij tablicę 10 literowym wyrazem podanym przez użytkownika
var wordInput = prompt("Podaj 10 literowy wyraz:");
var wordArray = wordInput.split("");

// Zamień wszystkie wielkie litery na małe i odwrotnie
lettersArray = lettersArray.map(letter => {
    if (letter === letter.toUpperCase()) {
        return letter.toLowerCase();
    } else {
        return letter.toUpperCase();
    }
});

// Wypisz zawartość tablicy w losowej kolejności
function shuffleArray(array) {
    for (var i = array.length - 1; i > 0; i--) {
        var j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
    return array;
}
outputDiv.innerHTML += "<p>Tablica w losowej kolejności: " + shuffleArray(lettersArray) + "</p>";

// Utwórz 100-elementową tablicę liczb całkowitych i wypełnij ją losowymi liczbami
var randomArray = Array.from({length: 100}, () => Math.floor(Math.random() * 100));

// Znajdź największą spośród liczb oraz wyświetl na ekranie informację mówiącą o tym, ile razy ta liczba znalazła się w tablicy
var maxNumber = Math.max(...randomArray);
var countMax = randomArray.filter(x => x === maxNumber).length;
outputDiv.innerHTML += "<p>Największa liczba to " + maxNumber + " i występuje " + countMax + " razy</p>";

// Wyświetl na ekran liczby nieparzyste
var oddNumbers = randomArray.filter(x => x % 2 !== 0);
outputDiv.innerHTML += "<p>Liczby nieparzyste: " + oddNumbers + "</p>";

// Wyświetl na ekran liczby znajdujące się w komórkach o nieparzystych indeksach
var oddIndexNumbers = randomArray.filter((x, index) => index % 2 !== 0);
outputDiv.innerHTML += "<p>Liczby o nieparzystych indeksach: " + oddIndexNumbers + "</p>";

// Program policzy ile liczb zawiera się w przedziale <5, 15)
var numbersInRange = randomArray.filter(x => x >= 5 && x < 15);
outputDiv.innerHTML += "<p>Liczby z przedziału <5, 15): " + numbersInRange + "</p>";

// Znajdź element najbliższy wartością wprowadzonej przez użytkownika liczbie „a”
var a = parseInt(prompt("Podaj liczbę a:"));
var closestElement = randomArray.reduce(function(prev, curr) {
    return (Math.abs(curr - a) < Math.abs(prev - a) ? curr : prev);
});
outputDiv.innerHTML += "<p>Najbliższy element do liczby a to: " + closestElement + "</p>";

// Znajdź poprzednik i następnik najmniejszej wartości w tablicy
var minIndex = randomArray.indexOf(Math.min(...randomArray));
var predecessor = randomArray[minIndex - 1];
var successor = randomArray[minIndex + 1];
outputDiv.innerHTML += "<p>Poprzednik najmniejszej wartości: " + predecessor + "</p>";
outputDiv.innerHTML += "<p>Następnik najmniejszej wartości: " + successor + "</p>";

// Przepisz do nowej tablicy te elementy, których wartość jest >10
var newArray = randomArray.filter(x => x > 10);
outputDiv.innerHTML += "<p>Nowa tablica: " + newArray + "</p>";

// Utwórz nową tablicę 100 elementową z sumami kolejnych elementów tablicy
var cumulativeArray = [];
var sum = 0;
for (var i = 0; i < randomArray.length; i++) {
    sum += randomArray[i];
    cumulativeArray.push(sum);
}
outputDiv.innerHTML += "<p>Nowa tablica z sumami: " + cumulativeArray + "</p>";

// Posortuj tablicę malejąco
randomArray.sort((a, b) => b - a);
outputDiv.innerHTML += "<p>Posortowana malejąco: " + randomArray + "</p>";

// Wypisz na ekran elementy, które występują w tablicy przynajmniej 3 razy
var occurrences = {};
randomArray.forEach(function(number) {
    occurrences[number] = (occurrences[number] || 0) + 1;
});
var elementsWithThreeOccurrences = Object.keys(occurrences).filter(function(number) {
    return occurrences[number] >= 3;
});
outputDiv.innerHTML += "<p>Elementy występujące przynajmniej 3 razy: " + elementsWithThreeOccurrences + "</p>";

// Utwórz pustą tablicę 100 elementów i wypełnij ją kolejnymi liczbami ciągu Fibonacciego
var fibonacciArray = [];
var a = 0, b = 1, temp;
for (var i = 0; i < 100; i++) {
    fibonacciArray.push(a);
    temp = a;
    a = b;
    b = temp + b;
}
outputDiv.innerHTML += "<p>Tablica liczb Fibonacciego: " + fibonacciArray + "</p>";

// Wypełnij tablicę kolejnymi potęgami liczby 2
var powersOfTwoArray = [];
for (var i = 0; i < 100; i++) {
    powersOfTwoArray.push(Math.pow(2, i));
}
outputDiv.innerHTML += "<p>Tablica potęg liczby 2: " + powersOfTwoArray + "</p>";

// Wypełni tablicę ciągiem liczb: 3, 6, 9, 12, …
var sequence1Array = [];
for (var i = 1; i <= 100; i++) {
    sequence1Array.push(i * 3);
}
outputDiv.innerHTML += "<p>Tablica z ciągiem: " + sequence1Array + "</p>";

// Wypełni tablicę ciągiem liczb: 2, 4, 8, 16, 32, …
var sequence2Array = [];
var power = 1;
for (var i = 1; i <= 100; i++) {
    sequence2Array.push(power * 2);
    power *= 2;
}
outputDiv.innerHTML += "<p>Tablica z ciągiem potęg liczby 2: " + sequence2Array + "</p>";