const rateInput = document.querySelector("#rate-input");
const rateType = document.querySelector("#rate-type");

const showRate = (rate) => {
    const personalRate = 22;
    const automovilRate = 12;
    const mortgageRate = 8;

    if (rate === "personal") return`${personalRate}%`;
    if (rate === "automovil") return`${automovilRate}%`;
    if (rate === "hipotecario") return`${mortgageRate}%`;
}

document.addEventListener('DOMContentLoaded', () => {
    rateInput.value = showRate("personal");
    rateType.onchange = (e) => rateInput.value = showRate(e.target.value);
});