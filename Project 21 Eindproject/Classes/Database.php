<?php
//Een database connectie die wordt gebruikt door het project heen om de benodigde data op te halen. 
class Database
{
    public static function Start()
    {
        $dbServername = "127.0.0.1";
        $dbUsername = "root";
        $dbPassword = "";
        $dbDatabase = "eindproject";

        $conn = new mysqli($dbServername, $dbUsername, $dbPassword, $dbDatabase);

        if ($conn->connect_error) {
            die("connectie mislukt:" . $conn->connect_error);
        }
        return $conn;
    }
}
