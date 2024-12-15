<?php
include 'connectdb.php';

$id = $_POST['id'];

$query = "DELETE FROM Student WHERE id = $id";

// echo "Record deleted successfully! <a href='view.php'>View Student</a>";

if (mysqli_query($link, $query)) {
    echo "<!DOCTYPE html>
<html>
<head>
	<title>Deleted</title>

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
        <legend style = 'color:black'> Student Removed Successfully </legend>
        <br>
        <button type='submit' style=' background-color: #4CAF50; color: white; cursor: pointer; font-size: 15px; border-radius: 5px; color:black;'>View Students</button>
    </form>


</body>
</html>";
} else {
    echo "Error: " . mysqli_error($link);
}

mysqli_close($link);
?>