<html>
<?php
require "Classes/Database.php";
require "Classes/Product.php";

//Haalt het product op Door middel van het ID.
$product = Product::getOne($_GET["id"]);

//checkt of de radiobutton is gezet, als de radiobutton ja is aangevinkt voert hij de functie delete uit 
//waardoor het product verwijderd word uit de database. Als het nee is of iets anders is aangevinkt dan leid deze naar de Product pagina.
if (isset($_POST["delete"])) {
    if ($_POST["delete"] == "ja") {
        $product->delete();
        header("location: Products.php");
    } else {
        header("location: Products.php");
    }
}
?>

<head>
    <!--Een titel voor de pagina en de connecties met CSS/Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="CSS/Style.css">
</head>

<body>
    <!--De Navbar-->
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
    <div class="container-fluid text-center" id="container-main">
        <!--Maakt een POST form aan, met daarin twee radiobuttons die je kan aanvinken en het antwoord wordt doorgepost..-->
        <?php echo "<h1> $product->name </h1> <br>";    ?>
        <h1><strong>Weet je zeker dat je dit product wil verwijderen?</strong></h1>
        
        <form method="POST">
            <label for="ja">Ja</label>
            <input type="radio" name="delete" value="ja"> <br>

            <label for="nee">Nee</label>
            <input type="radio" name="delete" value="nee"> <br>

            <input type="submit" value="bevestig">
        </form>
    </div>
    <!-- Een footer die de pagina mooi afsluit. -->
    <div class="container" id="footer">
        <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
            <div class="col-md-4 d-flex align-items-center">
                <span class="mb-3 mb-md-0 text-muted">© 2024 Garage, Inc</span>
        </footer>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>

</html>