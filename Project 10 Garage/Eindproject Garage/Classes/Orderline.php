<?php
class Orderline
{
    //de variabelen worden hier gedeclareerd.
    public $id;
    public $orderId;
    public $productId;
    public $quantity;

    //een functie die orderlines ophaalt op basis van een ID.
    public static function getOrderlines($orderId)
    {
        $orderlines = [];

        $conn = Database::Start();

        $query = "SELECT * FROM order_lines where order_line_order_id =  '$orderId' ";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $orderline = new Orderline();
                $orderline->id = $row["order_line_id"];
                $orderline->orderId = $row["order_line_order_id"];
                $orderline->productId = $row["order_line_product_id"];
                $orderline->quantity = $row["order_line_quantity"];

                $orderlines[] = $orderline;
            }
        }
        $conn->close();

        return $orderlines;
    }
}
