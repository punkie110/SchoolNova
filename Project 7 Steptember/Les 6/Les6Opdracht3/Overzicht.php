<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>ID</strong></td>
            <td><strong>Provincie</strong></td>
            <td><strong>Hoofdstad</strong></td>
            <td><strong>Populatie</strong></td>
            <td><strong>Grootte in km2</strong></td>
            <td><strong>Oprichtdatum</strong></td>
        </tr>
        <?php
        require "Stad.php";
        $provinces = new Stad();
        $provinces->name = $_POST["provincieNaam"];
        $provinces->capital = $_POST["hoofdstad"];
        $provinces->population = $_POST["populatie"];
        $provinces->area = $_POST["grootte"];
        $provinces->date = $_POST["oprichtdatum"];
        $provinces->voegToe();

        $provincies = Stad::alleSteden();
        
        foreach ($provincies as $province) {
            echo "<tr>";
            echo "<td>" . $province->id . "</td>";
            echo "<td>" . $province->name . "</td>";
            echo "<td>" . $province->capital . "</td>";
            echo "<td>" . $province->population . "</td>";
            echo "<td>" . $province->area . "</td>";
            echo "<td>" . $province->date . "</td>";
            echo "</tr>";
        }



        ?>
    </table>
</body>