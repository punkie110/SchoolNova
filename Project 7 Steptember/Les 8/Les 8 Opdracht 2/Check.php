<head>

</head>

<body>
    <table>
        <?php
        require "Sessie.php";
        $sessie = Sessie::vindSessies();
            echo "<tr>";
            echo "<td>" . $sessie->id . "</td>";
            echo "<td>" . $sessie->userId . "</td>";
            echo "<td>" . $sessie->key . "</td>";
            echo "<td>" . $sessie->start . "</td>";
            echo "<td>" . $sessie->end . "</td>";
            echo "</tr>";
 
        ?>
    </table>
</body>