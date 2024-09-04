<!-- index.php -->
<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ändra bakgrundsfärg</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
            padding: 20px;
            <?php
            // Bestäm bakgrundsfärgen baserat på användarens val
            if (isset($_POST['color'])) {
                $color = htmlspecialchars($_POST['color']);
                echo "background-color: $color;";
            }
            ?>
        }
    </style>
</head>
<body>
    <h1>Välj en bakgrundsfärg</h1>
    <form action="index.php" method="POST">
        <label for="color">Färg:</label>
        <select id="color" name="color">
            <option value="white">Vitt</option>
            <option value="red">Röd</option>
            <option value="green">Grön</option>
            <option value="blue">Blå</option>
            <option value="yellow">Gul</option>
        </select>
        <button type="submit">Ändra färg</button>
    </form>
</body>
</html>
