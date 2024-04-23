document.addEventListener("DOMContentLoaded", function() {
    const numberInputs = document.querySelectorAll(".numberInput");
    const checkboxes = document.querySelectorAll(".checkbox");
    const sumDisplay = document.getElementById("sum");

    function calculateSum() {
        let sum = 0;
        let invalidInput = false;

        for (let i = 0; i < numberInputs.length; i++) {
            if (checkboxes[i].checked) {
                const value = parseInt(numberInputs[i].value);
                if (isNaN(value) || !Number.isInteger(value)) {
                    invalidInput = true;
                    break;
                }
                sum += value;
            }
        }

        if (invalidInput) {
            sumDisplay.textContent = "Wprowadź poprawną liczbę całkowitą we wszystkich zaznaczonych polach.";
        } else {
            sumDisplay.textContent = `Suma liczb zaznaczonych pól: ${sum}`;
        }
    }

    numberInputs.forEach(input => {
        input.addEventListener("input", calculateSum);
    });

    checkboxes.forEach(checkbox => {
        checkbox.addEventListener("change", calculateSum);
    });
});
