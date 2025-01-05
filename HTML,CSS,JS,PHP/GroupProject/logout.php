<?php
session_start(); // Start the session
session_destroy(); // Destroy all session data
header("Location: /groupproject/index.php"); // Redirect to the index page
exit();
?>