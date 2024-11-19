<head>


</head>

<body>
    <?php
    require "Bankrekening.php";
    $ingRekening = new Bankrekening();
    $ingRekening->rekeningnummer = "INGB0001234567NL";
    $ingRekening->rekeninghouder = "E. Erikszoon";
    $ingRekening->saldo = 6704.09;
    echo $ingRekening->stortGeld(430);
    echo $ingRekening->pinnen(790);
    echo $ingRekening->stortGeld(43);
    echo $ingRekening->pinnen(4000.76);
    echo $ingRekening->pinnen(368.23);
    ?>
</body>