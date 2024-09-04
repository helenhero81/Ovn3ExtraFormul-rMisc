<?php
$dsn = 'mysql:host=localhost;dbname=Crudkontakter';
$username = 'root'; // Byt om du har ett annat användarnamn
$password = ''; // Byt om du har ett lösenord

try {
    $pdo = new PDO($dsn, $username, $password);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    echo 'Connection failed: ' . $e->getMessage();
}
?>
