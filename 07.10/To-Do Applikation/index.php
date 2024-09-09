<?php
include 'header.php';
include 'ConnectorDB.php';

// Hämtar alla uppgifter från databasen
$query = $conn->query("SELECT * FROM tasks ORDER BY task_priority DESC, created_at DESC");
$tasks = $query->fetchAll();
?>

<h1>To-Do List</h1>
<a href="create.php">Lägg till ny uppgift</a>

<table>
    <tr>
        <th>Uppgift</th>
        <th>Prioritet</th>
        <th>Status</th>
        <th>Åtgärder</th>
    </tr>
    <?php foreach ($tasks as $task) : ?>
        <tr>
            <td><?= htmlspecialchars($task['task_name']) ?></td>
            <td><?= ucfirst($task['task_priority']) ?></td>
            <td><?= ucfirst($task['task_status']) ?></td>
            <td>
                <a href="edit.php?id=<?= $task['id'] ?>">Redigera</a>
                <a href="delete.php?id=<?= $task['id'] ?>" onclick="return confirm('Är du säker på att du vill ta bort denna uppgift?')">Ta bort</a>
                <?php if ($task['task_status'] === 'pending') : ?>
                    <a href="complete.php?id=<?= $task['id'] ?>">Slutför</a>
                <?php endif; ?>
            </td>
        </tr>
    <?php endforeach; ?>
</table>

<?php include 'footer.php'; ?>
