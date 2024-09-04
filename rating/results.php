
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>results.php</title>
    <link rel="stylesheet" href="styles/StyleRatings.css">
    <style>
    body{

    background: #cceeee;

    }
    table {
   width: 80%;
   margin: 0 auto;
   border-collapse: collapse;

}

thead {
   background-color: #007BFF;
   color: #fff;
}

th, td {
   padding: 10px;
   border: 1px solid #ddd;
}

tbody tr:nth-child(even) {
   background-color: #f9f9f9;
}

tbody tr:hover {
   background-color: #f1f1f1;
}

    </style>
</head>

<?php
/*
session_start();
if (!isset($_SESSION['admin'])) {
    header("Location: login.php");
    exit();
}
*/
$ratings = file('ratings.txt');
?>
<body class="light-theme">
    <div class="container">
        <h1>Results</h1>
        <table>
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Smiley</th>
                    <th>Gender</th>
                </tr>
            </thead>
            <tbody>
            <?php
               $file = 'results.txt';
               if (file_exists($file)) {
                   $lines = file($file, FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
                   foreach ($lines as $line) {
                       // Split the line into its components
                       $parts = explode(',', $line);
                       
                       // Check if we have the right number of parts
                       if (count($parts) == 3) {
                           // Extract values from the components
                           $date = trim(explode(':', $parts[0])[1]);
                           $gender = trim(explode(':', $parts[1])[1]);
                           $rating = trim(explode(':', $parts[2])[1]);

                           echo "<tr>
                                   <td>$date</td>
                                   <td>$gender</td>
                                   <td>$rating</td>
                                 </tr>";
                       } else {
                           echo "<tr><td colspan='3'>Invalid data format in results.txt</td></tr>";
                       }
                   }
               } else {
                   echo "<tr><td colspan='3'>No data available.</td></tr>";
               }
               ?>
            </tbody>
        </table>
        <button onclick="openCircleDiagram()">View Circle Diagram</button>
        <button onclick="exportToPDF()">Export to PDF</button>
    </div>

    <script src="scripts/script.js"></script>
</body>
</html>
