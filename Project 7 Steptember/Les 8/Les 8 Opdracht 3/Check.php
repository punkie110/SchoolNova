<head>

</head>

<body>
    <table>

        <table>
            <tr>
                <td><strong>Welkom, dit zijn je gegevens:</strong></td><br />
            </tr>
            <?php
            require "Gebruiker.php";
            require "Sessie.php";
            $sessie = Sessie::vindSessies();
            echo "<tr>";
            echo "<td>" . $sessie->id . "</td>";
            echo "<td>" . $sessie->userId . "</td>";
            echo "<td>" . $sessie->key . "</td>";
            echo "<td>" . $sessie->start . "</td>";
            echo "<td>" . $sessie->end . "</td>";
            echo "</tr>";
            if($sessie = null)
            {
                header("location: check.php");
            }
            ?>
        </table>
</body>