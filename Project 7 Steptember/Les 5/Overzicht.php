<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>ID</strong></td>
            <td><strong>Merk</strong></td>
            <td><strong>Type</strong></td>
            <td><strong>Kleur</strong></td>
        </tr>
        <?php
        require "Auto.php";
        $autos = Auto::alleAutos();
        foreach($autos as $auto)
        {
        echo "<tr>";
        echo "<td>" . $auto->id . "</td>";
        echo "<td>" . $auto->merk . "</td>";
        echo "<td>" . $auto->type . "</td>";
        echo "<td>" . $auto->kleur . "</td>";
        echo "</tr>";
        }



        ?>
    </table>
</body>