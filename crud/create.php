<?php
include 'db_connect.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $firstname = $_POST['firstname'];
    $lastname = $_POST['lastname'];
    $birthday = $_POST['birthday'];
    $phone = $_POST['phone'];
    $email = $_POST['email'];

    $stmt = $pdo->prepare("INSERT INTO members (firstname, lastname, birthday, phone, email) VALUES (?, ?, ?, ?, ?)");
    $stmt->execute([$firstname, $lastname, $birthday, $phone, $email]);

    header('Location: index.php');
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <title>Lägg till ny medlem</title>
    <link rel="stylesheet" href="crud.css">
</head>
<body>
    <h1>Lägg till ny medlem</h1>
    <form method="post">
        <label>Förnamn:</label><input type="text" name="firstname" required><br>
        <label>Efternamn:</label><input type="text" name="lastname" required><br>
        <label>Födelsedag:</label><input type="date" name="birthday" required><br>
        <label>Telefon:</label><input type="text" name="phone" required><br>
        <label>Email:</label><input type="email" name="email" required><br>
        <input type="submit" value="Lägg till">
    </form>
    <a href="index.php">Tillbaka till listan</a>
</body>
</html>
