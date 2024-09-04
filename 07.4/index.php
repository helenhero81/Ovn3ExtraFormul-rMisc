<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Punkter till lista</title>
</head>
<body>
    <h1>Lägg till punkter till listan</h1>
    <form method="post" action="">
        <label for="punkt">Ange en punkt:</label>
        <input type="text" id="punkt" name="punkt">
        <input type="submit" value="Lägg till">
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $punkt = $_POST["punkt"];
        if (!empty($punkt)) {
            // Lägg till punkten i en fil eller databas
            // Visa alla tidigare punkter från filen eller databasen här
            echo "<p>Du har lagt till: " . htmlspecialchars($punkt) . "</p>";
        }
    }
    ?>
</body>
</html>
