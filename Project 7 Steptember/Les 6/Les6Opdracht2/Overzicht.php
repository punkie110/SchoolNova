<head>

</head>

<body>
    <?php
    require "Provincie.php";
    $province = new province();
    $province->naam = "test";
    $province->hoofdstad = "test 2";
    $province->populatie = "999367";
    $province->grond = "3456.78";
    $province->datum = "1836-01-01";
    $province->insertProvinces();
    ?>
</body>