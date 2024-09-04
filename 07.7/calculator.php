<?php
// calculator.php

session_start(); // Starta sessionshantering

// Initialisera sessionens beräkningar om de inte redan finns
if (!isset($_SESSION['calculations'])) {
    $_SESSION['calculations'] = [];
}

// Kontrollera om formuläret har skickats
if (isset($_POST['calculate'])) {
    $num1 = isset($_POST['num1']) ? $_POST['num1'] : 0;
    $num2 = isset($_POST['num2']) ? $_POST['num2'] : 0;
    $operation = isset($_POST['operation']) ? $_POST['operation'] : '+';

    // Utför beräkningen
    switch ($operation) {
        case '+':
            $result = $num1 + $num2;
            break;
        case '-':
            $result = $num1 - $num2;
            break;
        case '*':
            $result = $num1 * $num2;
            break;
        case '/':
            $result = $num2 != 0 ? $num1 / $num2 : 'Oändlighet';
            break;
        default:
            $result = 'Ogiltig operation';
            break;
    }

    // Spara beräkningen i sessionen
    $_SESSION['calculations'][] = "$num1 $operation $num2 = $result";
}
?>

<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kalkylator</title>
    <link rel="stylesheet" href="CalculatorAlaSession.css">
</head>
<body>
    <div class="container">
        <h1>Kalkylator</h1>
        <form action="calculator.php" method="POST">
            <input type="number" name="num1" placeholder="Tal 1" required>
            <select name="operation">
                <option value="+" selected>+</option>
                <option value="-">-</option>
                <option value="*">*</option>
                <option value="/">/</option>
            </select>
            <input type="number" name="num2" placeholder="Tal 2" required>
            <button type="submit" name="calculate">Beräkna</button>
        </form>
        <div class="results">
            <h2>Tidigare Beräkningar</h2>
            <ul>
                <?php
                // Visa alla tidigare beräkningar
                if (!empty($_SESSION['calculations'])) {
                    foreach ($_SESSION['calculations'] as $calculation) {
                        echo "<li>" . htmlspecialchars($calculation) . "</li>";
                    }
                } else {
                    echo "<li>Inga beräkningar ännu.</li>";
                }
                ?>
            </ul>
        </div>
    </div>
</body>
</html>
