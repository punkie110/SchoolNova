<head>

</head>

<body>
    <?php
    include "gadget.php";
    $smartwatch = new Gadget("Smartwatch");
    $smartwatch->voorraad = 52;
    $smartwatch->prijs = 275;
    echo $smartwatch->type . ":" . "voorraad " . $smartwatch->voorraad . "<br /> prijs " . $smartwatch->prijs;

    $speaker = new Gadget("Speaker");
    $speaker->voorraad = 90;
    $speaker->prijs = 110;
    echo "<br />" . $speaker->type . ":" . "voorraad " . $speaker->voorraad . "<br /> prijs " . $speaker->prijs;

    ?>
</body>