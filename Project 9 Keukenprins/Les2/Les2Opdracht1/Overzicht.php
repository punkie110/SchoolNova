<?php
require "Stad.php";
require "Database.php";
$steden = Stad::getSteden();
?>

<head>

</head>

<body>
    <table>
        <thead>

        </thead>
        <tbody>
            <?php
            foreach ($steden as $stad) {
            ?>

                <tr>
                    <td> <?= $stad->id ?>
                    <td>
                    <td> <?= $stad->naam ?>
                    <td>
                    <td><a href="Detail.php?id=<?= $stad->id; ?>">Bekijk</a></td>

                <tr>
                <?php
            }
                ?>
        </tbody>
    </table>
</body>