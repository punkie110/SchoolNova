<?php
class province
{
    public int $id;
    public string $naam;
    public string $hoofdstad;
    public int $populatie;
    public float $grond;
    public $datum;
    public function starten()
    {
    }

    public function insertProvinces()
    {
        require "Les6Opdracht2.php";
        $sql = "INSERT INTO provinces (province_name, province_capital, province_population, province_area_km2, province_foundation_date) VALUES ( ' $this->naam ', ' $this->hoofdstad ', '$this->populatie', '$this->grond', '$this->datum')";
        $resultaat = $conn->query($sql);
        return $resultaat;
    }

}

