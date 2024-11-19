<html>

<head>
    <title>Rich text editor</title>
    <link rel="stylesheet" href="../css/jquery-te-1.4.0.css">
</head>

<body>
    <form method="POST" action="Details.php">
        <textarea class="jqte" id="content" name="content" required></textarea>
        <br>
        <input type="submit" value="submit">
    </form>
    <script type="text/javascript" src="http://code.jquery.com/jquery.min.js" charset="utf-8"></script>
    <script type="text/javascript" src="../js/jquery-te-1.4.0.min.js" charset="utf-8"></script>
    <script>
        $('.jqte').jqte();
    </script>
</body>

</html>