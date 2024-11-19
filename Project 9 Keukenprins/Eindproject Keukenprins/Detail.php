<?php
require "Classes/Database.php";
require "Classes/Blog.php";

//haalt een blog op dmv het ID. Als blog null is, verwijst het programma je weer terug naar Index.php
$blog = Blog::getOne($_GET["id"]);
if ($blog == null) {
    header("location: Index.php");
    exit;
}

?>

<!DOCTYPE html>
<html>

<head>
    <!--Een titel voor de pagina en de connecties met CSS/Bootstrap -->
    <title>Blog bekijken</title>
    <link rel="stylesheet" href="Css/jquery-te-1.4.0.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="Css/style.css">
</head>

<body>
    <!--Een navigatiebalk met een container die het id navbar meeneemt. -->
    <div class="container-fluid text-center" id="Navbar">
        <nav class="navbar bg-body-tertiary fixed-top" style="background-color: #999090;">
            <div class="container-fluid">
                <a class="navbar-brand" href="">Keukenprins blog</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Detail.php">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Admin/Index.php">Naar Admin</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>

    <!--De hoofdcontainer voor de body.-->
    <div class="container-fluid" id="container-main">
        <div class="row row-justify-content-center">

            <!--Kaartjes die worden aangemaakt met de inhoud van de blog-->
            <div class="card" style="width: 300rem;">
                <div class="card-header">
                    <h5 class="card-title"><?= $blog->titel ?></h5>
                </div>

                <div class="card-body">
                    <p class="card-text"><?= $blog->content ?></p>
                    <img src="upload/<?= $blog->foto; ?>" class="card-img-top" alt="blog foto">
                    <p class="card-text">Geschreven door: <?= $blog->autheur ?></p>
                </div>
            </div>
        </div>

        <form>
            <script type="text/javascript" src="http://code.jquery.com/jquery.min.js" charset="utf-8"></script>
            <script type="text/javascript" src="../js/jquery-te-1.4.0.min.js" charset="utf-8"></script>
            <script>
                $('.jqte').jqte();
            </script>
        </form>
</body>

<!-- Een footer die de pagina mooi afsluit. -->
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2023 Keukenprins, Inc</span>
        </div>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

</html>