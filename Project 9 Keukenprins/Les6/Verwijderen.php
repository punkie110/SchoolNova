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

if(isset($_POST["delete"]))
{
    if($_POST["delete"] == "ja")
    {
    $provincie->delete();
    header("location: Overzicht.php");
    }
    else
    {
        header("location: Overzicht.php");
    }
}

echo $provincie->naam, "<br>";

?>
<!DOCTYPE html>
<html>
    <head>
        <strong>Weet je zeker dat je deze provincie wil verwijderen?</strong>
    </head>
    <body>
    <form method = "POST">
    <label for="ja">Ja</label>
        <input type="radio" name="delete" value="ja"> <br>

        <label for="nee">Nee</label>
        <input type="radio" name="delete" value="nee"> <br>

    <input type="submit" value="bevestig">
    </form>
    </body>
</html>
