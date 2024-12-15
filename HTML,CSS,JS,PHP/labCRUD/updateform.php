<?php
include 'connectdb.php';

$id = $_GET['id'];
$query = "SELECT * FROM Student WHERE id = $id";
$result = mysqli_query($link, $query);
$row = mysqli_fetch_assoc($result);
?>

<!DOCTYPE html>
<html>
<head>
    <title>Update Student</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(112.2deg, rgb(0, 204, 255) -1.1%, rgb(0, 221, 61) 100.7%);
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        form {
            background: linear-gradient(to right, rgb(182, 244, 146), rgb(51, 139, 147));
            animation: fadeIn 2s;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            width: 300px;
        }
        form label {
            font-size: 14px;
            margin-bottom: 5px;
            display: block;
        }
        form input[type="text"],
        form input[type="number"],
        form input[type="email"],
        form input[type="checkbox"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
        }
        form button {
            background-color: #4CAF50;
            color: white;
            border: none;
            padding: 10px 15px;
            cursor: pointer;
            border-radius: 5px;
            font-size: 16px;
            width: 100%;
        }
        form button:hover {
            background-color: #45a049;
        }

        @keyframes fadeIn {
        0% { opacity: 0; }
        100% { opacity: 1; }

    </style>
</head>
<body>
    <form action="update.php" method="post">
        <h2>Update Student</h2>
        
        <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
        
        <label for="first_name">First Name:</label>
        <input type="text" id="first_name" name="first_name" value="<?php echo $row['first_name']; ?>" required>
        
        <label for="last_name">Last Name:</label>
        <input type="text" id="last_name" name="last_name" value="<?php echo $row['last_name']; ?>" required>
        
        <label for="age">Age:</label>
        <input type="number" id="age" name="age" value="<?php echo $row['age']; ?>" required>
        
        <label for="email">Email:</label>
        <input type="email" id="email" name="email" value="<?php echo $row['email']; ?>">
        
        <label for="active">
            <input type="checkbox" id="active" name="active" value="1" <?php echo $row['active'] ? 'checked' : ''; ?>>
            Active
        </label>
        
        <button type="submit">Update Student Details</button>
    </form>
</body>
</html>
<?php mysqli_close($link); ?>
