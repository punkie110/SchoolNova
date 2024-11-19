<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>ID</strong></td>
            <td><strong>Merk</strong></td>
            <td><strong>Type</strong></td>
            <td><strong>Opslag</strong></td>
            <td><strong>Grootte</strong></td>
            <td><strong>Resolutie</strong></td>
            <td><strong>Prijs</strong></td>
            <td><strong>Release Datum</strong></td>
        </tr>
        <?php
        require "Telefoon.php";
        $telefoons = Telefoon::alleTelefoons();
        foreach($telefoons as $telefoon)
        {
        echo "<tr>";
        echo "<td>" . $telefoon->id . "</td>";
        echo "<td>" . $telefoon->merk . "</td>";
        echo "<td>" . $telefoon->type . "</td>";
        echo "<td>" . $telefoon->opslag . "</td>";
        echo "<td>" . $telefoon->grootte . "</td>";
        echo "<td>" . $telefoon->resolutie . "</td>";
        echo "<td>" . $telefoon->prijs . "</td>";
        echo "<td>" . $telefoon->datum . "</td>";
        echo "</tr>";
        }



        ?>
    </table>
</body>