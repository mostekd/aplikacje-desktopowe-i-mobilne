document.addEventListener("DOMContentLoaded", function() {
    // Kalkulator zakupu cegieł
    const brickQuantityInput = document.getElementById("brickQuantity");
    const isPremiumBrickCheckbox = document.getElementById("isPremiumBrick");
    const distanceInput = document.getElementById("distance");
    const brickResultDisplay = document.getElementById("brickResult");

    document.getElementById("calculateBricks").addEventListener("click", function() {
        const quantity = parseInt(brickQuantityInput.value);
        const isPremium = isPremiumBrickCheckbox.checked;
        const distance = parseInt(distanceInput.value);

        if (isNaN(quantity) || quantity <= 0 || isNaN(distance) || distance < 0) {
            brickResultDisplay.textContent = "Wprowadź poprawne dane.";
            return;
        }

        const costPerBrick = isPremium ? 2 * 1.3 : 2;
        const weightPerBrick = isPremium ? 1.75 : 1.5;
        const transportCost = Math.ceil(quantity * weightPerBrick / 10) * distance * 0.05;

        const totalCost = quantity * costPerBrick;
        const totalWeight = quantity * weightPerBrick;
        const brickType = isPremium ? "cegła premium" : "cegła standardowa";

        brickResultDisplay.textContent = `Zakupiona ilość cegieł: ${quantity}, ${brickType}, koszt zakupu cegieł: ${totalCost.toFixed(2)} zł, waga cegieł: ${totalWeight} kg, koszt transportu: ${transportCost.toFixed(2)} zł`;
    });

    // Kalkulator kosztu wejściówek do aquaparku
    document.getElementById("calculateTickets").addEventListener("click", function() {
        var normalTickets = parseInt(document.getElementById('normalTickets').value);
        var discountTickets = parseInt(document.getElementById('discountTickets').value);
        var hours = parseInt(document.getElementById('hours').value);
        var familyCard = document.getElementById('familyCard').checked;

        var normalPricePerHour = 10;
        var discountPricePerHour = 5;
        var normalPriceAllDay = 50;
        var discountPriceAllDay = 25;
        var totalCost = 0;

        // Calculate total cost based on hours
        if (hours <= 4) {
            totalCost += normalTickets * normalPricePerHour * hours;
            totalCost += discountTickets * discountPricePerHour * hours;
        } else {
            totalCost += normalTickets * normalPriceAllDay;
            totalCost += discountTickets * discountPriceAllDay;
        }

        // Apply family card discount
        if (familyCard) {
            totalCost *= 0.9;
        }

        // Apply free normal ticket for every 15 discount tickets
        var freeNormalTickets = Math.floor(discountTickets / 15);
        totalCost -= freeNormalTickets * normalPriceAllDay;

        document.getElementById('ticketResult').innerHTML = "Całkowity koszt wstępu do aquaparku: " + totalCost.toFixed(2) + " zł";
    });
});
