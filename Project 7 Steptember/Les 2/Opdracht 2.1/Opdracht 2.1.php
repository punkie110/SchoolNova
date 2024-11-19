<head>


</head>

<body>
    <?php
    require "Auto.php";
    $auto1 = new Auto();


    $auto1->merk = "Toyota";
    $auto1->model = "Celica";
    $auto1->bouwjaar = 2002;
    $auto1->waarde = 4000;
    echo $auto1->verkoop(6000);

    $auto2 = new auto();
    $auto2->merk = "Toyota";
    $auto2->model = "Corolla";
    $auto2->bouwjaar = 1997;
    $auto2->waarde = 8000;
    echo $auto2->verkoop(5000);

    $auto3 = new auto();
    $auto3->merk = "Honda";
    $auto3->model = "Civic";
    $auto3->bouwjaar = 2023;
    $auto3->waarde = 40000;
    echo $auto3->verkoop(50000);

    $auto4 = new auto();
    $auto4->merk = "Renault";
    $auto4->model = "Twingo";
    $auto4->bouwjaar = 2011;
    $auto4->waarde = 700;
    echo $auto4->verkoop(900);


    $auto5 = new auto();
    $auto5->merk = "Alpine";
    $auto5->model = "A110";
    $auto5->bouwjaar = 2022;
    $auto5->waarde = 73450;
    echo $auto5->verkoop(71000);
    ?>
</body>