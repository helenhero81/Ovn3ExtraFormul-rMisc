<?php

if ($_SERVER['REQUEST_METHOD'] == "POST" && isset ($_POST["rating"]) ) {
    $rating = $_POST['rating'];
    $gender = $_POST['gender'];
    $date = date("Y-m-d H:i:s");
    $date = "Date: $date, Gender: $gender, Rating: $rating\n";

    $data = "$date|$gender|$rating\n";
    file_put_contents("results.txt", $data, FILE_APPEND);
    //echo "<p>You rated as: $rating</p>";
}

?>
