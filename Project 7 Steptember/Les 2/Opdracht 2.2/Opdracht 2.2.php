<head>

</head>

<body>
    <?php
    require "boek.php";
    $spannendBoek = new boek();
    $spannendBoek->titel = "Boek der boeken";
    $spannendBoek->auteur = "Jopie";
    $spannendBoek->paginas = "130";
    $huidigepagina = 4;

    while ($spannendBoek->lees($huidigepagina)) {
        echo $huidigepagina . "<br />";
        $huidigepagina++;
    }
    ?>
</body>