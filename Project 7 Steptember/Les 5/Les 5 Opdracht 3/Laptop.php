<?php
class Laptop
{
    public int $id;
    public string $merk;
    public string $model;
    public string $processor;
    public int $ram;
    public int $opslag;
    public float $display;
    public float $prijs;
    public $release;
    public function starten()
    {
    }

    public static function selectLaptops()
    {
        require "Les5Opdracht3.php";
        require "Form.php";
        $invoerTextbox = $_POST["Invoerveld"];
        $sql = "SELECT * FROM laptops WHERE laptop_brand LIKE '%$invoerTextbox%' OR laptop_model LIKE '%$invoerTextbox%' OR laptop_processor LIKE '%$invoerTextbox%'";
        $resultaat = $conn->query($sql);
        $laptops = [];
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $laptop = new Laptop();
                $laptop->id = $row["laptop_id"];
                $laptop->merk = $row["laptop_brand"];
                $laptop->model = $row["laptop_model"];
                $laptop->processor = $row["laptop_processor"];
                $laptop->ram = $row["laptop_ram_size"];
                $laptop->opslag = $row["laptop_storage_capacity"];
                $laptop->display = $row["laptop_display_size"];
                $laptop->prijs = $row["laptop_price"];
                $laptop->release = $row["laptop_release_date"];
                $laptops[] = $laptop;
            }
        }
        return $laptops;
    }
}
