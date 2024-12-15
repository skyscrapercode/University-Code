<?php  
//connection to mySQL 
$host="localhost"; 
$username="root"; 
$password=""; 
$link = mysqli_connect($host,$username,$password)or die("Could not connect");
echo "Berjaya connect mySQL server <p>" ;
//connection to database 
$db = mysqli_select_db( $link,"student")or die("Could not select database"); 
echo "Database student connected";
?>