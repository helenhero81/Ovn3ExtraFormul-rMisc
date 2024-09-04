<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Circle Diagram</title>
    <link rel="stylesheet" href="styles/StyleRatings.css">
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
</head>
<body class="light-theme">
    <div class="container">
        <h1>Rating Distribution</h1>
        <div id="piechart"></div>
    </div>

    <script>
        // Load the Visualization API and the corechart package.
        google.charts.load('current', {'packages':['corechart']});

        // Set a callback to run when the Google Visualization API is loaded.
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Smiley', 'Count'],
                <?php
                $counts = array_count_values(array_map(function($line) {
                    return explode(',', trim($line))[1];
                }, file('ratings.txt')));

                foreach ($counts as $smiley => $count) {
                    echo "['" . $smiley . "', " . $count . "],";
                }
                ?>
            ]);

            var options = {
                title: 'Smiley Distribution'
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart'));
            chart.draw(data, options);
        }
    </script>
</body>
</html>
