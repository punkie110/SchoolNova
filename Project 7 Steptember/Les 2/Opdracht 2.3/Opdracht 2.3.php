<head>


</head>
<body>
<?php
require "Winkelwagen.php";
$wagentje = new winkelwagen();
$wagentje->voegProductToe("Cola", 19, 8);
$wagentje->voegProductToe("Chocolade", 30, 12);
$wagentje->voegProductToe("Brood", 4, 2);
$wagentje->voegProductToe("Smeerworst", 10, 3);
$wagentje->voegProductToe("appelsap", 5, 10);
echo $wagentje->totaalBedrag();
?>
</body>