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
        $doeIets = true;
        require "Auto.php";
        require "Opdracht 4.2.php";
        $merk = "Daihatsu";
        $type = "Copen";
        $kleur = "Rood";
        $sql = "INSERT INTO cars (car_brand, car_type, car_color, car_id) VALUES ( ' $merk ', ' $type ', '$kleur')";
        $conn->query($sql);
        ?>
    </table>
</body>