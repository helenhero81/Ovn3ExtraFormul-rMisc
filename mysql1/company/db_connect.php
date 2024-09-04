<?php
// db_connect.php

$servername = "localhost"; // or "127.0.0.1"
$username = "root"; // MySQL username (default is "root")
$password = ""; // MySQL password (default is an empty string)
$dbname = "Company-DB"; // Database name

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>
