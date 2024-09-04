<?php
// Include database connection
include 'db_connect.php';

// Query to get employees who started between 2006 and 2009
$query = "SELECT FirstName, LastName FROM Employees WHERE YEAR(HireDate) BETWEEN 2006 AND 2009";
$result = $conn->query($query);

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee List</title>
</head>
<body>
    <h1>Employees Who Started Between 2006 and 2009</h1>
    <ul>
        <?php
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                echo "<li>" . $row['FirstName'] . " " . $row['LastName'] . "</li>";
            }
        } else {
            echo "<li>No employees found.</li>";
        }
        ?>
    </ul>

    <h1>All Employees</h1>
    <table border="1">
        <thead>
            <tr>
                <th>EmployeeID</th>
                <th>FirstName</th>
                <th>LastName</th>
                <th>DepartmentID</th>
                <th>HireDate</th>
            </tr>
        </thead>
        <tbody>
            <?php
            // Query to get all employees
            $query = "SELECT * FROM Employees";
            $result = $conn->query($query);

            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    echo "<tr>";
                    echo "<td>" . $row['EmployeeID'] . "</td>";
                    echo "<td>" . $row['FirstName'] . "</td>";
                    echo "<td>" . $row['LastName'] . "</td>";
                    echo "<td>" . $row['DepartmentID'] . "</td>";
                    echo "<td>" . $row['HireDate'] . "</td>";
                    echo "</tr>";
                }
            } else {
                echo "<tr><td colspan='5'>No employees found.</td></tr>";
            }
            ?>
        </tbody>
    </table>
</body>
</html>

<?php
// Close connection
$conn->close();
?>
