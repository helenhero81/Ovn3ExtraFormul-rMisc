<?php
// contactform.php

// Initialisera felmeddelanden som tomma
$nameError = $emailError = $messageError = "";
$name = $email = $message = "";

// Kontrollera om formuläret har skickats
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty($_POST["name"])) {
        $nameError = "Namn är obligatoriskt";
    } else {
        $name = htmlspecialchars($_POST["name"]);
    }

    if (empty($_POST["email"])) {
        $emailError = "E-post är obligatoriskt";
    } else {
        $email = htmlspecialchars($_POST["email"]);
    }

    if (empty($_POST["message"])) {
        $messageError = "Meddelande är obligatoriskt";
    } else {
        $message = htmlspecialchars($_POST["message"]);
    }
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kontaktformulär</title>
    <link rel="stylesheet" href="FormError.css">
</head>
<body>
    <div class="form-container">
        <h1>Kontaktformulär</h1>
        <form action="contactform.php" method="POST">
            <div class="form-group">
                <label for="name">Namn:</label>
                <input type="text" id="name" name="name" value="<?php echo $name; ?>">
                <span class="error"><?php echo $nameError; ?></span>
            </div>
            <div class="form-group">
                <label for="email">E-post:</label>
                <input type="email" id="email" name="email" value="<?php echo $email; ?>">
                <span class="error"><?php echo $emailError; ?></span>
            </div>
            <div class="form-group">
                <label for="message">Meddelande:</label>
                <textarea id="message" name="message"><?php echo $message; ?></textarea>
                <span class="error"><?php echo $messageError; ?></span>
            </div>
            <button type="submit">Skicka</button>
        </form>
    </div>
</body>
</html>
