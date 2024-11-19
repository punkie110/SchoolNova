<?php
class Product
{
    //de variabelen worden hier gedeclareerd.
    public $id;
    public $name;
    public $category;
    public $price;
    public $inStock;

    //een getAll functie die alle producten in de database ophaalt.
    public static function getAll()
    {
        $products = [];

        $conn = Database::Start();

        $query = "SELECT * FROM products";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $product = new Product();
                $product->id = $row["product_id"];
                $product->name = $row["product_name"];
                $product->category = $row["product_category"];
                $product->price = $row["product_price"];
                $product->inStock = $row["product_instock"];
                $products[] = $product;
            }
        }
        $conn->close();

        return $products;
    }

    //een getOne functie die een product ophaalt op basis van de ID.
    public static function getOne($id)
    {
        $product = null;

        $conn = Database::Start();

        $query = "SELECT * FROM products WHERE product_id = '$id'";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $product = new Product();
                $product->id = $row["product_id"];
                $product->name = $row["product_name"];
                $product->category = $row["product_category"];
                $product->price = $row["product_price"];
                $product->inStock = $row["product_instock"];
            }
        }
        $conn->close();

        return $product;
    }

    //een Insert functie die een nieuw product injecteert in de Database.
    public function insert()
    {
        $conn = Database::Start();

        $name = mysqli_real_escape_string($conn, $this->name);
        $category = mysqli_real_escape_string($conn, $this->category);
        $price = mysqli_real_escape_string($conn, $this->price);
        $inStock = mysqli_real_escape_string($conn, $this->inStock);

        $sql = "INSERT INTO products (product_name, product_category, product_price, product_instock) 
        VALUES ( '" . $name . "' , '" . $category . "', '" . $price . "', '" . $inStock . "')";

        $conn->query($sql);
        $conn->close();
    }

    //een Update functie die een product update vanuit de database.
    public function update()
    {
        $product = null;

        $conn = Database::Start();
        $product = new Product();

        $id = mysqli_real_escape_string($conn, $this->id);
        $name = mysqli_real_escape_string($conn, $this->name);
        $category = mysqli_real_escape_string($conn, $this->category);
        $price = mysqli_real_escape_string($conn, $this->price);
        $inStock = mysqli_real_escape_string($conn, $this->inStock);


        $query = "UPDATE products SET product_name = '" . $name . "', 
        product_category = '" . $category . "', product_price = '" . $price . "', 
        product_instock = '" . $inStock . "'
        WHERE product_id = '" . $id . "'";

        $conn->query($query);
        $conn->close();
    }

    //een Delete functie die een product vanuit de database verwijderd.
    public function delete()
    {
        $conn = Database::Start();

        $id = mysqli_real_escape_string($conn, $this->id);
        $query = "DELETE FROM products WHERE product_id = '" . $id . "'";

        $conn->query($query);
        $conn->close();
    }
}
