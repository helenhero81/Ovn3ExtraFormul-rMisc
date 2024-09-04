<?php
// genderform.php

$selectedGender = "";

// Kontrollera om formuläret har skickats
if (isset($_POST['submit'])) {
    $selectedGender = isset($_POST['gender']) ? $_POST['gender'] : "Inget kön valt";
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Välj Kön</title>
    <link rel="stylesheet" href="ManFemale.css">
</head>
<body>
    <div class="form-container">
        <h1>Välj ditt kön</h1>
        <form action="genderform.php" method="POST">
            <div class="radio-group">
                <label>
                    <input type="radio" name="gender" value="Man" required> Man
                </label>
                <label>
                    <input type="radio" name="gender" value="Kvinna" required> Kvinna
                </label>
            </div>
            <button type="submit" name="submit">Bekräfta</button>
        </form>
        <?php if (!empty($selectedGender)): ?>
            <p class="selected-gender">Valt kön: <?php echo htmlspecialchars($selectedGender); ?></p>
        <?php endif; ?>
    </div>
</body>
</html>
