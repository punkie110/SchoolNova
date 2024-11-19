<?php
class Stap
{
    public $id;
    public $gebruikerId;
    public $datum;
    public $totaleStappen;

    //een functie die stappen ophaalt uit de database op basis van een gebruiker dmv het ID.
    public static function vindStappen($gebruikerId)
    {
        $stappen = [];
        include "Connectie.php";

        $gebruikerId = mysqli_real_escape_string($conn, $gebruikerId);
        $query = "SELECT * FROM steps WHERE step_user_id = '$gebruikerId'";

        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $stap = new Stap();
                $stap->id = $row["step_id"];
                $stap->gebruikerId = $row["step_user_id"];
                $stap->datum = $row["step_date"];
                $stap->totaleStappen = $row["step_total"];
                $stappen[] = $stap;
            }
        }
        $conn->close();

        return $stappen;
    }
    //een functie die totale stappen uitrekent.
    public static function stappenTotaal($stappen)
    {
        $alleStappen = 0;

        foreach ($stappen as $stap) {
            $alleStappen += $stap->totaleStappen;
        }

        return $alleStappen;
    }
    //een functie die de gemiddelde stappen uitrekent.
    public static function gemiddeldeStappen($stappen)
    {
        $gemiddeldeStappen = 0;

        $alleStappen = Stap::stappenTotaal($stappen);
        $hoeveelheidStappen = count($stappen);
        if ($hoeveelheidStappen != 0) {
            $gemiddeldeStappen = $alleStappen / $hoeveelheidStappen;
        }
        return $gemiddeldeStappen;
    }
}
