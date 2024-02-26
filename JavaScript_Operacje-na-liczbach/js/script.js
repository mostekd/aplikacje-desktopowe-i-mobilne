// Funkcja pomocnicza do pobierania liczby od użytkownika
function getNumberFromUser(promptMessage) {
    return parseFloat(prompt(promptMessage));
  }

  // Funkcja pomocnicza do wyświetlania wyników na stronie
  function displayResult(resultMessage, result) {
    document.write("<p>" + resultMessage + ": " + result + "</p>");
  }

  // Zadania
  var number = getNumberFromUser("Wprowadź liczbę:");

  var oppositeNumber = -number;
  displayResult("Liczba o przeciwnym znaku", oppositeNumber);

  var sumWith15 = number + 15;
  displayResult("Suma z 15", sumWith15);

  var sumWith0_5 = number + 0.5;
  displayResult("Suma z 0.5", sumWith0_5);

  var square = Math.pow(number, 2);
  displayResult("Kwadrat liczby", square);

  var dividedBy2 = number / 2;
  displayResult("Wartość podzielona przez 2", dividedBy2);

  var remainderBy2 = number % 2;
  displayResult("Reszta z dzielenia przez 2", remainderBy2);

  var numberPlusOne = number + 1;
  displayResult("Liczba o jeden większa", numberPlusOne);

  var numberMinusOne = number - 1;
  displayResult("Liczba o jeden mniejsza", numberMinusOne);

  var roundedDownBy3 = Math.floor(number / 3);
  displayResult("Zaokrąglona w dół po podzieleniu przez 3", roundedDownBy3);

  var roundedUpBy3 = Math.ceil(number / 3);
  displayResult("Zaokrąglona w górę po podzieleniu przez 3", roundedUpBy3);

  var roundedToNearestBy3 = Math.round(number / 3);
  displayResult("Zaokrąglona do najbliższej całkowitej po podzieleniu przez 3", roundedToNearestBy3);

  var squareRoot = Math.sqrt(number);
  displayResult("Pierwiastek liczby", squareRoot);

  var randomNumber = Math.random() * 50;
  var productWithRandom = number * randomNumber;
  displayResult("Iloczyn z losową liczbą z przedziału od 0 do 50", productWithRandom);

  var absoluteValue = Math.abs(number);
  displayResult("Wartość absolutna liczby", absoluteValue);

  var doubledValue = number * 2;
  displayResult("Podwojona wartość liczby", doubledValue);

  var secondNumber = getNumberFromUser("Wprowadź drugą liczbę:");
  var sumOfSquares = Math.pow(number, 2) - Math.pow(secondNumber, 2);
  displayResult("Różnica kwadratów", sumOfSquares);

  var cube = Math.pow(number, 3);
  displayResult("Potęga trzecia", cube);

  var squareValue = Math.pow(number, 2);
  displayResult("Kwadrat liczby", squareValue);

  var cubeRoot = Math.cbrt(number);
  displayResult("Pierwiastek sześcienny", cubeRoot);

  var average = (number + secondNumber) / 2;
  displayResult("Średnia arytmetyczna", average);

  var multipliedByTen = number * 10;
  displayResult("Liczba pomnożona przez 10", multipliedByTen);

  var sumOfIntegers = (number * (number + 1)) / 2;
  displayResult("Suma liczb całkowitych od 1 do wprowadzonej liczby", sumOfIntegers);