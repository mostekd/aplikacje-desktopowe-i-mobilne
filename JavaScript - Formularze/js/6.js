document.addEventListener("DOMContentLoaded", function() {
    const brickQuantityInput = document.getElementById("brickQuantity");
    const isPremiumBrickCheckbox = document.getElementById("isPremiumBrick");
    const resultDisplay = document.getElementById("result");

    document.getElementById("calculate").addEventListener("click", function() {
        const quantity = parseInt(brickQuantityInput.value);
        const isPremium = isPremiumBrickCheckbox.checked;

        if (isNaN(quantity) || quantity <= 0) {
            resultDisplay.textContent = "Wprowadź poprawną liczbę cegieł.";
            return;
        }

        const costPerBrick = isPremium ? 2 * 1.3 : 2;
        const weightPerBrick = isPremium ? 1.75 : 1.5;

        const totalCost = quantity * costPerBrick;
        const totalWeight = quantity * weightPerBrick;

        const brickType = isPremium ? "cegła premium" : "cegła standardowa";

        resultDisplay.textContent = `Zakupiona ilość cegieł: ${quantity}, ${brickType}, koszt zakupu cegieł: ${totalCost} zł, waga cegieł: ${totalWeight} kg`;
    });
});
