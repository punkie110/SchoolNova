<html>
<?php
require "Classes/Order.php";
require "Classes/Database.php";
require "Classes/Product.php";
require "Classes/Orderline.php";
require "Classes/Customer.php";

//De totaalprijs word hier gedeclareerd en later gebruikt.
$totaalprijs = 0;
//Haalt een order op Door middel van het ID.
$order = Order::getOne($_GET["id"]);
//geeft overzichtelijke variabelen die gebruikt worden vanuit de order functie.
$orderId = $order->id;
$customerId = $order->customerId;

//haalt hier de bijbehorende klant en orderlines op wat betreft de order.
$customer = Customer::findOne($customerId);
$orderlines = OrderLine::getOrderlines($orderId);

?>

<head>
    <!--De connecties met CSS/Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="CSS/Style.css">
</head>

<body>
    <!--De navbar-->
    <div class="container-fluid text-center" id="Navbar">
        <nav class="navbar bg-body-tertiary fixed-top" style="background-color: #999090;">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Garage</a>

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Index.php">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="products.php">Producten</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Orders.php">Bestellingen</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>

    <!--De hoofdcontainer voor de body.-->
    <div class="container-fluid" id="container-main">

        <?php
        //checkt hoeveel orderlines er zijn met de count functie, als er niks is laat hij zien dat er geen offerte beschikbaar is.
        if (count($orderlines) == 0) {
            echo "<span style='background-color: #ffffff'>Helaas, er is geen offerte beschikbaar!</span>";
            //Als er orderlines opgehaald kunnen worden haalt hij eerst de bijbehorende klant op en gaat hij
            //vervolgens de foreach loop in om zo alle klanten op te halen.
            //Voor elke orderline die bestaat in de database maakt hij een rij aan met de ordergegevens van de klant.
        } else {
        ?>
            <div class="row">
                <strong>
                    <h1>Factuur voor <?php echo $customer->firstname . " " . $customer->lastname; ?> </h1>
                </strong>
            </div>
            <div class="row">
                <strong>
                    <h2>Gegevens:</h2>
                </strong>
            </div>
            <?php
            ?> <div class="row"> <strong> <?php
                                            echo $customer->firstname . " " . $customer->lastname;
                                            ?> </strong> </div>
            <div class="row"> <strong> <?php
                                        echo $customer->address;
                                        ?> </strong> </div>
            <div class="row"> <strong> <?php
                                        echo $customer->zipcode;
                                        ?> </strong> </div>
            <div class="row"> <strong> <?php
                                        echo $customer->city;
                                        ?> </strong> </div>
            <div class="row"> <strong> <?php
                                        echo $customer->email;
                                        ?></strong> </div> <br />
            <strong>
                <h2>Bestelde producten:</h2>
            </strong>
            <div class="row">
                <div class="col">
                    <h3>Product:</h3>
                </div>
                <div class="col">
                    <h3>Prijs:</h3>
                </div>
                <div class="col">
                    <h3>Betaald:</h3>
                </div>
            </div>
            <?php
            foreach ($orderlines as $orderline) {

                $productId = $orderline->productId;
                $product = Product::getOne($productId);
                if(isset($product))
                {
            ?>
                <div class="row">
                    <div class="col">
                        <h5><?= $product->name ?></h5>
                    </div>
                    <div class="col">
                        <h5><?= "€" . $product->price ?></h5>
                    </div>
                    <div class="col">
                        <h5><?php if ($order->paid) {
                                echo "ja";
                            } else {
                                echo "nee";
                            }
                            ?></h5> <br />
                    </div>
                </div>
                <!--Hier berekent hij de totaalprijs door elke keer de productprijs 
                     van de orderline in de loop toe te voegen aan de totaalprijs. -->
        <?php $totaalprijs += $product->price;
                }
            }
        }
        ?>
        <br />

        <div class="col align-self-end">
            <strong>
                <h4>Totaalprijs:</h4>
            </strong>
            <strong>
                <h4><?php echo "€" . $totaalprijs; ?> </h4>
            </strong>
        </div>
    </div>
    <!-- Een footer die de pagina mooi afsluit. -->
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2024 Garage, Inc</span>
        </div>
    </footer>
</div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>
