<?php 
    $host= 'localhost';
    $user= 'root';
    $password = "";
    $database = 'PangkalanData';

    $conn = mysqli_connect($id,$username,$password,$cpassword, $date);

    if (!$conn) {                                             
        die("Connection failed: " . mysqli_connect_error());     
      }

?>