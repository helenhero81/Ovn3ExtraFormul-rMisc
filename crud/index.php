<?php
include 'db_connect.php';

$stmt = $pdo->query("SELECT * FROM members ORDER BY lastname");
$members = $stmt->fetchAll();
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <title>Medlemslista</title>
    <link rel="stylesheet" href="crud.css">
</head>
<body>
    <h1>Medlemslista</h1>
    <table>
        <tr>
            <th>ID</th>
            <th>Förnamn</th>
            <th>Efternamn</th>
            <th>Födelsedag</th>
            <th>Telefon</th>
            <th>Email</th>
            <th>Åtgärder</th>
        </tr>
        <?php foreach ($members as $member): ?>
        <tr>
            <td><?= htmlspecialchars($member['id']) ?></td>
            <td><?= htmlspecialchars($member['firstname']) ?></td>
            <td><?= htmlspecialchars($member['lastname']) ?></td>
            <td><?= htmlspecialchars($member['birthday']) ?></td>
            <td><?= htmlspecialchars($member['phone']) ?></td>
            <td><?= htmlspecialchars($member['email']) ?></td>
            <td>
                <a href="update.php?id=<?= $member['id'] ?>">Uppdatera</a>
                <a href="delete.php?id=<?= $member['id'] ?>" onclick="return confirm('Är du säker?')">Radera</a>
            </td>
        </tr>
        <?php endforeach; ?>
    </table>
    <a href="create.php">Lägg till ny medlem</a>
</body>
</html>
