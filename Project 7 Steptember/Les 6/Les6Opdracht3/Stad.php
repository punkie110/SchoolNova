<?php
class Stad
{
    public int $id;
    public string $name;
    public string $capital;
    public int $population;
    public float $area;
    public $date;

    public function voegToe()
    {
       
        require "Les6Opdracht3.php";
        $name = mysqli_real_escape_string($conn, $this->name);
        $capital = mysqli_real_escape_string($conn, $this->capital);
        $population = mysqli_real_escape_string($conn, $this->population);
        $area = mysqli_real_escape_string($conn, $this->area);
        $date = mysqli_real_escape_string($conn, $this->date);
        $sql = "INSERT INTO provinces (province_name, province_capital, province_population, province_area_km2, province_foundation_date ) VALUES ('$name', '$capital', '$population', '$area', '$date')";
        $resultaat = $conn->query($sql);
        return $resultaat;
    }
    
    public static function alleSteden()
    {
        require "Les6Opdracht3.php";
        $sql = "SELECT * FROM provinces";
        $resultaat = $conn->query($sql);
        $provinces = [];
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $province = new Stad();
                $province->id = $row["province_id"];
                $province->name = $row["province_name"];
                $province->capital = $row["province_capital"];
                $province->population = $row["province_population"];
                $province->area = $row["province_area_km2"];
                $province->date = $row["province_foundation_date"];
                $provinces[] = $province;
            }
        }
        return $provinces;
    }
}
