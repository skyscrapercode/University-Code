<?php
include 'dbconnect.php';

$uname = $_POST['username'];
$pwd = $_POST['password'];

//echo "Username : ".uname."<br>Password :".pwd

//check the data exists or not

$sql = "SELECT * FROM user where username = '$uname' ";

$data = mysql_query($conn, $sql);

if ($data)
{
	$sql2  = "INSERT INTO user(username, password) VALUES '$uname', '$pwd' ";

	echo "Thank you for your registration";
}
else
{
	//later implement redirect user to the login page
	echo "Your data is already exists";
}


?>