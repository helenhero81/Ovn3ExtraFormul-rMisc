<?php
// login.php

// Definiera korrekta användarnamn och lösenord
$validUsername = 'admin';
$validPassword = 'password123';

// Hämta inloggningsuppgifter från formuläret
$username = isset($_POST['username']) ? $_POST['username'] : '';
$password = isset($_POST['password']) ? $_POST['password'] : '';

// Kontrollera om inloggningsuppgifterna är korrekta
if ($username === $validUsername && $password === $validPassword) {
    // Om uppgifterna är korrekta, omdirigera till en annan sida (t.ex. en välkomstsida)
    header('Location: welcome.html');
    exit();
} else {
    // Om uppgifterna är felaktiga, omdirigera tillbaka med ett felmeddelande
    header('Location: login.html?error=Fel användarnamn eller lösenord');
    exit();
}
