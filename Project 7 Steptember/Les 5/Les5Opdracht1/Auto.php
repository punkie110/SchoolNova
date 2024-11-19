<?php
class Auto
{
    public int $id;
    public string $merk;
    public string $type;
    public string $kleur;

    public function starten()
    {

    }
    
    public static function alleAutos()
    {
        require "Opdracht 4.2.php";
        $sql = "SELECT * FROM cars";
        $resultaat = $conn->query($sql);
        $autos = [];
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $auto = new auto();
                $auto->merk = $row["car_brand"];
                $auto->type = $row["car_type"];
                $auto->kleur = $row["car_color"];
                $auto->id = $row["car_id"];
                $autos[] = $auto;
            }
        }
        return $autos;
    }
}
