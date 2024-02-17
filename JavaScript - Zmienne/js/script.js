        // Zadanie 1
        function task1() {
            var num1 = parseFloat(prompt("Podaj pierwszą liczbę:"));
            var num2 = parseFloat(prompt("Podaj drugą liczbę:"));
            var num3 = parseFloat(prompt("Podaj trzecią liczbę:"));
            var sum = num1 + num2 + num3;
            alert("Suma liczb to: " + sum);
        }

        // Zadanie 2
        function task2() {
            var num1 = parseFloat(prompt("Podaj pierwszą liczbę:"));
            var num2 = parseFloat(prompt("Podaj drugą liczbę:"));
            var num3 = parseFloat(prompt("Podaj trzecią liczbę:"));
            var average = (num1 + num2 + num3) / 3;
            alert("Średnia liczb to: " + average);
        }

        // Zadanie 3
        function task3() {
            var num1 = parseFloat(prompt("Podaj pierwszą liczbę:"));
            var num2 = parseFloat(prompt("Podaj drugą liczbę:"));
            var sum = num1 + num2;
            var diff = num1 - num2;
            var product = num1 * num2;
            alert("Suma: " + sum + "\nRóżnica: " + diff + "\nIloczyn: " + product);
        }

        // Zadanie 4
        function task4() {
            var num = parseFloat(prompt("Podaj liczbę:"));
            var sqrt = Math.sqrt(num);
            alert("Pierwiastek liczby to: " + sqrt);
        }

        // Zadanie 5
        function task5() {
            var sideLength = parseFloat(prompt("Podaj długość boku kwadratu:"));
            var area = sideLength * sideLength;
            alert("Pole kwadratu to: " + area);
        }

        // Zadanie 6
        function task6() {
            var length = parseFloat(prompt("Podaj długość pierwszego boku prostopadłościanu:"));
            var width = parseFloat(prompt("Podaj długość drugiego boku prostopadłościanu:"));
            var height = parseFloat(prompt("Podaj długość trzeciego boku prostopadłościanu:"));
            var volume = length * width * height;
            alert("Pole prostopadłościanu to: " + volume);
        }

        // Zadanie 7
        function task7() {
            var radius = parseFloat(prompt("Podaj promień koła:"));
            var area = Math.PI * radius * radius;
            var circumference = 2 * Math.PI * radius;
            alert("Pole koła to: " + area + "\nObwód koła to: " + circumference);
        }

        // Zadanie 8
        function task8() {
            var gasPrice = parseFloat(prompt("Podaj obecną cenę benzyny za litr:"));
            var distance = 360; // km
            var consumption = 8; // litrów na 100 km
            var cost = (distance / 100) * consumption * gasPrice;
            alert("Koszt przejazdu z Gdańska do Szczecina wynosi: " + cost.toFixed(2) + " zł");
        }

        // Zadanie 9
        function task9() {
            var gasPrice = parseFloat(prompt("Podaj cenę benzyny za litr:"));
            var distance = parseFloat(prompt("Podaj długość trasy w km:"));
            var consumption = parseFloat(prompt("Podaj średnie spalanie samochodu na 100 km:"));
            var cost = (distance / 100) * consumption * gasPrice;
            alert("Koszt przejazdu wynosi: " + cost.toFixed(2) + " zł");
        }

        // Zadanie 10
        function task10() {
            var amount = parseFloat(prompt("Podaj kwotę lokaty:"));
            var interestRate = 0.08; // 8%
            var taxRate = 0.19; // 19% podatek Belki
            var interest = amount * interestRate;
            var taxedInterest = interest * (1 - taxRate);
            alert("Zysk z lokaty po opodatkowaniu wynosi: " + taxedInterest.toFixed(2) + " zł");
        }