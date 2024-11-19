"use strict;"

function showText() {
    const paragraaf = document.querySelector("#paragraaf");
   const tekst = document.querySelector("#Input").value;
   paragraaf.innerText = tekst;
}

function showFile() {
    const paragraaf2 = document.querySelector("#paragraaf2");
   const source = document.querySelector("#file").value;
   paragraaf2.src = source;
}

