<head>


</head>
<body>
    <?php
        include "product.php";
        $product = new Product();
        $product->naam = "game";
        $product->prijs = "20";
        $product->voorraad = "30";
       echo $product->omschrijf();

       $product = new Product();
        $product->naam = "Controller";
        $product->prijs = "45";
        $product->voorraad = "60";
       echo $product->omschrijf();
    ?>
</body>