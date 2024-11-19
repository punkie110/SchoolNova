<?php
class Sessie
{
    public $id;
    public $userId;
    public $key;
    public $start;
    public $end;

    //een vindSessies functie die sessiegegevens meegeeft als er een cookie bestaat.
    public static function vindSessies()
    {
        $sessie = null;

        if (isset($_COOKIE["eindproject-session"])) {

            require_once "Database.php";
            $conn = Database::Start();
            $key = mysqli_real_escape_string($conn, $_COOKIE["eindproject-session"]);

            $query = "SELECT * FROM sessies WHERE sessie_key = '$key' AND sessie_eind > '" . date("Y-m-d H:i:s") . "'";

            $resultaat = $conn->query($query);
            if ($resultaat->num_rows > 0) {
                $row = $resultaat->fetch_assoc();
                $sessie = new Sessie();
                $sessie->id = $row["sessie_id"];
                $sessie->userId = $row["sessie_user_id"];
                $sessie->key = $row["sessie_key"];
                $sessie->start = $row["sessie_start"];
                $sessie->end = $row["sessie_eind"];
            }
            $conn->close();
        }
        return $sessie;
    }

    //een functie die een nieuwe sessie implementeert in de database.
    public function newSessie()
    {
        require_once "Database.php";
        $conn = Database::Start();
        $userId = mysqli_real_escape_string($conn, $this->userId);
        $key = mysqli_real_escape_string($conn, $this->key);
        $start = mysqli_real_escape_string($conn, $this->start);
        $end = mysqli_real_escape_string($conn, $this->end);

        $sql = "INSERT INTO sessies (sessie_user_id, sessie_key, sessie_start, sessie_eind) VALUES ( '$userId', '$key', '$start', '$end')";

        $resultaat = $conn->query($sql);
        $conn->Close();
        return $resultaat;
    }
    //Haalt een sessie op op basis van de sessie key.
    public static function getSession($key)
    {
        require_once "database.php";
        $conn = Database::Start();
        $key = mysqli_real_escape_string($conn, $key);
        $session = new Sessie();
        $sql = "SELECT * FROM sessies WHERE sessie_key = '$key'";
        $resultaat = $conn->query($sql);

        $sessions = [];

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $session->id = $row["sessie_user_id"];
                $session->key = $id;
                $session->start = $row["sessie_start"];
                $session->end = $row["sessie_eind"];
            }
        }
        $conn->close();

        return $session;
    }
    //Haalt de huidige sessie op.
public static function getThisSession()
{
    if (!isset($_COOKIE["eindproject-session"])) {
        return null; // Sessie bestaat niet, dus we kunnen geen gebruiker ophalen.
    }

    require_once "database.php";
    $conn = Database::Start();

    $session = new Sessie();
    $sessionKey = mysqli_real_escape_string($conn, $_COOKIE["eindproject-session"]);

    $sql = "SELECT * FROM sessies WHERE sessie_key = '$sessionKey' AND sessie_eind > '" . date("Y-m-d H:i:s") . "'";
    $resultaat = $conn->query($sql);

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $session->id = $row["sessie_user_id"];
            $session->key = $row["sessie_key"];
            $session->start = $row["sessie_start"];
            $session->end = $row["sessie_eind"];
        }
    } else {
        $session = null; // Geen actieve sessie gevonden.
    }

    $conn->close();

    return $session;
}
    //Verwijderd een sessie uit de database.
    public function deleteSession()
    {
        require_once "database.php";
        $conn = Database::Start();

        $sql = "DELETE FROM sessies WHERE sessie_key = '" . mysqli_real_escape_string($conn, $this->key) . "'";
        $resultaat = $conn->query($sql);

        $conn->close();

        return $resultaat;
    }
}
