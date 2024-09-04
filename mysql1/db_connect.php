<?php
$servername = "localhost";
$username = "root"; // standard, ändra om du har annat användarnamn
$password = ""; // standard, ändra om du har annat lösenord
$dbname = "Company_DB";

// Skapa anslutningen
$conn = new mysqli($servername, $username, $password, $dbname);

// Kontrollera anslutningen
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>
