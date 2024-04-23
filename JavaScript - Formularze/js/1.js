document.addEventListener("DOMContentLoaded", function() {
    const guestsInput = document.getElementById("guests");
    const afterPartyCheckbox = document.getElementById("afterParty");
    const totalCostDisplay = document.getElementById("totalCost");

    function calculateTotalCost() {
        const guestsCount = parseInt(guestsInput.value);
        const costPerPerson = 100;
        let totalCost = guestsCount * costPerPerson;

        if (afterPartyCheckbox.checked) {
            totalCost *= 1.3; // Increase by 30% if afterPartyCheckbox is checked
        }

        totalCostDisplay.textContent = `Całkowity koszt wesela: ${totalCost} zł`;
    }

    guestsInput.addEventListener("input", calculateTotalCost);
    afterPartyCheckbox.addEventListener("change", calculateTotalCost);
});
