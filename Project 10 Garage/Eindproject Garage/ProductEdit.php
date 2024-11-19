<html>
<?php
require "Classes/Database.php";
require "Classes/Product.php";

//Haalt het product op Door middel van het ID, als dat niet lukt leid het programma je weer terug naar de Product pagina.
$product = Product::getOne($_GET["id"]);
if ($product == null) {
    header("location: Products.php");
    exit;
}

//checkt of de naam is gezet, als dat waar is voert hij de functie update uit waardoor het product geupdate wordt.
if (isset($_POST["naam"])) {

    $product->name = $_POST["naam"];
    $product->category = $_POST["categorie"];
    $product->price = $_POST["prijs"];
    $product->inStock = $_POST["beschikbaar"];
    $product->update();
    header("location: Products.php");
}
?>

<head>
    <!--Een titel voor de pagina en de connecties met CSS/Bootstrap -->
    <title>Product aanpassen</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="CSS/Style.css">
</head>

<body>
    <!--De navigatiebalk-->
    <div class="container-fluid text-center" id="Navbar">
        <nav class="navbar bg-body-tertiary fixed-top" style="background-color: #999090;">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Garage</a>

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

    <!--De hoofdcontainer-->
    <div class="container-fluid-text-center" id="container-main">

        <div class="row row-justify-content-center">
            <h1>Pas het product aan!</h1>

            <!--Maakt een POST form aan, met daarin de al bestaande data van het product die uit de database word gehaald.-->
            <form method="POST">
                <label for="naam">Naam:</label><br />
                <input type="text" id="naam" name="naam" value="<?= $product->name; ?>" required><br>

                <label for="categorie">Categorie:</label><br />
                <input type="text" id="categorie" name="categorie" value="<?= $product->category; ?>" required><br>

                <label for="prijs">Prijs:</label><br />
                <input type="text" id="prijs" name="prijs" value="<?= $product->price; ?>" required><br>

                <label for="beschikbaar">Hoeveel beschikbaar:</label><br />
                <input type="text" id="beschikbaar" name="beschikbaar" value="<?= $product->inStock; ?>" required><br>
                <input type="submit" value="verzenden">
            </form>

            <!-- Een footer die de pagina mooi afsluit. -->
            <div class="container" id="footer">
                <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
                    <div class="col-md-4 d-flex align-items-center">
                        <span class="mb-3 mb-md-0 text-muted">© 2024 Garage, Inc</span>
                    </div>
                </footer>
                <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>

</html>