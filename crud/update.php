<?php
include 'db_connect.php';

if (isset($_GET['id'])) {
    $id = $_GET['id'];
    $stmt = $pdo->prepare("SELECT * FROM members WHERE id = ?");
    $stmt->execute([$id]);
    $member = $stmt->fetch();

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $firstname = $_POST['firstname'];
        $lastname = $_POST['lastname'];
        $birthday = $_POST['birthday'];
        $phone = $_POST['phone'];
        $email = $_POST['email'];

        $stmt = $pdo->prepare("UPDATE members SET firstname = ?, lastname = ?, birthday = ?, phone = ?, email = ? WHERE id = ?");
        $stmt->execute([$firstname, $lastname, $birthday, $phone, $email, $id]);

        header('Location: index.php');
    }
} else {
    header('Location: index.php');
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <title>Uppdatera medlem</title>
    <link rel="stylesheet" href="crud.css">
</head>
<body>
    <h1>Uppdatera medlem</h1>
    <form method="post">
        <label>Förnamn:</label><input type="text" name="firstname" value="<?= htmlspecialchars($member['firstname']) ?>" required><br>
        <label>Efternamn:</label><input type="text" name="lastname" value="<?= htmlspecialchars($member['lastname']) ?>" required><br>
        <label>Födelsedag:</label><input type="date" name="birthday" value="<?= htmlspecialchars($member['birthday']) ?>" required><br>
        <label>Telefon:</label><input type="text" name="phone" value="<?= htmlspecialchars($member['phone']) ?>" required><br>
        <label>Email:</label><input type="email" name="email" value="<?= htmlspecialchars($member['email']) ?>" required><br>
        <input type="submit" value="Uppdatera">
    </form>
    <a href="index.php">Tillbaka till listan</a>
</body>
</html>
