<?php
$straat;
setcookie("straat", $_POST["straat"], time() + 6000, "/");
setcookie("huisnummer", $_POST["huisnummer"], time() + 6000, "/");
setcookie("postcode", $_POST["postcode"], time() + 6000, "/");
setcookie("stad", $_POST["stad"], time() + 6000, "/");
setcookie("land", $_POST["land"], time() + 6000, "/");
header("location: Post.php");
exit;
?>