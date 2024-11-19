<?php
class Klant
{
    public int $id;
    public string $voornaam;
    public string $achternaam;
    public string $email;
    public string $adres;

//Voegt een klant toe aan de database.
    public function insert()
{
    require_once "Database.php";

    $conn = database::start();


    $voornaam = mysqli_real_escape_string($conn, $this->voornaam);
    $achternaam = mysqli_real_escape_string($conn, $this->achternaam);
    $email = mysqli_real_escape_string($conn, $this->email);
    $adres = mysqli_real_escape_string($conn, $this->adres);

    $sql = "INSERT INTO klanten (
        klant_voornaam,
        klant_achternaam,
        klant_email,
        klant_adres
        ) VALUES (
        '" . $voornaam . "',
        '" . $achternaam . "',
        '" . $email . "',
        '" . $adres . "'
    )";

    $conn->query($sql);
    $conn->close();
}
public static function findAll()
{
   require_once "Database.php";

    $klanten = [];

    $conn = Database::Start();

    $query = "SELECT * FROM klanten";
    $resultaat = $conn->query($query);

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $klant = new Klant();
            $klant->id = $row["klantnummer"];
            $klant->voornaam = $row["klant_voornaam"];
            $klant->achternaam = $row["klant_achternaam"];
            $klant->email = $row["klant_email"];
            $klant->adres = $row["klant_adres"];
            $klanten[] = $klant;

        }
    }
    $conn->close();

    return $klanten;
}
}
?>