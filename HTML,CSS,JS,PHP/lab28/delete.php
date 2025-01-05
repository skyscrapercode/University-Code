<?php
session_start();
include 'connectdb.php';

$user_id = $_SESSION['user_id'];
$sql = "DELETE FROM users WHERE id = $user_id";

if ($conn->query($sql) === TRUE)
	echo "DELETE SUCCESSFUL!";

?>