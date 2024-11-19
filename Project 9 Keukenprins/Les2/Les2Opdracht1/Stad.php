<?php

class Stad
{

    public $id;
    public $naam;
    public $populatie;
    public $provincie;
    public $burgemeester;
    public $oprichtdatum;
    public static function getSteden()
    {
        $steden = [];
        $conn = Database::Start();
        $query = "SELECT * FROM cities";

        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $stad = new Stad();
                $stad->id = $row["city_id"];
                $stad->naam = $row["city_name"];
                $steden[] = $stad;
            }
        }
        $conn->close();

        return $steden;
    }

    public static function getStad($id)
    {
        $stad = null;
        $conn = Database::Start();
        $query = "SELECT * FROM cities WHERE city_id = '$id'";
        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $stad = new Stad();
                $stad->id = $row["city_id"];
                $stad->naam = $row["city_name"];
                $stad->populatie = $row["city_population"];
                $stad->provincie = $row["city_province"];
                $stad->burgemeester = $row["city_mayor"];
                $stad->oprichtdatum = $row["city_foundation_date"];
            }
        }
        $conn->close();

        return $stad;
    }
}
