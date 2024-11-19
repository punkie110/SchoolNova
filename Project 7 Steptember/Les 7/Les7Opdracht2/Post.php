<head>

</head>

<body>
    <table>
        <form name="Toevoegen" method="post" action="Pagina2.php">
            <h2>Voer hier uw gegevens in</h2>
            <h5>Straat:</h5>
            <?php 
            if(isset($_COOKIE["straat"]))
            {
                ?>
            <input type="text" value=<?PHP echo $_COOKIE["straat"] ?> name="straat"><br />
            <h5>huisnummer:</h5>
            <input type="text" value=<?PHP echo $_COOKIE["huisnummer"] ?> name="huisnummer"><br />
            <h5>postcode:</h5>
            <input type="text" value=<?PHP echo $_COOKIE["postcode"] ?> name="postcode"><br />
            <h5>stad:</h5>
            <input type="text" value=<?PHP echo $_COOKIE["stad"] ?> name="stad"><br />
            <h5>land:</h5>
            <input type="text" value=<?PHP echo $_COOKIE["land"] ?> name="land"><br />
            <input type="submit" value="Bevestigen">
            <?php
            }
            else{
         ?>
          <input type="text" name="straat"><br />
            <h5>huisnummer:</h5>
            <input type="text" name="huisnummer"><br />
            <h5>postcode:</h5>
            <input type="text" name="postcode"><br />
            <h5>stad:</h5>
            <input type="text" name="stad"><br />
            <h5>land:</h5>
            <input type="text" name="land"><br />
            <input type="submit" value="Bevestigen">
         <?php
            }
            ?>
    </table>
</body>