<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>ID</strong></td>
            <td><strong>Merk</strong></td>
            <td><strong>Model</strong></td>
            <td><strong>Processor</strong></td>
            <td><strong>ram</strong></td>
            <td><strong>opslag</strong></td>
            <td><strong>displaygrootte</strong></td>
            <td><strong>prijs</strong></td>
            <td><strong>release datum</strong></td>
        </tr>
        <?php
        require "Laptop.php";
        $laptops = Laptop::selectLaptops();
        foreach($laptops as $laptop)
        {
        echo "<tr>";
        echo "<td>" . $laptop->id . "</td>";
        echo "<td>" . $laptop->merk . "</td>";
        echo "<td>" . $laptop->model . "</td>";
        echo "<td>" . $laptop->processor . "</td>";
        echo "<td>" . $laptop->ram . "</td>";
        echo "<td>" . $laptop->opslag . "</td>";
        echo "<td>" . $laptop->display . "</td>";
        echo "<td>" . $laptop->prijs . "</td>";
        echo "<td>" . $laptop->release . "</td>";
        echo "</tr>";
        }



        ?>
    </table>
</body>