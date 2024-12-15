<?php
session_start();
include 'connectdb.php';

if (!isset($_SESSION['user_id'])) {
    header("Location: login.php");
    exit();
}

$user_id = $_SESSION['user_id'];
$sql = "SELECT email, full_name, phone_number FROM users WHERE id = $user_id";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
} else {
    echo "User not found.";
    exit();
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $email = $_POST['email'];
    $full_name = $_POST['full_name'];
    $phone_number = $_POST['phone_number'];

    $sql = "UPDATE users SET email='$email', full_name='$full_name', phone_number='$phone_number' WHERE id=$user_id";

    if ($conn->query($sql) === TRUE) {
        header("Location: profile.php");
        exit();
    } else {
        echo "Error updating record: " . $conn->error;
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Update Profile</title>
</head>
<body>
    <h2>Update Your Profile</h2>
    <form method="POST" action="update.php">
        <label>Email:</label>
        <input type="email" name="email" value="<?php echo $row['email']; ?>" required><br>
        <label>Full Name:</label>
        <input type="text" name="full_name" value="<?php echo $row['full_name']; ?>" required><br>
        <label>Phone Number:</label>
        <input type="text" name="phone_number" value="<?php echo $row['phone_number']; ?>" required><br>
        <button type="submit">Update</button>
    </form>
</body>
</html>
