<?php
class Gebruiker
{
    public $username;
    public $password;
    public $id;
    public $voornaam;
    public $achternaam;
    public $email;

    //een functie die checkt of de gebruikersnaam en wachtwoord overeenkomt met het gebruikersnaam en wachtwoord in de database.
    public static function checkUser($username, $password)
    {
        $gebruiker = null;

        require "Connectie.php";

        $username = mysqli_real_escape_string($conn, $username);
        $password = mysqli_real_escape_string($conn, $password);

        $query = "SELECT * FROM users WHERE user_username = '$username' AND user_password = '$password'";
        $resultaat = $conn->query($query);

        //slaat gelijk de gegevens op van de ingelogde gebruiker vanuit de database.
        if ($resultaat->num_rows > 0) {
            $row = $resultaat->fetch_assoc();
            $gebruiker = new Gebruiker();
            $gebruiker->id = $row["user_id"];
            $gebruiker->voornaam = $row["user_firstname"];
            $gebruiker->achternaam = $row["user_lastname"];
            $gebruiker->username = $row["user_username"];
            $gebruiker->password = $row["user_password"];
        }

        $conn->close();
        return $gebruiker;
    }

    //een functie met een parameter "id" om op te halen om welke gebruiker het gaat op basis van id.
    public static function getUser($id)
    {
        $gebruiker = null;

        require "Connectie.php";

        $id = mysqli_real_escape_string($conn, $id);

        $query = "SELECT * FROM users WHERE user_id = '$id'";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            $row = $resultaat->fetch_assoc();
            $gebruiker = new Gebruiker();
            $gebruiker->id = $row["user_id"];
            $gebruiker->voornaam = $row["user_firstname"];
            $gebruiker->achternaam = $row["user_lastname"];
            $gebruiker->email = $row["user_email"];
        }

        $conn->close();
        return $gebruiker;
    }
}
