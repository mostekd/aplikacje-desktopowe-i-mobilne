document.addEventListener("DOMContentLoaded", function() {
    const adsNumberInput = document.getElementById("adsNumber");
    const isRegularCustomerCheckbox = document.getElementById("isRegularCustomer");
    const costDisplay = document.getElementById("cost");

    function calculateCost() {
        const adsNumber = parseInt(adsNumberInput.value);
        let costPerAd;

        if (adsNumber >= 1 && adsNumber <= 50) {
            costPerAd = 2;
        } else if (adsNumber >= 51 && adsNumber <= 100) {
            costPerAd = 1.5;
        } else {
            costPerAd = 1;
        }

        let totalCost = adsNumber * costPerAd;

        if (isRegularCustomerCheckbox.checked) {
            totalCost *= 0.8; // 20% discount for regular customers
        }

        costDisplay.textContent = `Koszt ogłoszeń: ${totalCost.toFixed(2)} zł`;
    }

    document.getElementById("calculateCost").addEventListener("click", calculateCost);
});
