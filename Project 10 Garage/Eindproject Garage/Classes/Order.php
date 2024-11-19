<?php
class Order
{
    public $id;
    public $customerId;
    public $date;
    public $paid;

    //een functie die al de orders ophaalt.
    public static function findAll()
    {
        $orders = [];

        $conn = Database::Start();

        $query = "SELECT * FROM orders";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $order = new Order();
                $order->id = $row["order_id"];
                $order->customerId = $row["order_customer_id"];
                $order->date = $row["order_date"];
                $order->paid = $row["order_paid"];
                $orders[] = $order;
            }
        }
        $conn->close();

        return $orders;
    }

    //een functie die een order ophaalt op basis van de ID.
    public static function getOne($id)
    {
        $order = null;

        $conn = Database::Start();

        $query = "SELECT * FROM orders WHERE order_id = '$id'";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $order = new Order();
                $order->id = $row["order_id"];
                $order->customerId = $row["order_customer_id"];
                $order->date = $row["order_date"];
                $order->paid = $row["order_paid"];
            }
        }
        $conn->close();

        return $order;
    }
}
