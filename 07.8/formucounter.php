<?php
// formucounter.php

// Initialisera variabel för lösenordets längd
$passwordLength = 0;

// Kontrollera om formuläret har skickats
if (isset($_POST['submit'])) {
    $password = isset($_POST['password']) ? $_POST['password'] : '';
    $passwordLength = strlen($password); // Beräkna lösenordets längd
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lösenordslängd</title>
    <link rel="stylesheet" href="FormuCounter.css">
</head>
<body>
    <div class="form-container">
        <h1>Lösenordsformulär</h1>
        <form action="formucounter.php" method="POST">
            <div class="form-group">
                <label for="password">Lösenord:</label>
                <input type="password" id="password" name="password" required>
            </div>
            <button type="submit" name="submit">Kontrollera längd</button>
        </form>
        <?php if (isset($_POST['submit'])): ?>
            <p class="length">Längd på lösenordet: <?php echo htmlspecialchars($passwordLength); ?> tecken</p>
        <?php endif; ?>
    </div>
</body>
</html>
