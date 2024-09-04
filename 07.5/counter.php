<?php
// counter.php

session_start(); // Starta sessionshantering

// Kontrollera om räknaren redan finns i sessionen
if (!isset($_SESSION['counter'])) {
    $_SESSION['counter'] = 0; // Initiera räknaren om den inte finns
}

// Om knappen trycks, öka räknarens värde med 1
if (isset($_POST['increment'])) {
    $_SESSION['counter']++;
}

// Hämta det aktuella räknarens värde
$counterValue = $_SESSION['counter'];
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Räknare</title>
    <link rel=" styleshet" href="Counter.css">
</head>
<body>
    <div class="container">
        <h1>Räknare</h1>
        <p>Nuvarande värde: <span class="counter-value"><?php echo $counterValue; ?></span></p>
        <form action="counter.php" method="POST">
            <button type="submit" name="increment" class="button">Öka med 1</button>
        </form>
    </div>
</body>
</html>
