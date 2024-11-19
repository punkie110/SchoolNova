<?php
$prijs = 0;
$totaal = 0;
echo "<TABLE>
<TR>
<TD>aantal tafels en stoelen</TD>
<TD>prijs per stuk</TD>
</TR>
<TR>
<TD>minder dan 10</TD>
<TD>20 euro</TD>
</TR>
<TR>
<TD>10 tot 40</TD>
<TD>18,50 euro</TD>
</TR>
<TR>
<TD>41 tot 60</TD>
<TD>17,50 euro</TD>
</TR>
<TR>
<TD>meer dan 60</TD>
<TD>15 euro</TD>
</TR>
</TABLE>";

switch($aantal = 33)
{
case $aantal < 10:
    $prijs = 20;
    break;
    case $aantal >= 10 && $aantal <= 40:
        $prijs = 18.50;
        break;
        case $aantal > 40 && $aantal <= 60:
            $prijs = 17.50;
            break;
            case $aantal > 60:
                $prijs = 15;
                break;
}
$totaal = $aantal * $prijs;
echo "U hebt een bestelling geplaatst. Het aantal is $aantal. de prijs is $prijs p/s. U betaalt in totaal $totaal Euro."
?>