<?php
require('fpdf.php');

$pdf = new FPDF();
$title="Rating Rersults";
$pdf->setTitle($title);
$pdf->AddPage();
$pdf->SetFont('Arial','B',16); 



$txtFile = "results.txt";

if(file_exists($txtFile)) {

   
    $txtcontent = file_get_contents($txtFile);
    $pdf->MultiCell(0, 12, $txtcontent);
    
    $pdf->Output("D", "helenNew.pdf");
} else {

    echo "No badasbing und booom ";
}


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PDF</title>
</head>
<body>
    
</body>
</html>