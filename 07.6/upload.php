<?php
// upload.php

// Målmappen för uppladdade filer
$targetDir = "uploads/";
if (!file_exists($targetDir)) {
    mkdir($targetDir, 0777, true); // Skapa mappen om den inte finns
}

// Kontrollera om filer har skickats
if (isset($_FILES['files'])) {
    $files = $_FILES['files'];
    $fileCount = count($files['name']);

    for ($i = 0; $i < $fileCount; $i++) {
        // Bestäm målfilens sökväg
        $targetFile = $targetDir . basename($files['name'][$i]);

        // Flytta den uppladdade filen till målplatsen
        if (move_uploaded_file($files['tmp_name'][$i], $targetFile)) {
            echo "<p>Filen " . htmlspecialchars($files['name'][$i]) . " har laddats upp.</p>";
        } else {
            echo "<p>Det gick inte att ladda upp filen " . htmlspecialchars($files['name'][$i]) . ".</p>";
        }
    }
} else {
    echo "<p>Inga filer valdes för uppladdning.</p>";
}
?>
