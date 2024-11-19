<html>
<?php
require "Classes/Product.php";
require "Classes/Database.php";
//gebruikt de functie om alle producten op te halen. 
$producten = Product::getAll();
?>

<head>
    <!--De connecties met CSS/Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="CSS/Style.css">
</head>

<body>
    <!--De navbar-->
    <div class="container-fluid text-center" id="Navbar">
        <nav class="navbar bg-body-tertiary fixed-top" style="background-color: #999090;">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Garage</a>
                <a class="nav-link" href="ProductAdd.php">Voeg Toe</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Index.php">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="products.php">Producten</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Orders.php">Bestellingen</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>

    <!--De hoofdcontainer voor de body.-->
    <div class="container-fluid" id="container-main">
        <div class="row row-justify-content-center">

            <?php
            //checkt hoeveel producten er zijn met de count functie, als er niks is laat hij zien dat er geen producten beschikbaar zijn.
            if (count($producten) == 0) {
                echo "<span style='background-color: #ffffff'>Helaas, er zijn geen producten beschikbaar!</span>";
                //Als er producten opgehaald kunnen worden gaat hij de foreach loop in om zo alle producten op te halen.
                //Voor elk product die bestaat in de database maakt hij een rij aan met de contents van het product.
            } else {
            ?> <div class="row">
                    <div class="col">
                        <h5>Product ID</h5>
                    </div>
                    <div class="col">
                        <h5>Product naam</h5>
                    </div>
                    <div class="col">
                        <h5>categorie</h5>
                    </div>
                    <div class="col">
                        <h5>prijs</h5>
                    </div>
                    <div class="col">
                        <h5>Hoeveel Beschikbaar</h5>
                    </div>
                    <div class="col">
                        <h5>Wijzig</h5>
                    </div>
                    <div class="col">
                        <h5>Verwijder</h5>
                    </div>
                </div>
                
                <?php
                foreach ($producten as $product) {
                ?>
                    <div class="row">
                        <div class="col">
                            <h5><?= $product->id ?></h5><br />
                        </div>
                        <div class="col">
                            <h5><?= $product->name ?></h5>
                        </div>
                        <div class="col">
                            <h5><?= $product->category ?></h5>
                        </div>
                        <div class="col">
                            <h5><?= $product->price ?></h5>
                        </div>
                        <div class="col">
                            <h5><?= $product->inStock ?></h5>
                        </div>
                        <div class="col">
                            <a href="ProductEdit.php?id=<?= $product->id; ?>" class="btn btn-secondary">Wijzig product</a>
                        </div>
                        <div class="col">
                            <a href="ProductDelete.php?id=<?= $product->id; ?>" class="btn btn-warning">verwijder product</a>
                        </div>
                    </div>
             
            <?php       }
            }
            ?>
        </div>
    </div>

    <!-- Een footer die de pagina mooi afsluit. -->
    <div class="container" id="footer">
        <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
            <div class="col-md-4 d-flex align-items-center">
                <span class="mb-3 mb-md-0 text-muted">© 2024 Garage, Inc</span>
            </div>
        </footer>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>

</html>