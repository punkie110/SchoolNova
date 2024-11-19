<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>ID</strong></td>
            <td><strong>Naam</strong></td>
            <td><strong>Hoofdstad</strong></td>
            <td><strong>Populatie</strong></td>
            <td><strong>grond in km2</strong></td>
            <td><strong>Datum Opgericht</strong></td>
        </tr>
        <?php
        require "Provincie.php";
        $provinces = Provincie::selectProvincies();
        foreach($provinces as $province)
        {
        echo "<tr>";
        echo "<td>" . $province->id . "</td>";
        echo "<td>" . $province->naam . "</td>";
        echo "<td>" . $province->hoofdstad . "</td>";
        echo "<td>" . $province->populatie . "</td>";
        echo "<td>" . $province->grond . "</td>";
        echo "<td>" . $province->datum . "</td>";
        echo "</tr>";
        }



        ?>
    </table>
</body>