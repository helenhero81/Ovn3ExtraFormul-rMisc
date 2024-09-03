<!-- index.html -->
<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gästbok</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            width: 80%;
            margin: auto;
        }
        .message {
            border: 1px solid #ddd;
            padding: 10px;
            margin-bottom: 10px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        textarea {
            width: 100%;
            height: 100px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Gästbok</h1>
        <form action="process.php" method="POST">
            <div class="form-group">
                <label for="message">Skriv ditt meddelande:</label>
                <textarea id="message" name="message" required></textarea>
            </div>
            <button type="submit">Skicka</button>
        </form>
        <h2>Tidigare meddelanden:</h2>
        <div id="messages">
            <?php
            // Läs och visa meddelanden
            if (file_exists('messages.txt')) {
                $messages = file('messages.txt');
                foreach ($messages as $message) {
                    echo '<div class="message">' . htmlspecialchars($message) . '</div>';
                }
            } else {
                echo '<p>Inga meddelanden ännu.</p>';
            }
            ?>
        </div>
    </div>
</body>
</html>
