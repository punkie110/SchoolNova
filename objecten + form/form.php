<?php
if (isset($_POST)) {
    echo $_POST["firstname"]. " ". $_POST["lastname"];
}
?>

<form method="post">
    <input name="firstname" />
    <input name="lastname" />
    <input type="submit" value="Send" />
</form>