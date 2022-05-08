<?php
$servername = "localhost";
$username = "root";
$password = "password";
$database="asylumDB";
$makeConnection = new mysqli($servername,$username,$password,$database);

$number = $makeConnection->prepare("SELECT username FROM Level2");
$number->execute();
$result =$number->get_result();
$num_rows1 = $result->num_rows;
echo($num_rows1);
$number->close();
$makeConnection->close();
?>