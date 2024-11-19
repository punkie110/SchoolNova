<?php

class Gebruiker
{
    public  $id;
    public  $naam;
    public  $achternaam;
    public  $gebruikersnaam;
    public  $email;
    public  $wachtwoord;
    public  $admin;
    public  $foto;


    //Voegt een gebruiker toe aan de database.
    public function addGebruiker()
{
    require_once "Database.php";

    $conn = database::start();


    $naam = mysqli_real_escape_string($conn, $this->naam);
    $achternaam = mysqli_real_escape_string($conn, $this->achternaam);
    $gebruikersnaam = mysqli_real_escape_string($conn, $this->gebruikersnaam);
    $email = mysqli_real_escape_string($conn, $this->email);
    $wachtwoord = mysqli_real_escape_string($conn, $this->wachtwoord);
    $foto = mysqli_real_escape_string($conn, $this->foto);

    $sql = "INSERT INTO gebruikers (
        gebruiker_voornaam,
        gebruiker_achternaam,
        gebruiker_email,
        gebruiker_username,
        gebruiker_password,
        gebruiker_image
        ) VALUES (
        '" . $naam . "',
        '" . $achternaam . "',
        '" . $email . "',
        '" . $gebruikersnaam . "',
        '" . $wachtwoord . "',
        '" . $foto . "'
    )";

    $conn->query($sql);
}


//Haalt een gebruiker op op basis van het meegegeven gebruikersnaam en wachtwoord.
public static function findByUsernameAndPassword($username, $password)
{
    require_once "Database.php";

    $conn = database::start();


    $sql = "SELECT * FROM gebruikers WHERE gebruiker_username = '$username' AND gebruiker_password  = '$password'";
    $resultaat = $conn->query($sql);

    $users = [];

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $user = new Gebruiker();
            $user->id = $row["gebruiker_id"];
            $user->naam = $row["gebruiker_voornaam"];
            $user->achternaam = $row["gebruiker_achternaam"];
            $user->gebruikersnaam = $row["gebruiker_username"];
            $user->email = $row["gebruiker_email"];
            $user->wachtwoord = $row["gebruiker_password"];
            $user->admin = $row["gebruiker_admin"];

            $conn->close();
            $users[] = $user;
        }
    }

    if (count($users) > 0) {
        return $users[0];
    } else {
        return null;
    }
}

//Haalt een gebruiker op op basis van ID.
public static function findById($userID)
{
    require_once "Database.php";

    $conn = database::start();


    $sql = "SELECT * FROM gebruikers WHERE gebruiker_id = '$userID'";
    $resultaat = $conn->query($sql);

    $users = [];

    if ($resultaat->num_rows > 0) {
        while ($row = $resultaat->fetch_assoc()) {
            $user = new Gebruiker();
            $user->id = $userID;
            $user->naam = $row["gebruiker_voornaam"];
            $user->achternaam = $row["gebruiker_achternaam"];
            $user->gebruikersnaam = $row["gebruiker_username"];
            $user->email = $row["gebruiker_email"];
            $user->wachtwoord = $row["gebruiker_password"];
            $user->admin = $row["gebruiker_admin"];
            $user->foto = $row["gebruiker_image"];

            $conn->close();
            $users[] = $user;
        }
    }

    if (count($users) > 0) {
        return $users[0];
    } else {
        return null;
    }
}

 //een update functie die een blog met nieuwe waardes update.
 public function update()
 {
     $gebruiker = null;

     $conn = Database::Start();
     $gebruiker = new Gebruiker();

     $id = mysqli_real_escape_string($conn, $this->id);
     $naam = mysqli_real_escape_string($conn, $this->naam);
     $foto = mysqli_real_escape_string($conn, $this->foto);
     $email = mysqli_real_escape_string($conn, $this->email);
     $admin = mysqli_real_escape_string($conn, $this->admin);
     $achternaam = mysqli_real_escape_string($conn, $this->achternaam);
     $gebruikersnaam = mysqli_real_escape_string($conn, $this->gebruikersnaam);
     $wachtwoord = mysqli_real_escape_string($conn, $this->wachtwoord);

     $query = "UPDATE gebruikers SET gebruiker_voornaam = '" . $naam . "', 
     gebruiker_image = '" . $foto . "', gebruiker_email = '" . $email . "', 
     gebruiker_username = '" . $gebruikersnaam . "', gebruiker_password = '" . $wachtwoord . "', 
     gebruiker_achternaam = '" . $achternaam . "', gebruiker_admin = '" . $admin . "'
     WHERE gebruiker_id = '" . $id . "'";

     $conn->query($query);
     $conn->close();
 }
 //Een functie die alle gebruikers ophaalt uit de database.
 public static function findAll()
 {
    require_once "Database.php";

     $gebruikers = [];

     $conn = Database::Start();

     $query = "SELECT * FROM gebruikers";
     $resultaat = $conn->query($query);

     if ($resultaat->num_rows > 0) {
         while ($row = $resultaat->fetch_assoc()) {
             $gebruiker = new Gebruiker();
             $gebruiker->id = $row["gebruiker_id"];
             $gebruiker->naam = $row["gebruiker_voornaam"];
             $gebruiker->achternaam = $row["gebruiker_achternaam"];
             $gebruiker->gebruikersnaam = $row["gebruiker_username"];
             $gebruiker->email = $row["gebruiker_email"];
             $gebruiker->wachtwoord = $row["gebruiker_password"];
             $gebruiker->admin = $row["gebruiker_admin"];
             $gebruiker->foto = $row["gebruiker_image"];
             $gebruikers[] = $gebruiker;

         }
     }
     $conn->close();

     return $gebruikers;
 }
 public function delete()
 {
     $conn = Database::Start();

     $id = mysqli_real_escape_string($conn, $this->id);
     $query = "DELETE FROM gebruikers WHERE gebruiker_id = '" . $id . "'";

     $conn->query($query);
     $conn->close();
 }
}




