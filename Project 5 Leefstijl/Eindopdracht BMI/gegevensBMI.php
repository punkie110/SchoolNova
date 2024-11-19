<?php
class gegevensBMI
{
    public $Lengte;
    public $Gewicht;
    //   Een functie die controleert of Lengte en gewicht numeriek zijn. 
    public function validate()
    {
        if (!is_numeric($this->Lengte)) {
            // returned false als hij niet numeriek is, anders true.
            return false;
        }

        if (!is_numeric($this->Gewicht)) {
            return false;
        }

        return true;
    }
    // een simpele berekenBMI functie die wordt gebruikt in de berekenBMIFormatted functie
    public function berekenBMI()
    {
        return $this->Gewicht / ($this->Lengte * $this->Lengte);
    }
    public function berekenBMIFormatted()
    {
        // Formateert gelijk de variabele bmi naar twee decimalen. 
        $bmi = $this->berekenBMI();
        $bmi = number_format($bmi, 2);

        // een if statement waar hij kijkt naar hoeveel bmi is en het in de juiste if statement plaatst.
        $result = "BMI : Je BMI is $bmi";
        if ($bmi <= 18.5) {
            $result .= ". Je hebt ondergewicht<br />";
            $result .= '<img src = "Images/ErikOndergewicht.jpg">';
        } elseif ($bmi > 18.5 && $bmi <= 24.9) {
            $result .= ". Je hebt normaal gewicht<br />";
            $result .= '<img src = "Images/erik.jpg">';
        } elseif ($bmi > 24.9 && $bmi <= 29.9) {
            $result .= ". Je hebt overgewicht<br />";
            $result .= '<img src = "Images/ErikOvergewicht.jpg">';
        } elseif ($bmi > 29.9 && $bmi <= 34.9) {
            $result .= ". Je hebt Obesitas<br />";
            $result .= '<img src = "Images/ErikObesitas.jpg">';
        } else {
            $result .= ". Je hebt zware Obesitas<br />";
            $result .= '<img src = "Images/ErikZwareObesitas.jpg">';
        }

        return $result;
    }
}
