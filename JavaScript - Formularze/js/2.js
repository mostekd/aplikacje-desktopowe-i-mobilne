document.addEventListener("DOMContentLoaded", function() {
    const distanceInput = document.getElementById("distance");
    const isFromGdanskCheckbox = document.getElementById("isFromGdansk");
    const deliveryCostDisplay = document.getElementById("deliveryCost");

    function calculateDeliveryCost() {
        const distance = parseInt(distanceInput.value);
        const costPerKm = 1;
        let totalCost = distance * 2 * costPerKm; // Round trip

        if (isFromGdanskCheckbox.checked) {
            deliveryCostDisplay.textContent = "Dowieziemy Twoją pizzę za darmo";
        } else {
            deliveryCostDisplay.textContent = `Dowóz będzie Cię kosztował ${totalCost} zł`;
        }
    }

    distanceInput.addEventListener("input", calculateDeliveryCost);
    isFromGdanskCheckbox.addEventListener("change", calculateDeliveryCost);
});
