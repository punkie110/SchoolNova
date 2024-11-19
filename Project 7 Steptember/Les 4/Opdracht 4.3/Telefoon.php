<?php

class Telefoon
{
    public int $id;
    public string $merk;
    public string $type;
    public int $opslag;
    public float $grootte;
    public int $resolutie;
    public float $prijs;
    public $datum;
public static function alleTelefoons()
{
    require "Opdracht 4.3.php";
    $sql = "SELECT * FROM phones";
    $resultaat = $conn->query($sql);
    $telefoons = [];
    if($resultaat->num_rows > 0)
    {
        while($row = $resultaat->fetch_assoc())
        {
            $telefoon = new telefoon();
            $telefoon->id = $row["phone_id"];
            $telefoon->merk = $row["phone_brand"];
            $telefoon->type = $row["phone_type"];
            $telefoon->opslag = $row["phone_storage_capacity"];
            $telefoon->grootte = $row["phone_display_size"];
            $telefoon->resolutie = $row["phone_camera_resolution"];
            $telefoon->prijs = $row["phone_price"];
            $telefoon->datum = $row["phone_release_date"];
            $telefoons[] = $telefoon;
        }      
    }
    return $telefoons;
}
}