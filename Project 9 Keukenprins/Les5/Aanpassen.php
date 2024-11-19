<?php
require "Database.php";
require "Provincie.php";
if (!isset($_GET["id"])) {
    header("location: Overzicht.php");
    exit;
}

$provincie = Provincie::getOne($_GET["id"]);
if ($provincie == null) {
    header("location: Overzicht.php");
    exit;
}

if(isset($_POST["naam"]))
{
    $provincie->naam = $_POST["naam"];
    $provincie->hoofdstad = $_POST["hoofdstad"];
    $provincie->populatie = $_POST["populatie"];
    $provincie->oppervlakte = $_POST["oppervlakte"];
    $provincie->oprichtdatum = $_POST["oprichtdatum"];
    $provincie->update();
    header("location: Overzicht.php");
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Provincie aanpassen</title>
</head>

<body>
   <form method = "POST">
<label for="naam">Naam:</label>
<input type="text" id="naam" name="naam" value="<?= $provincie->naam; ?>" required><br>

<label for="hoofdstad">Hoofdstad:</label>
<input type="text" id="hoofdstad" name="hoofdstad" value="<?= $provincie->hoofdstad; ?>" required><br>

<label for="populatie">Populatie:</label>
<input type="text" id="populatie" name="populatie" value="<?= $provincie->populatie; ?>" required><br>

<label for="oppervlakte">Oppervlate (in km2):</label>
<input type="text" id="oppervlakte" name="oppervlakte" value="<?= $provincie->oppervlakte; ?>" required><br>

<label for="oprichtdatum">Oprichtdatum:</label>
<input type="text" id="oprichtdatum" name="oprichtdatum" value="<?= $provincie->oprichtdatum; ?>" required><br>

<input type="submit" value="verzenden">
   </form> 
</body>
</html>