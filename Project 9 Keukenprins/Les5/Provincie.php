<?php
class Provincie
{
    public $id;
    public $naam;
    public $hoofdstad;
    public $populatie;
    public $oppervlakte;
    public $oprichtdatum;
    public static function findAll()
    {
        $provincies = [];
        $conn = Database::Start();
        $query = "SELECT * FROM provinces";
        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $provincie = new Provincie();
                $provincie->id = $row["province_id"];
                $provincie->naam = $row["province_name"];
                $provincies[] = $provincie;
            }
        }
        $conn->close();

        return $provincies;
    }

    public static function getOne($id)
    {
        $provincie = null;
        $conn = Database::Start();
        $query = "SELECT * FROM provinces WHERE province_id = '$id'";
        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $provincie = new Provincie();
                $provincie->id = $row["province_id"];
                $provincie->naam = $row["province_name"];
                $provincie->hoofdstad = $row["province_capital"];
                $provincie->populatie = $row["province_population"];
                $provincie->oppervlakte = $row["province_area_km2"];
                $provincie->oprichtdatum = $row["province_foundation_date"];
            }
        }
        $conn->close();

        return $provincie;
    }

    public function update()
    {
        $provincie = null;
        $conn = Database::Start();
        $provincie = new Provincie();
        $id = mysqli_real_escape_string($conn, $this->id);
        $naam = mysqli_real_escape_string($conn, $this->naam);
        $hoofdstad = mysqli_real_escape_string($conn, $this->hoofdstad);
        $populatie = mysqli_real_escape_string($conn, $this->populatie);
        $oppervlakte = mysqli_real_escape_string($conn, $this->oppervlakte);
        $oprichtdatum = mysqli_real_escape_string($conn, $this->oprichtdatum);
        $query = "UPDATE provinces SET province_name = '" . $naam . "', 
        province_capital = '" . $hoofdstad . "', province_population = '" . $populatie . "', 
        province_area_km2 = '" . $oppervlakte . "', 
        province_foundation_date = '" . $oprichtdatum . "' WHERE province_id = '" . $id . "'";
        $conn->query($query);
        $conn->close();
    }
}
