<?php
include 'header.php';
include 'ConnectorDB.php';

$id = $_GET['id'];
$query = $conn->prepare("SELECT * FROM tasks WHERE id = ?");
query->execute([$id]);
$task = $query->fetch();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['task_name'];
    $description = $_POST['task_description'];
    $priority = $_POST['task_priority'];

    $stmt = $conn->prepare("UPDATE tasks SET task_name = ?, task_description = ?, task_priority = ? WHERE id = ?");
    $stmt->execute([$name, $description, $priority, $id]);

    header('Location: index.php');
    exit;
}
?>

<h1>Redigera uppgift</h1>
<form method="POST">
    <label>Uppgift:</label>
    <input type="text" name="task_name" value="<?= htmlspecialchars($task['task_name']) ?>" required>
    
    <label>Beskrivning:</label>
    <textarea name="task_description"><?= htmlspecialchars($task['task_description']) ?></textarea>
    
    <label>Prioritet:</label>
    <select name="task_priority">
        <option value="low" <?= $task['task_priority'] == 'low' ? 'selected' : '' ?>>Låg</option>
        <option value="medium" <?= $task['task_priority'] == 'medium' ? 'selected' : '' ?>>Medel</option>
        <option value="high" <?= $task['task_priority'] == 'high' ? 'selected' : '' ?>>Hög</option>
    </select>
    
    <button type="submit">Uppdatera</button>
</form>

<?php include 'footer.php'; ?>
