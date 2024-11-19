<?php
$image = null;
if(isset($_POST["submit"]))
{
if(!empty($_FILES["bestand"]["name"]))
{
   $image = $_FILES["bestand"]["name"];
   $target = "upload/" . basename($image);

   move_uploaded_file($_FILES["bestand"]["tmp_name"], $target);
    header("location: Details.php?image=$image");
}
}
?> 
<html>
    <head>
        <title>Upload</title>
    </head>
    <body>
        <form method="POST" enctype="multipart/form-data">
            <label for="bestand">Bestand:</label>
            <br />
            <input type = "file" id="bestand" name="bestand"/>
            <br><br />
            <input type = "submit" name="submit" value="submit">
</form>
  </body>
</html>