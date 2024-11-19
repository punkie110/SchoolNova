<head>


</head>

<body>
    <?php
    include "gebruiker.php";
    $gebruiker = new gebruiker();
    $gebruiker->voornaam = "Jari";
    $gebruiker->achternaam = "Pilk";
    $gebruiker->emailAdres = "JariPilk@gmail.com";
    echo $gebruiker->geefVolledigeNaam();
    $gebruiker = new gebruiker();
    $gebruiker->voornaam = "Ramon";
    $gebruiker->achternaam = "Berkhout";
    $gebruiker->emailAdres = "rberkhout@novacollege.nl";
    echo $gebruiker->geefVolledigeNaam();
    ?>
</body>