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

        brickResultDisplay.textContent = `Zakupiona ilość cegieł: ${quantity}, ${brickType}, koszt zakupu cegieł: ${totalCost} zł, waga cegieł: ${totalWeight} kg, koszt transportu: ${transportCost.toFixed(2)} zł`;
    });

    // Kalkulator kosztu biletów do aquaparku
    const normalTicketsInput = document.getElementById("normalTickets");
    const discountTicketsInput = document.getElementById("discountTickets");
    const hoursInput = document.getElementById("hours");
    const isLargeFamilyCardCheckbox = document.getElementById("isLargeFamilyCard");
    const ticketResultDisplay = document.getElementById("ticketResult");

    document.getElementById("calculateTickets").addEventListener("click", function() {
        const normalTickets = parseInt(normalTicketsInput.value);
        const discountTickets = parseInt(discountTicketsInput.value);
        const hours = parseInt(hoursInput.value);
        const isLargeFamilyCard = isLargeFamilyCardCheckbox.checked;

        if (isNaN(normalTickets) || isNaN(discountTickets) || isNaN(hours) || normalTickets < 0 || discountTickets < 0 || hours <= 0) {
            ticketResultDisplay.textContent = "Wprowadź poprawne dane.";
            return;
        }

        const normalTicketCostPerHour = 10;
        const discountTicketCostPerHour = 5;
        const normalDailyTicketCost = 50;
        const discountDailyTicketCost = 25;
        let totalCost = (normalTickets * normalTicketCostPerHour) + (discountTickets * discountTicketCostPerHour);
        
        // Sprawdzenie czy liczba biletów ulgowych pozwala na darmowy bilet normalny
        const freeNormalTickets = Math.floor(discountTickets / 15);
        totalCost -= freeNormalTickets * normalTicketCostPerHour;

        // Obliczenie kosztu za godziny powyżej 4
        if (hours > 4) {
            totalCost += (hours - 4) * (normalTicketCostPerHour + discountTicketCostPerHour);
        }

        // Dodanie kosztu biletu całodziennego
        if (hours >= 4) {
            totalCost += isLargeFamilyCard ? discountDailyTicketCost * 0.9 : discountDailyTicketCost;
        } else {
            totalCost += isLargeFamilyCard ? normalDailyTicketCost * 0.9 : normalDailyTicketCost;
        }

        ticketResultDisplay.textContent = `Całkowity koszt wstępu do aquaparku: ${totalCost} zł`;
    });
});
