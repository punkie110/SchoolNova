<?php
require "Database.php";
require "Stad.php";
if (!isset($_GET["id"])) {
    header("location: Overzicht.php");
    exit;
}

$stad = Stad::getStad($_GET["id"]);
if ($stad == null) {
    header("location: Overzicht.php");
    exit;
}
?>
<table>
    <tr>
        <td> <?= $stad->id ?>
        <td>
        <td> <?= $stad->naam ?>
        <td>
        <td> <?= $stad->populatie ?>
        <td>
        <td> <?= $stad->provincie ?>
        <td>
        <td> <?= $stad->burgemeester ?>
        <td>
        <td> <?= $stad->oprichtdatum ?>
        <td>
    <tr>
</table>