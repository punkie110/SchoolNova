"use strict;"
//bron huidige tijd: https://stackoverflow.com/questions/10211145/getting-current-date-and-time-in-javascript.
const Textlines = [];
function showText() {
    var currentdate = new Date(); 
    const paragraaf = document.querySelector("#paragraaf");
    paragraaf.innerHTML = "";
   Textlines.push({naam : document.querySelector("#Naam").value, bericht : document.querySelector("#Input").value, tijd : currentdate.getDate() + "/"
            + (currentdate.getMonth()+1)  + "/" 
            + currentdate.getFullYear() + " - "  
            + currentdate.getHours() + ":"  
            + currentdate.getMinutes() + ":" 
            + currentdate.getSeconds()});


         
    for (let i = 0; i < Textlines.length; i++)
        {
          
            paragraaf.innerHTML = "" + paragraaf.innerHTML + "<div>" +  Textlines[i].bericht + "<br />" + Textlines[i].naam + "  Geschreven op:" + Textlines[i].tijd + "</div>";
            console.log(Textlines[i]);
        } 
  
}

