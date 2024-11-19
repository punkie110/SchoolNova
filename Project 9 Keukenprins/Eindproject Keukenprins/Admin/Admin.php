<?php
require "../Classes/blog.php";
require "../Classes/Database.php";
require "../Classes/Sessie.php";
$sessie = Sessie::vindSessies();

//Als de cookie niet bestaat, stuurt hij de gebruiker terug naar de login pagina.
if ($sessie == null) {
    header("location: Index.php");
    exit;
}

//gebruikt de functie om alle blogs op te halen. 
$blogs = Blog::findAll();
?>

<head>
      <!--De connecties met CSS/Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="../Css/admin.css">
</head>

<body>
    <!--De navigatiebalk-->
    <div class="container-fluid text-center">
        <nav class="navbar bg-body-tertiary fixed-top" style="background-color: #0080fe;" id="Navbar">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Keukenprins Admin</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Admin.php">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Insert.php">Voeg toe</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="../Index.php">Naar de Hoofdpagina</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>

    <div class="container-fluid" id="container-main">
        <div class="row row-justify-content-center">

            <?php
            //Als er blogs opgehaald kunnen worden gaat hij de foreach loop in om zo alle blogs op te halen.
            //Voor elke blog die bestaat in de database maakt hij een kaartje aan met de contents van de blog.
            if (Count($blogs) == 0) {
                echo "Er zijn geen blogs beschikbaar, probeer er eentje toe te voegen!";
            ?><a href="Insert.php">Voeg Toe</a><?php

            } else {
              foreach ($blogs as $blog) {
            ?>
                    <div class="col">
                        <div class="card" style="width: 18rem; background-color: #0080fe;">
                            <img src="../upload/<?= $blog->foto; ?>" class="card-img-top" alt="blog foto">
                            <div class="card-header">
                                <h5 class="card-title"><?= $blog->titel ?></h5>
                            </div>
                            <div class="card-body">
                                <a href="Edit.php?id=<?= $blog->id; ?>" class="btn btn-success">Pas Aan</a>
                                <a href="Delete.php?id=<?= $blog->id; ?>" class="btn btn-danger">Verwijder</a>
                            </div>
                        </div>
                    </div>
            <?php       }
                                            }
            ?>
        </div>
    </div>

</body>
<!-- Een footer die de pagina mooi afsluit. -->
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2023 Keukenprins, Inc</span>
        </div>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>