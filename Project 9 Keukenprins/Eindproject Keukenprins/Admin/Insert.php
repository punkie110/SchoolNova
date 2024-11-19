<?php
require "../Classes/Database.php";
require "../Classes/Blog.php";
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
$sessie = Sessie::vindSessies();

//Als de cookie niet bestaat, stuurt hij de gebruiker terug naar de login pagina.
if ($sessie == null) {
    header("location: Index.php");
    exit;
}

//als de titel is gepost, voert hij de functie insert uit waardoor de blog in de database word toegevoegd.
if (isset($_POST["titel"])) {
    if (!empty($_FILES["bestand"]["name"])) {
        $image = $_FILES["bestand"]["name"];
        $target = "../upload/" . basename($image);

        move_uploaded_file($_FILES["bestand"]["tmp_name"], $target);
    } else {
        $image = null;
    }
    $gebruiker = new Gebruiker();
    $blog = new Blog();
    $blog->titel = $_POST["titel"];
    $blog->autheur = $_POST["autheur"];
    $blog->foto = $image;
    $blog->content = $_POST["content"];
    $blog->insert();
    header("location: Admin.php?image=$image");
}


?>

<head>
       <!--De Titel en connecties met CSS/Bootstrap-->
    <title>Blog maken</title>
    <h1><strong>Blog Maken</strong></h1>
    <link rel="stylesheet" href="../Css/jquery-te-1.4.0.css">
    <link rel="stylesheet" href="../Css/admin.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
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

            <!--Een formulier waar je de gegevens kan invullen die gepost worden om in de database gevoegd te worden.-->
            <form method="POST" enctype="multipart/form-data">
                <label for="titelel">Titel:</label>
                <input type="text" id="titel" name="titel" required><br>

                <label for="autheur">Autheur:</label>
                <input type="text" id="autheur" name="autheur"><br>

                <label for="bestand">Foto:</label>
                <br />
                <input type="file" id="bestand" name="bestand" />
                <br><br />
                <textarea class="jqte" id="content" name="content" required></textarea>
                <br>
                <input type="submit" value="submit">
            </form>
            <script type="text/javascript" src="http://code.jquery.com/jquery.min.js" charset="utf-8"></script>
            <script type="text/javascript" src="../js/jquery-te-1.4.0.min.js" charset="utf-8"></script>
            <script>
                $('.jqte').jqte();
            </script>
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