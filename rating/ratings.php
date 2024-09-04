<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Rating System</title>
   <!--link rel="stylesheet" href="styles/StyleRatings.css"-->
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
<body class="light-theme">
    <div class="container">
        <h1>Welcome to the Rating System</h1>
        
        <button class="theme-toggle-button" onclick="toggleTheme()">Toggle Theme</button>
        </form>
        <!-- Button to generate PDF -->
    <form action="generate_pdf.php" method="post">
        <button type="submit">Export to PDF</button>
    </form>
    </div>
   <div class="container">
       <h2>Rate Your Experience</h2>
       <form method="POST">
           <div class="gender-selection">
               <label>
                   <input type="radio" name="gender" value="Man" required> Man
               </label>

               <label>
                   <input type="radio" name="gender" value="Kvinna" required> Kvinna
               </label>
           </div>
           <div class="smiley-container">
               <button type="submit" name="rating" value="Excellent" class="smiley" onmouseover="highlightSmiley(this)">😊</button>
               <button type="submit" name="rating" value="Great" class="smiley" onmouseover="highlightSmiley(this)">🙂</button>
               <button type="submit" name="rating" value="Good" class="smiley" onmouseover="highlightSmiley(this)">😐</button>
               <button type="submit" name="rating" value="Okay" class="smiley" onmouseover="highlightSmiley(this)">🙁</button>
               <button type="submit" name="rating" value="Bad" class="smiley" onmouseover="highlightSmiley(this)">😠</button>
               <button type="submit" name="rating" value="Very Bad" class="smiley" onmouseover="highlightSmiley(this)">😡</button>
           </div>
       </form>
   </div>

   <?php

   
   if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['rating']) && isset($_POST['gender'])) {
       $rating = $_POST['rating'];
       $gender = $_POST['gender'];
       $date = date('Y-m-d H:i:s');
       $data = "Date: $date, Gender: $gender, Rating: $rating\n";

       file_put_contents("results.txt", $data, FILE_APPEND);
       echo "<p>Thank you for your feedback!</p>";
       echo "<p>You rated your experience as: $rating</p>";
       
   }
   ?>
    <script>
    function toggleTheme() {
        document.body.classList.toggle('dark-theme');
    }
  </script>
   <script>
       function highlightSmiley(element) {
           document.querySelectorAll('.smiley').forEach(smiley => {
               smiley.classList.remove('highlighted');
           });
           element.classList.add('highlighted');
       }
   </script>

    
</script>
</body>
</html>