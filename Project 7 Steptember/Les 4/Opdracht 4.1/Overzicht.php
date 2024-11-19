<head>

</head>
<body>
<?php
require "Opdracht 4.1.php";
$sql = "SELECT * FROM cars";
$resultaat = $conn->query($sql);
if ($resultaat->num_rows > 0)
{
    echo "<table border='1'>";
    echo "<tr><td>ID</td><td>car brand</td><td>car type</td><td>car color</td></tr>";
while ($row = $resultaat->fetch_assoc())
 {
    echo "<tr>";
    echo "<td>" . $row["car_id"] . "</td>";
    echo "<td>" . $row["car_brand"] . "</td>";
    echo "<td>" . $row["car_type"] . "</td>";
    echo "<td>" . $row["car_color"] . "</td>";
    echo "</tr>";

}
    echo "</table>";
}
?>
</body> 
