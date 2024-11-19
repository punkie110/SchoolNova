<!doctype html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">


  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
  <link rel="stylesheet" href="BMIStyle.css">
  <title>BMI/BMR berekenen</title>
</head>

<body>
  <div class="container-fluid-text-center" id="containerMain">
    <div class="row row-justify-content-center">
      <div class="col">
        <h5>BMI</h5>
      </div>
    </div>
    <div class="row row-justify-content-center">
      <div class="col">
        <h7>Bereken snel of je overgewicht hebt.</h7>
      </div>
    </div>
    <div class="row row-justify-content-center">
      <div class="col">
        <div class="card" id="Kaartjes">
          <div class="card-header">
            <h2>Berken hier je BMI!</h2>
          </div>
          <div class="card-body">
            <h5>
              <form name="BMI" method="post">
                <input type="text" id="BMIGewicht" name="BMIGewicht" placeholder="Gewicht (in KG)">
                <input type="text" id="BMILengte" name="BMILengte" placeholder="Lengte (in meter)"> </br>
                <input type="submit" value="bevestigen">
              </form>
            </h5>
          </div>
        </div>
      </div>
      <div class="col">
        <div class="card" id="Kaartjes">
          <div class="card-header">
            <h2>Berken hier je BMR!</h2>
          </div>
          <div class="card-body">
            <h5>
              <form name="BMR" method="post">
                <input type="number" id="BMRLeeftijd" name="BMRLeeftijd" placeholder="Leeftijd (in jaar)">
                <input type="text" id="BMRLengte" name="BMRLengte" placeholder="Lengte (in CM)"> </br>
                <input type="text" id="BMRGewicht" name="BMRGewicht" placeholder="Gewicht (in KG)"> </br>
          </div>
          <div class="card-header">
            <h3>Gender</h3><br />
          </div>
          <div class="card-body">
            <form name="gender" method="post">
              <label>Man</label><input type="radio" id="gender" name="BMRGender" value="man" required>
              <label>Vrouw</label><input type="radio" id="gender" name="BMRGender" value="vrouw" required><br />
              <input type="submit" value="bevestigen">
            </form>
          </div>
          </h5>
        </div>
      </div>
    </div>
  </div>
  <div class="row row-Justify-content-center">
  </div>
  <div class="row row-Justify-content-center">
    <div class="card" id="Kaartjes">
      <div class="col">
        <?php
        // Een if-statement die controleert of BMI Gewicht en BMI Lengte is ingevuld
        if (isset($_POST["BMIGewicht"]) && isset($_POST["BMILengte"])) {
          // als het is ingevuld Include hij de class gegevensBMI
          include("gegevensBMI.php");
          $bmiGegevens = new gegevensBMI();
          // Hier worden de gewicht en lengte variabelen uit de textvelden gehaald.
          $bmiGegevens->Gewicht = $_POST["BMIGewicht"];
          $bmiGegevens->Lengte = $_POST["BMILengte"];
          if (!$bmiGegevens->validate()) {
            // als de tekstvelden niet numeriek zijn echo'd hij een error terug.
            echo "BMI : voer een geldige waarde in als je je BMI wilt berekenen!<br />";
          } else {
            // Anders echo'd hij het resultaat uit berekenBMIFormatted
            echo $bmiGegevens->berekenBMIFormatted();
          }
        }
        // Hetzelfde riedeltje maar dan bij BMR
        if (isset($_POST["BMRLeeftijd"]) && isset($_POST["BMRLengte"]) && isset($_POST["BMRGewicht"])) {
          include("gegevensBMR.php");
          $bmrGegevens = new gegevensBMR();
          $bmrGegevens->Gender = $_POST["BMRGender"];
          $bmrGegevens->Lengte = $_POST["BMRLengte"];
          $bmrGegevens->Leeftijd = $_POST["BMRLeeftijd"];
          $bmrGegevens->Gewicht = $_POST["BMRGewicht"];
          if (!$bmrGegevens->validate()) {
            echo "BMR : voer een geldige waarde in als je je BMR wilt berekenen!<br />";
          } else {
            echo $bmrGegevens->berekenBMRFormatted();
          }
        }
        ?>
      </div>
    </div>
  </div>






















  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>

</html>