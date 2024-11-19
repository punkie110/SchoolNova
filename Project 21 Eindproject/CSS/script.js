


// Functie om gegevens naar de server te verzenden
function sendDataToServer(id) {
  $("#result").load("Addreservering.php?id=" + id);
  $("#dialog").dialog();
}



//Voeg event listeners toe aan de vakjes
document.querySelectorAll('.square').forEach(square => {
  square.addEventListener('click', () => {
    const id = square.getAttribute('data-id');
    sendDataToServer(id); // Verstuur gegevens naar de server
  });
});


$("#dialog").dialog({
  resizable: false, // Gebruiker kan het venster niet resizen
  draggable: true,  // Gebruiker kan het venster wel verplaatsen
  width: 600,       // Breedte van het dialoogvenster
  height: 400,      // Hoogte van het dialoogvenster
  modal: true       // Optioneel: modal maakt het een overlay dialoog
});


function isDateBooked(date) {
  // Loop door geboekte datums en maak ze onklikbaar
  for (var i = 0; i < bookedRanges.length; i++) {
    var startDate = new Date(bookedRanges[i].start);
    var endDate = new Date(bookedRanges[i].end);

    if (date >= startDate && date <= endDate) {
      return [false, 'booked', 'Geboekt']; // Onklikbaar en met tooltip "Geboekt"
    }
  }
  return [true, '', '']; // Alle andere data blijven klikbaar
}

function checkDateOverlap(startDate, endDate) {
  if (startDate && endDate) {
    for (var i = 0; i < bookedRanges.length; i++) {
      var bookedStart = new Date(bookedRanges[i].start);
      var bookedEnd = new Date(bookedRanges[i].end);

      // Controleer op overlappen
      if (
        (startDate <= bookedEnd && endDate >= bookedStart) || // Overlap
        (startDate <= bookedStart && endDate >= bookedStart) || // Aankomstdatum overlapt met geboekt
        (startDate <= bookedEnd && endDate >= bookedEnd) // Vertrekdatum overlapt met geboekt
      ) {
        alert("Deze datums overlappen met bestaande reserveringen.");
        $("#aankomstdatum, #vertrekdatum").datepicker("setDate", null); // Reset beide datums
        selectedStartDate = null; // Reset de geselecteerde startdatum
        selectedEndDate = null; // Reset de geselecteerde einddatum
        location.reload(); // Herlaad de pagina
        break; // Stop met controleren
      }
    }
  }
}

$(function () {
  var selectedStartDate = null;
  var selectedEndDate = null;

  $("#aankomstdatum").datepicker({
    dateFormat: "dd-mm-yy",
    minDate: 0,
    beforeShowDay: isDateBooked,
    onSelect: function (selectedDate) {
      selectedStartDate = $(this).datepicker("getDate"); // Bewaar de geselecteerde startdatum
      var minDate = $("#aankomstdatum").datepicker("getDate");
      $("#vertrekdatum").datepicker("option", "minDate", minDate); // Zet vertrekdatum minimaal na aankomstdatum
      checkDateOverlap(selectedStartDate, selectedEndDate); // Controleer op overlap
    }
  });

  $("#vertrekdatum").datepicker({
    dateFormat: "dd-mm-yy",
    beforeShowDay: isDateBooked,
    onSelect: function (selectedDate) {
      selectedEndDate = $(this).datepicker("getDate"); // Bewaar de geselecteerde einddatum
      var maxDate = $("#vertrekdatum").datepicker("getDate");
      $("#aankomstdatum").datepicker("option", "maxDate", maxDate); // Zet aankomstdatum maximaal voor vertrekdatum
      checkDateOverlap(selectedStartDate, selectedEndDate); // Controleer op overlap
    }
  });

 
});

  $(document).on("click", ".klant-select", function() {
    var id = $(this).attr("rel");
    var name = $(this).html();

    $("#klantnummer").val(id);
    $("#selectedKlant").html(name);

    return false;
  });


