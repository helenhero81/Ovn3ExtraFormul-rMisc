<?php
// process.php

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Hämta meddelandet från formuläret
    $message = trim($_POST['message']);
    
    // Säkerställ att meddelandet inte är tomt
    if (!empty($message)) {
        // Öppna filen för att lägga till meddelandet
        $file = 'messages.txt';
        $fileHandle = fopen($file, 'a');
        
        if ($fileHandle) {
            // Skriv meddelandet till filen
            fwrite($fileHandle, $message . PHP_EOL);
            fclose($fileHandle);
        }
    }
}

// Omdirigera tillbaka till gästboken
header('Location: index.html');
exit();
