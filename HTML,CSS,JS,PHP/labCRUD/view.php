<?php
include 'connectdb.php';

$query = "SELECT * FROM Student";
$result = mysqli_query($link, $query);

?>

<!DOCTYPE html>
<html>

<head>
    <title>View Students</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(112.2deg, rgb(0, 204, 255) -1.1%, rgb(0, 221, 61) 100.7%);
            margin: 20px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        table, th, td {
            border: 1px solid #ddd;
        }
        th, td {
            padding: 10px;
            text-align: left;
        }
        th {
            background-color: #f2f2f2;
        }
        tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        tr:hover {
            background-color: #f1f1f1;
        }
        .btn {
            padding: 5px 10px;
            margin: 0 5px;
            text-decoration: none;
            border: none;
            cursor: pointer;
            color: white;
            border-radius: 5px;
        }
        .btn-update {
            background-color: #4CAF50;
        }
        .btn-delete {
            background-color: #f44336;
        }
        .btn-add {
            background-color: #2196F3;
            color: white;
            padding: 10px 15px;
            border: none;
            text-decoration: none;
            display: inline-block;
            border-radius: 5px;
            margin-bottom: 20px;
        }
        .btn-delete:hover {
            background-color: #d32f2f;
        }
        .btn-update:hover {
            background-color: #388e3c;
        }
        .btn-add:hover {
            background-color: #1976d2;
        }
    </style>
</head>

<body>
    <h1>Student List</h1>
    <a href="addform.php" class="btn-add">Add Student</a>
    <table>
        <tr>
            <th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Age</th>
            <th>Email</th>
            <th>Active</th>
            <th>Actions</th>
        </tr>
        <?php while ($row = mysqli_fetch_assoc($result)) { ?>
            <tr>
                <td><?php echo $row['id']; ?></td>
                <td><?php echo $row['first_name']; ?></td>
                <td><?php echo $row['last_name']; ?></td>
                <td><?php echo $row['age']; ?></td>
                <td><?php echo $row['email']; ?></td>
                <td><?php echo $row['active'] ? 'Yes' : 'No'; ?></td>
                <td>
                    <form action="updateform.php" method="get" style="display:inline;">
                        <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
                        <button class="btn btn-update" type="submit">Update</button>
                    </form>
                    <form action="delete.php" method="post" style="display:inline;" onsubmit="return confirm('Are you sure?');">
                        <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
                        <button class="btn btn-delete" type="submit">Delete</button>
                    </form>
                </td>
            </tr>
        <?php } ?>
    </table>
</body>

</html>
<?php mysqli_close($link); ?>
