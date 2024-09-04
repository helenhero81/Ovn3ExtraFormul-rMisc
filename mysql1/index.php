<?php
include 'db_connect.php';

// Hämta alla anställda som har börjat mellan 2006 och 2009
$sql = "SELECT first_name, last_name FROM employees WHERE start_date BETWEEN '2006-01-01' AND '2009-12-31'";
$result = $conn->query($sql);

echo "<h2>Anställda som började mellan 2006 och 2009</h2>";
echo "<ul>";
if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        echo "<li>" . $row["first_name"] . " " . $row["last_name"] . "</li>";
    }
} else {
    echo "<li>Inga anställda hittades</li>";
}
echo "</ul>";

// Hämta alla anställda från `employees`-tabellen
$sql = "SELECT * FROM employees";
$result = $conn->query($sql);

echo "<h2>Alla anställda</h2>";
echo "<table border='1'>";
echo "<tr><th>ID</th><th>Förnamn</th><th>Efternamn</th><th>Startdatum</th></tr>";
if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        echo "<tr>
                <td>" . $row["id"] . "</td>
                <td>" . $row["first_name"] . "</td>
                <td>" . $row["last_name"] . "</td>
                <td>" . $row["start_date"] . "</td>
              </tr>";
    }
} else {
    echo "<tr><td colspan='4'>Inga anställda hittades</td></tr>";
}
echo "</table>";

$conn->close();
?>
