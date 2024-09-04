<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome</title>
    <link rel="stylesheet" href="styles/StyleRatings.css">
</head>
<body class="light-theme">
    <div class="container">
        <h1>Welcome to the Rating System</h1>
        <button onclick="window.location.href='ratings.php'">Go to Ratings</button>
        <button class="theme-toggle-button" onclick="toggleTheme()">Toggle Theme</button>
    </div>

    <script>

    function toggleTheme() {
        document.body.classList.toggle('dark-theme');
    }
  </script>
</body>
</html>
