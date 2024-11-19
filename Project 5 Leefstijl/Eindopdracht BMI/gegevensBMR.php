<?php
class gegevensBMR
{
    // zelfde riedeltje als berekenBMI alleen nog een if-statement voor de radiobuttons
    public $Leeftijd;
    public $Lengte;
    public $Gewicht;
    public $Gender;

    public function validate()
    {
      if(!is_numeric($this->Lengte))
      {
            return false;
      }

      if(!is_numeric($this->Gewicht))
      {
            return false;
      }
      if(!is_numeric($this->Leeftijd))
      {
        return false;
      }
      if(!isset($this->Gender))
      {
        return false;
      }
        return true;
    }
    
    public function berekenBMR()
    {
        if ($this->Gender == "man") {
            return (((13.7516 * $this->Gewicht) + (5.0033 * $this->Lengte) - (6.755 * $this->Leeftijd)) + 66.473);
        } else if ($this->Gender == "vrouw") {
            return (((9.5634 * $this->Gewicht) + (1.8496 * $this->Lengte) - (4.6756 * $this->Leeftijd)) + 655.0955);
        }
    }
    public function berekenBMRFormatted()
    {

        $bmr = $this->berekenBMR();
        $bmr = number_format($bmr, 2);
        if ($this->Gender == "man"){
        $result = "BMR: BMR-waarde(man) is: $bmr kcal per dag.";
        }
        else if($this->Gender == "vrouw"){
            $result = "BMR: BMR-waarde(vrouw) is: $bmr kcal per dag.";
        }

        return $result;
    }
}
