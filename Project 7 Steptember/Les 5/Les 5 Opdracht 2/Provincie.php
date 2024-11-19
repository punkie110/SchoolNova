<?php
class Provincie
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
    
    public static function selectProvincies()
    {
        require "Les5Opdracht2.php";
        require "Form.php";
        $inwonersAantal = $_POST["Invoerveld"];
        $sql = "SELECT * FROM provinces WHERE province_population >= $inwonersAantal";
        $resultaat = $conn->query($sql);
        $provinces = [];
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $province = new provincie();
                $province->id = $row["province_id"];
                $province->naam = $row["province_name"];
                $province->hoofdstad = $row["province_capital"];
                $province->populatie = $row["province_population"];
                $province->grond = $row["province_area_km2"];
                $province->datum = $row["province_foundation_date"];
                $provinces[] = $province;
            }
        }
        return $provinces;
       
    }
}
