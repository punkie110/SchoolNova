
<?php 
$image = $_GET["image"];
if (!empty($image)) { ?>
<img src ="upload/<?= $image; ?>" alt="Afbeelding">
<?php } ?>