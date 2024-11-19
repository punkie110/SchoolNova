<?php
class Customer
{

 //hier worden de variabelen gedeclareerd.
    public $id;
    public $firstname;
    public $lastname;
    public $address;
    public $zipcode;
    public $city;
    public $email;

    //een findall functie om alle klanten op te halen.
    public static function findAll()
    {
        $customers = [];

        $conn = Database::Start();

        $query = "SELECT * FROM customers";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $customer = new Customer();
                $customer->id = $row["customer_id"];
                $customer->firstname = $row["customer_firstname"];
                $customer->lastname = $row["customer_lastname"];
                $customer->address = $row["customer_address"];
                $customer->zipcode = $row["customer_zipcode"];
                $customer->city = $row["customer_city"];
                $customer->email = $row["customer_email"];
                $customers[] = $customer;
            }
        }
        $conn->close();

        return $customers;
    }

    //een findOne functie om een klant op te halen op basis van ID.
    public static function findOne($id)
    {

        $customer = new Customer();

        $conn = Database::Start();

        $query = "SELECT * FROM customers WHERE customer_id = '$id'";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {

                $customer->id = $row["customer_id"];
                $customer->firstname = $row["customer_firstname"];
                $customer->lastname = $row["customer_lastname"];
                $customer->address = $row["customer_address"];
                $customer->zipcode = $row["customer_zipcode"];
                $customer->city = $row["customer_city"];
                $customer->email = $row["customer_email"];
            }
        }
        $conn->close();

        return $customer;
    }
}
