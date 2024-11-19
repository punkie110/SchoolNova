<?php
require "Provincie.php";
require "Database.php";
$provincies = Provincie::findAll();
?>

<head>

</head>

<body>
    <table>
        <thead>

        </thead>
        <tbody>
            <?php
            foreach ($provincies as $provincie) {
            ?>

                <tr>
                    <td> <?= $provincie->id ?>
                    <td>
                    <td> <?= $provincie->naam ?>
                    <td>
                    <td><a href="Aanpassen.php?id=<?= $provincie->id; ?>">Bekijk</a></td>
                    <td><a href="Verwijderen.php?id=<?= $provincie->id; ?>">Verwijder</a></td>

                <tr>
                <?php
            }
                ?>
        </tbody>
    </table>
</body>