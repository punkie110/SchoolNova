<?php

class Plaats
{
    public  $id;
    public  $type;
    public  $prijs;
    public  $top;
    public  $left;
    public  $rotation;
    public static function findById($ID)
    {
        require_once "Database.php";

        $conn = database::start();


        $sql = "SELECT * FROM plekken WHERE Plek_id = '$ID'";
        $resultaat = $conn->query($sql);

        $plekken = [];

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $plek = new Plaats();
                $plek->id = $ID;
                $plek->type = $row["plek_type"];
                $plek->prijs = $row["plek_prijs"];
                $plek->top = $row["plek_top"];
                $plek->left = $row["plek_left"];
                $plek->rotation = $row["plek_rotation"];

                $conn->close();
                $plekken[] = $plek;
            }
        }

        if (count($plekken) > 0) {
            return $plekken[0];
        } else {
            return null;
        }
    }
    public static function findAll()
    {
       require_once "Database.php";
   
        $plekken = [];
   
        $conn = Database::Start();
   
        $query = "SELECT * FROM plekken";
        $resultaat = $conn->query($query);
   
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $plek = new Plaats();
                $plek->id = $row["Plek_id"];
                $plek->type = $row["plek_type"];
                $plek->prijs = $row["plek_prijs"];
                $plek->top = $row["plek_top"];
                $plek->left = $row["plek_left"];
                $plek->rotation = $row["plek_rotation"];
                $plekken[] = $plek;
   
            }
        }
        $conn->close();
   
        return $plekken;
    }
}
