document.addEventListener("DOMContentLoaded", function() {
    const numberAInput = document.getElementById("numberA");
    const numberBInput = document.getElementById("numberB");
    const resultDisplay = document.getElementById("result");

    function calculate(operation) {
        const numberA = parseFloat(numberAInput.value);
        const numberB = parseFloat(numberBInput.value);

        if (isNaN(numberA) || isNaN(numberB)) {
            resultDisplay.textContent = "Wprowadź poprawne liczby w oba pola.";
            return;
        }

        let result;
        switch (operation) {
            case "add":
                result = numberA + numberB;
                break;
            case "subtract":
                result = numberA - numberB;
                break;
            case "multiply":
                result = numberA * numberB;
                break;
            case "divide":
                if (numberB === 0) {
                    result = "Nie można dzielić przez zero!";
                } else {
                    result = numberA / numberB;
                }
                break;
            case "modulus":
                result = numberA % numberB;
                break;
            case "integerDivide":
                if (numberB === 0) {
                    result = "Nie można dzielić przez zero!";
                } else {
                    result = Math.floor(numberA / numberB);
                }
                break;
            default:
                result = "Nieprawidłowa operacja";
        }

        resultDisplay.textContent = `Wynik: ${result}`;
    }

    document.getElementById("add").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("add");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });

    document.getElementById("subtract").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("subtract");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });

    document.getElementById("multiply").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("multiply");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });

    document.getElementById("divide").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("divide");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });

    document.getElementById("modulus").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("modulus");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });

    document.getElementById("integerDivide").addEventListener("click", function(event) {
        event.preventDefault();
        if (numberAInput.value && numberBInput.value) {
            calculate("integerDivide");
        } else {
            resultDisplay.textContent = "Wprowadź obie liczby.";
        }
    });
});
