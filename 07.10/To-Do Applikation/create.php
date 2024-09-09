<?php
include 'header.php';
include 'ConnectorDB.php';

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['task_name'];
    $description = $_POST['task_description'];
    $priority = $_POST['task_priority'];

    $stmt = $conn->prepare("INSERT INTO tasks (task_name, task_description, task_priority) VALUES (?, ?, ?)");
    $stmt->execute([$name, $description, $priority]);

    header('Location: index.php');
    exit;
}
?>

<h1>Lägg till ny uppgift</h1>
<form method="POST">
    <label>Uppgift:</label>
    <input type="text" name="task_name" required>
    
    <label>Beskrivning:</label>
    <textarea name="task_description"></textarea>
    
    <label>Prioritet:</label>
    <select name="task_priority">
        <option value="low">Låg</option>
        <option value="medium">Medel</option>
        <option value="high">Hög</option>
    </select>
    
    <button type="submit">Lägg till</button>
</form>

<?php include 'footer.php'; ?>
