<?php
include 'ConnectorDB.php';

$id = $_GET['id'];
$stmt = $conn->prepare("UPDATE tasks SET task_status = 'completed' WHERE id = ?");
$stmt->execute([$id]);

header('Location: index.php');
exit;
?>
