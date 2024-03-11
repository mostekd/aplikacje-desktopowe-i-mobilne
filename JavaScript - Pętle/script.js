        // Funkcja do wyświetlania tekstu na stronie HTML
        function displayOutput(text) {
            document.getElementById('output').innerHTML += text + '<br>';
        }

        // 1. Wyświetla na ekranie 10 kolejnych liczb całkowitych począwszy od 1.
        displayOutput("1. 10 kolejnych liczb od 1:");
        for (let i = 1; i <= 10; i++) {
            displayOutput(i);
        }

        // 2. Wyświetla na ekranie 10 kolejnych liczb całkowitych począwszy od 10 w kolejności malejącej.
        displayOutput("<br>2. 10 kolejnych liczb od 10 w kolejności malejącej:");
        for (let i = 10; i >= 1; i--) {
            displayOutput(i);
        }

        // 3. Oblicza i wyświetla na ekranie sumę kolejnych 10 liczb całkowitych począwszy od 1.
        let sum = 0;
        for (let i = 1; i <= 10; i++) {
            sum += i;
        }
        displayOutput("<br>3. Suma 10 kolejnych liczb od 1: " + sum);

        // 4. Wyświetla na ekranie 10 kolejnych parzystych liczb całkowitych począwszy od 2.
        displayOutput("<br>4. 10 kolejnych parzystych liczb od 2:");
        for (let i = 2; i <= 20; i += 2) {
            displayOutput(i);
        }

        // 5-6. Oblicza kwotę zgromadzoną przez pracownika
        function calculateSavings(X, Y, months) {
            let total = 0;
            for (let i = 1; i <= months; i++) {
                total += Y;
                total *= 1.08; // 8% interest
            }
            return total;
        }

        const X = 1000; // Odkładana kwota co miesiąc
        const Y = 200; // Ilość miesięcy
        displayOutput("<br>5-6. Kwota zgromadzona przez pracownika: " + calculateSavings(X, Y, 12) + " zł");

        // 7. Oblicza sumę elementów ciągu arytmetycznego
        const firstElement = 5;
        const difference = 10;
        const numberOfElements = 100;
        const sumOfArithmeticSequence = (numberOfElements / 2) * (2 * firstElement + (numberOfElements - 1) * difference);
        displayOutput("<br>7. Suma elementów ciągu arytmetycznego: " + sumOfArithmeticSequence);

        // 8. Oblicza ilość cegieł w piramidzie o podstawie 10 x 10 cegieł
        const baseLength = 10;
        const bricksInPyramid = (baseLength * (baseLength + 1) * (2 * baseLength + 1)) / 6;
        displayOutput("<br>8. Ilość cegieł w piramidzie: " + bricksInPyramid);

        // 9. Oblicza ilość cegieł w ścianie
        function calculateBricksInWall(X, Y, Z) {
            let totalBricks = 0;
            for (let i = Y; i >= 1; i -= Z) {
                totalBricks += i * X;
            }
            return totalBricks;
        }

        const X_wall = 10; // Szerokość ściany w cegłach
        const Y_rows = 5; // Wysokość ściany w rzędach cegieł
        const Z_difference = 1; // Różnica wysokości między kolejnymi rzędami
        displayOutput("<br>9. Ilość cegieł w ścianie: " + calculateBricksInWall(X_wall, Y_rows, Z_difference));

        // 10. Oblicza wagę ściany
        const weight_per_brick = 2; // Waga jednej cegły w kilogramach
        const weight_of_wall = calculateBricksInWall(X_wall, Y_rows, Z_difference) * weight_per_brick;
        displayOutput("<br>10. Waga ściany: " + weight_of_wall + " kg");

        // 11. Symulator prostego kalkulatora
        const operation = prompt("Podaj działanie (+, -, *, /):");
        const num1 = parseFloat(prompt("Podaj pierwszą liczbę:"));
        const num2 = parseFloat(prompt("Podaj drugą liczbę:"));
        let result;
        switch (operation) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                result = "Nieprawidłowe działanie!";
        }
        displayOutput("<br>11. Wynik działania: " + result);

        // 12. Wyświetla ciąg arytmetyczny
        function arithmeticSequence(N, X, Y) {
            let sequence = "";
            for (let i = 0; i < N; i++) {
                sequence += (X + i * Y) + " ";
            }
            return sequence.trim();
        }

        const N_sequence = 10; // Liczba elementów ciągu
        const X_sequence = 3; // Pierwszy element ciągu
        const Y_sequence = 5; // Różnica między kolejnymi elementami
        displayOutput("<br>12. Ciąg arytmetyczny: " + arithmeticSequence(N_sequence, X_sequence, Y_sequence));

        // 13. Oblicza sumę dwóch liczb podanych przez użytkownika
        let userInput;
        let sumUserInput = 0;
        do {
            userInput = parseFloat(prompt("Podaj liczbę (0 aby zakończyć):"));
            sumUserInput += userInput;
        } while (sumUserInput !== 0);
        displayOutput("<br>13. Suma podanych liczb: " + sumUserInput);

        // 14. Oblicza silnię liczby
        function factorial(number) {
            if (number === 0 || number === 1)
                return 1;
            else
                return number * factorial(number - 1);
        }

        const numberForFactorial = parseInt(prompt("Podaj liczbę dla obliczenia silni:"));
        displayOutput("<br>14. Silnia z podanej liczby: " + factorial(numberForFactorial));

        // 15. Wyświetla ciąg kwadratów liczb
        const firstNumber = parseInt(prompt("Podaj pierwszą liczbę w ciągu:"));
        const nNumbers = parseInt(prompt("Podaj ilość liczb w ciągu:"));
        let sequenceSquares = "";
        let currentNumber = firstNumber;
        for (let i = 0; i < nNumbers; i++) {
            sequenceSquares += currentNumber * currentNumber + " ";
            currentNumber *= currentNumber;
        }
        displayOutput("<br>15. Ciąg kwadratów liczb: " + sequenceSquares.trim());

        // 16. Oblicza sumę oraz średnią z 10 losowych liczb
        let sumRandomNumbers = 0;
        const numberOfRandomNumbers = 10;
        for (let i = 0; i < numberOfRandomNumbers; i++) {
            const randomNumber = Math.floor(Math.random() * (100 - 50 + 1)) + 50; // Losowa liczba z przedziału <50, 100>
            sumRandomNumbers += randomNumber;
        }
        const averageRandomNumbers = sumRandomNumbers / numberOfRandomNumbers;
        displayOutput("<br>16. Suma losowych liczb: " + sumRandomNumbers);
        displayOutput("<br>    Średnia losowych liczb: " + averageRandomNumbers);