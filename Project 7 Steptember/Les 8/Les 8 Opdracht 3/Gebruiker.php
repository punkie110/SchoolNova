<?php
class Gebruiker
{
    public $username;
    public $password;
    public $id;
    public $voornaam;
    public $achternaam;
    public static function checkUser()
    {
        $gebruiker = null;
        require "Connectie.php";
        $username = mysqli_real_escape_string($conn, $username);
        $password = mysqli_real_escape_string($conn, $password);
        $query = "SELECT * FROM users WHERE user_username = '$username' AND user_password = '$password'";
        $resultaat = $conn->query($query);
        if ($resultaat->num_rows > 0) {
            $row = $resultaat->fetch_assoc();
            $gebruiker = new Gebruiker();
            $gebruiker->id = $row["user_id"];
            $gebruiker->voornaam = $row["user_firstname"];
            $gebruiker->achternaam = $row["user_lastname"];
            $gebruiker->username = $row["user_username"];
            $gebruiker->password = $row["user_password"];
        } else {
            $gebruiker = "Je gebruikersnaam en wachtwoord zijn ongeldig.";
        }
        $conn->close();
        return $gebruiker;
    }
}
