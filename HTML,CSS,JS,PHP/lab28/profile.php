<?php
session_start();
include 'connectdb.php';

if (!isset($_SESSION['user_id'])) {
    header("Location: login.php");
    exit();
}

$user_id = $_SESSION['user_id'];
$sql = "SELECT username, email, full_name, phone_number FROM users WHERE id = $user_id";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
} else {
    echo "User not found.";
    exit();
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Profile</title>
</head>
<body>
    <h2>Your Profile</h2>
    <p>Username: <?php echo $row['username']; ?></p>
    <p>Email: <?php echo $row['email']; ?></p>
    <p>Full Name: <?php echo $row['full_name']; ?></p>
    <p>Phone Number: <?php echo $row['phone_number']; ?></p>
    <a href="update.php">Update Profile</a>
    <a href="logout.php">Logout</a>
    <a href="delete.php">Delete Account</a>
</body>
</html>
