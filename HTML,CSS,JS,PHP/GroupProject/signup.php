<?php
session_start();

// Include database connection
include 'dbconnection.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $email = trim($_POST['email']);
    $password = trim($_POST['password']);

    // Simple validation
    if ( empty($email) || empty($password)) {
        $error = "All fields are required.";
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $error = "Invalid email format.";
    } else {
        // Hash the password for security
        $hashed_password = MD5($password);

        // Insert into the employee table

        $sql1 = "SELECT * FROM APPLICANT JOIN APPLICATION ON APPLICANT.APP_ID = APPLICATION.APP_ID WHERE APP_EMAIL = '$email' AND STATUS =  'accepted'";

        $result1 = mysqli_query($conn, $sql1);

        if ($result1 && mysqli_num_rows($result1) > 0)
        {
          $resultData = $result1->fetch_assoc();

          $sql2 = "INSERT INTO employee (EMP_NAME, EMP_GENDER, EMP_PHONE, EMP_EMAIL, EMP_PASS, EMP_ROLE ) VALUES ('{$resultData['APP_NAME']}', '{$resultData['APP_GENDER']}', '{$resultData['APP_PHONE']}', {$resultData['APP_EMAIL']}, '{$resultData['APP_PASS']}', '{$resultData['APP_ROLE']}')";

          $result2 = mysqli_query($conn, $sql2);
          $result3 = mysqli_insert_id($conn)
          
          $sql4 = "SELECT EMP_ROLE FROM employee WHERE EMP_EMAIL = '$email' AND EMP_PASS = '$hashed_password'";

          $result4 = mysqli_query($conn, $sql4);

          $_SESSION['EMP_ID'] = $result3;
          $_SESSION['EMP_ROLE'] = $result4
          header("location: parttime.php");
        }
        else
        {
          echo "Your application was not approved or you did not apply yet. You will be redirected to the homepage in 5 seconds";
          header("refresh:5; url=/groupproject/index.php");
          exit();
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
      <a href="/index.php">&#8592; Back</a>
    </div>
  </header>
  <div style="padding: 80px;">
    <div class="container">
    <h1>Sign Up</h1>
        <form method="POST">
            <label for="email">Email</label>
            <input type="email" id="email" name="email" required>
            <label for="password">Password</label>
            <input type="password" id="password" name="password" required>
            <button type="submit">Sign Up</button>
        </form>

        <div class="switch-link">
          <p>Already have an account? <a href="login.php">Login</a></p>
        </div>
      </div>
    </div>
</body>
</html>
