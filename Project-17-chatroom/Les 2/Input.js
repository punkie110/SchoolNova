"use strict;"
const Textlines = [];
function showText() {
    const paragraaf = document.querySelector("#paragraaf");
    paragraaf.innerHTML = "";
    Textlines.push(document.querySelector("#Input").value);

    for (let i = 0; i < Textlines.length; i++)
        {
            paragraaf.innerHTML = "" + paragraaf.innerHTML + "<div>" + Textlines[i] + "</div>";
            console.log(Textlines[i]);
        } 
  
}

