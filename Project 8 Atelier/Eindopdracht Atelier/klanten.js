
// "use strict" zorgt ervoor dat de code strikter wordt gecontroleerd en minder fouten maakt
"use strict";

// Functie om dubbele nummers uit een lijst te verwijderen
function DeleteDouble() {
    // Definieer een lijst met klantnummers
    let klantNummers = [1, 10, 45, 43, 56, 2, 6, 9, 10, 4, 1, 56, 34, 57, 70, 60, 41, 65, 64, 63, 62, 41];

    // Verwijder dubbele nummers door een Set te gebruiken en deze terug te zetten naar een array
    let uniekeNummers = Array.from(new Set(klantNummers));

    // Schrijft de lijst van unieke nummers naar het document
    document.write("Lijst van unieke nummers </br>");

    // Loop door de lijst van unieke nummers en schrijft elk nummer naar het document
    for (let i = 0; i < uniekeNummers.length; i++) {
        document.write(uniekeNummers[i]);
        document.write("</br>");
    }
}

// Functie om het hoogste nummer uit een lijst te vinden
function highestNumber() {
    // Definieert een lijst met nummers
    let nummers = [1, 10, 45, 43, 56, 2, 6, 9, 10, 4, 1, 56, 34, 57, 70, 60, 41, 65, 64, 63, 62, 41];

    // Start met het eerste nummer als het maximum
    let max = nummers[0];

    // Loop door de lijst van nummers om het hoogste nummer te vinden
    for (let i = 1; i < nummers.length; i++) {
        if (nummers[i] > max) {
            max = nummers[i];
        }
    }

    // Schrijf het hoogste nummer naar het document
    document.write("</br> hoogste nummer </br>");
    document.write(max);
}

// Wacht tot de DOM volledig geladen is voordat hij de functies uitvoert
document.addEventListener("DOMContentLoaded", function () {
    DeleteDouble();
    highestNumber();
});