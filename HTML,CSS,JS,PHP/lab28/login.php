<?php
session_start();
include 'connectdb.php';

$username = $_POST['username'];
$password = $_POST['password'];

if ($_POST['action'] === 'login') {
    $sql = "SELECT id, password FROM users WHERE username = '$username'";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        $row = $result->fetch_assoc();
        if ($password === $row['password']) {
            $_SESSION['user_id'] = $row['id'];
            header("Location: profile.php");
            exit();
        } else {
            echo "Invalid password.";
        }
    } else {
        echo "No user found with that username.";
    }
} elseif ($_POST['action'] === 'register') {

    $check_sql = "SELECT id FROM users WHERE username = '$username'";
    $check_result = $conn->query($check_sql);

    if ($check_result->num_rows > 0) {
        echo "Username already exists. Please choose another.";
    } else {
        $insert_sql = "INSERT INTO users (username, password) VALUES ('$username', '$password')";
        if ($conn->query($insert_sql) === TRUE) {
            echo "Registration successful. You can now log in.";
        } else {
            echo "Error: " . $conn->error;
        }
    }
} else {
    echo "Invalid action.";
}

?>
