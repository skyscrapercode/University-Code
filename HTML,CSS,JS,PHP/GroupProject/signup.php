<?php
session_start();

// Include database connection
include 'dbconnection.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $full_name = trim($_POST['full_name']);
    $email = trim($_POST['email']);
    $password = trim($_POST['password']);

    // Simple validation
    if (empty($full_name) || empty($email) || empty($password)) {
        $error = "All fields are required.";
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $error = "Invalid email format.";
    } else {
        // Hash the password for security
        $hashed_password = MD5($password);

        // Insert into the employee table

        $sql1 = "SELECT EMP_ROLE FROM APPLICANT JOIN APPLICATION ON APP_ID = APP_ID WHERE APP_EMAIL = '$email' AND 'STATUS' =  'accepted'"

        $result1 = mysqli_query($conn, $sql1);
      
        if ($result1 && mysqli_num_rows($result1) > 0)
        {
          $sql2 = "INSERT INTO employee (EMP_NAME, EMP_EMAIL, EMP_PASS, EMP_ROLE ) VALUES ('$full_name', '$email', '$hashed_password', '$result1')";

          $result2 = mysqli_query($conn, $sql2);

          $sql3 = "SELECT EMP_ID FROM employee WHERE EMP_EMAIL = '$email' AND EMP_PASS = '$hashed_password'";

          $result3 = mysqli_query($conn, $sql3);

          $_SESSION['EMP_ID'] = $result3;
          header("location: parttime.php");
        }
        else
        {
          die('Your application was not approve or you did not apply');
        }
    }
}

$conn->close();
?>
<!DOCTYPE html>
<html>
<head>
    <title>Sign Up</title>
    <link rel="stylesheet" href="style.css">
    <style>
    body {
      background-color: #FFF8E7;
      margin: 0;
    }

    .container {
      max-width: 400px;
      margin: 0 auto;
      background-color: #fff;
      padding: 20px;
      border: 1px solid #ccc;
      border-radius: 10px;
      box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    }

    h1 {
      text-align: center;
      color: #008161;
      border-bottom: 2px solid #008161;
      padding-bottom: 5px;
      margin-bottom: 20px;
    }

    form {
      display: flex;
      flex-direction: column;
    }

    label {
      margin: 10px 0 5px;
      font-weight: bold;
    }

    input, button {
      padding: 10px;
      margin-bottom: 15px;
      border: 1px solid #ccc;
      border-radius: 5px;
      font-size: 16px;
    }

    button {
      background-color: #f4821f;
      color: white;
      cursor: pointer;
      border: none;
    }

    button:hover {
      background-color: #008161;
    }

    .switch-link {
      text-align: center;
      margin-top: 10px;
    }

    .switch-link a {
      text-decoration: none;
      color: #008161;
    }

    .switch-link a:hover {
      text-decoration: underline;
    }
  </style>
</head>
<body>
  <header>
    <div class="company-info">
      <img src="image/7eleven.png" alt="7-Eleven Logo">
      7-Eleven
    </div>
    <div class="nav-buttons">
      <a href="/index.html">&#8592; Back</a>
    </div>
  </header>
  <div style="padding: 80px;">
    <div class="container">
    <h1>Sign Up</h1>
        <form method="POST">
            <label for="full_name">Full Name</label>
            <input type="text" id="full_name" name="full_name" required>
            <label for="email">Email</label>
            <input type="email" id="email" name="email" required>
            <label for="password">Password</label>
            <input type="password" id="password" name="password" required>
            <button type="submit">Sign Up</button>
        </form>

        <div class="switch-link">
          <p>Already have an account? <a href="login.html">Login</a></p>
        </div>
      </div>
    </div>
</body>
</html>
