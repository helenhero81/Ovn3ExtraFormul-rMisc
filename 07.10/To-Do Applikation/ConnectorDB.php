<?php
// ConnectorDB.php

$host = 'localhost';
$user = 'root'; // användarnamn för MySQL
$password = ''; // lösenord för MySQL
$database = 'todo_db';

try {
    $conn = new PDO("mysql:host=$host;dbname=$database", $user, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    die("Connection failed: " . $e->getMessage());
}
?>
