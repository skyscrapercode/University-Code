<?php 
include 'connectdb.php';

$first_name = $_POST['first_name'];
$last_name = $_POST['last_name'];
$age = $_POST['age'];
$email = $_POST['email'];
$active = $_POST['active'];

$sql = "INSERT INTO student (first_name, last_name, age, email, active) VALUES ('$first_name', '$last_name', '$age', '$email', '$active')";

// echo "Student added successfully.  <a href='view.php'>View Students</a>";

if(mysqli_query($link, $sql)){
    echo "<!DOCTYPE html>
<html>
<head>
	<title>Successfull</title>

    <style type='text/css'>
		#wrapper {
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      background: linear-gradient(112.2deg, rgb(0, 204, 255) -1.1%, rgb(0, 221, 61) 100.7%);
      height: 100vh; 
      margin: 0; 

    }

    .container {
    background: linear-gradient(to right, rgb(182, 244, 146), rgb(51, 139, 147));
    box-shadow: 0 0 20 rgba(0, 0, 0, 0.2);
    max-width: 800;
    width: 10%;
    padding: 5px;
    margin: 0px;
    text-align: center;
    backdrop-filter: blur(10px);
    border-radius: 5px;
    opacity: 90%;
    color:white;

  }
	</style>

</head>
<body ID = 'wrapper' >


    <form class = 'container' action= 'view.php' method = 'post'>
        <legend style = 'color:black'> Student Added Successfully </legend>
        <br>
        <button type='submit' style=' background-color: #4CAF50; color: white; cursor: pointer; font-size: 15px; border-radius: 5px; color:black;'>View Students</button>
    </form>


</body>
</html>";
} else {
    echo "ERROR: Could not able to execute $sql. " . mysqli_error($link);
}

?>