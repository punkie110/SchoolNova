<?php
class Reservering
{
    public int $reserveringsnummer;
    public string $klantnummer;
    public  $aankomstdatum;
    public  $vertrekdatum;
    public string $nachten;
    public string $plaats;

//Voegt een klant toe aan de database.
    public function insert()
{
    require_once "Database.php";

    $conn = database::start();


    $klantnummer = mysqli_real_escape_string($conn, $this->klantnummer);
    $aankomstdatum = mysqli_real_escape_string($conn, $this->aankomstdatum);
    $vertrekdatum = mysqli_real_escape_string($conn, $this->vertrekdatum);
    $nachten = mysqli_real_escape_string($conn, $this->nachten);
    $plaats = mysqli_real_escape_string($conn, $this->plaats);

    $sql = "INSERT INTO reserveringen (
        klantnummer,
        Aankomstdatum,
        Vertrekdatum,
        Nachten,
        Plaats
        ) VALUES (
        '" . $klantnummer . "',
        '" . $aankomstdatum . "',
        '" . $vertrekdatum . "',
        '" . $nachten . "',
        '" . $plaats . "'
    )";

    $conn->query($sql);
    $conn->close();
}
public static function findAll()
{
    require_once "Database.php";
    $reserveringen = [];

    $conn = Database::Start();

    // Haal alle reserveringen op uit de database
    $query = "SELECT * FROM reserveringen";
    $resultaat = $conn->query($query);

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $reservering = new Reservering();
            $reservering->reserveringsnummer = $row["Reserveringsnummer"];
            $reservering->klantnummer = $row["Klantnummer"];
            $reservering->aankomstdatum = $row["Aankomstdatum"];
            $reservering->vertrekdatum = $row["Vertrekdatum"];
            $reservering->nachten = $row["Nachten"];
            $reservering->plaats = $row["Plaats"];
            $reserveringen[] = $reservering;
        }
    }
    $conn->close();

    return $reserveringen;
}
public static function findAllByPlaats($plaats)
{
    require_once "Database.php";

    $conn = database::start();


    $sql = "SELECT * FROM reserveringen WHERE plaats = '$plaats'";
    $resultaat = $conn->query($sql);

    $reserveringen = [];

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $reservering = new Reservering();
            $reservering->reserveringsnummer = $row["Reserveringsnummer"];
            $reservering->klantnummer = $row["Klantnummer"];
            $reservering->aankomstdatum = $row["Aankomstdatum"];
            $reservering->vertrekdatum = $row["Vertrekdatum"];
            $reservering->nachten = $row["Nachten"];
            $reservering->plaats = $row["Plaats"];
            $reserveringen[] = $reservering;

        }
    }

 
    $conn->close();
    return $reserveringen;
}
}
?>