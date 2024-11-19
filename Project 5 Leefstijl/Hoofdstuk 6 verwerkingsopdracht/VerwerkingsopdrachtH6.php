<?php
$dag = array("Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag");
$aantal = array(11214, 10514, 11250, 10552, 10501, 10316, 12016);
$count = count($aantal);
$gemiddelde = array_sum($aantal) / $count;
for($i = 0; $i < $count; $i++)
{
    if($aantal[$i] > $gemiddelde)
    {
        echo "<table>
        <tr>
        <td> $dag[$i] </td>
        <td> $aantal[$i] </td>
        </tr>
        </table>";
    }
}
?>