<?php

include("student.php");

$student = new Student();
$student->voornaam = "Karel";
$student->achternaam = "Pieterson";
echo $student->checkAanwezigheid();

$student2 = new Student();
$student2->voornaam = "Piet";
$student2->achternaam = "Karelson";

var_dump($student);
var_dump($student2);