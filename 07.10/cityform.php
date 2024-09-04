<?php
// cityform.php

$selectedCity = "";

// Kontrollera om formuläret har skickats
if (isset($_POST['submit'])) {
    $selectedCity = isset($_POST['city']) ? $_POST['city'] : "Ingen stad vald";
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Välj Stad</title>
    <link rel="stylesheet" href="CityResults.css">
</head>
<body>
    <div class="form-container">
        <h1>Välj en stad</h1>
        <form action="cityform.php" method="POST">
            <div class="dropdown-group">
                <label for="city">Stad:</label>
                <select id="city" name="city" required>
                    <option value="" disabled selected>Välj en stad</option>
                    <option value="Stockholm">Stockholm</option>
                    <option value="Göteborg">Göteborg</option>
                    <option value="Malmö">Malmö</option>
                    <option value="Uppsala">Uppsala</option>
                    <option value="Västerås">Västerås</option>
                </select>
            </div>
            <button type="submit" name="submit">Bekräfta</button>
        </form>
        <?php if (!empty($selectedCity)): ?>
            <p class="selected-city">Vald stad: <?php echo htmlspecialchars($selectedCity); ?></p>
        <?php endif; ?>
    </div>
</body>
</html>
