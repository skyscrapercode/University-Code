<?php
session_start();

// Include database connection
include 'dbconnection.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $email = trim($_POST['email']);
  $password = trim($_POST['password']);

  if (empty($email) || empty($password)) {
      $error = "All fields are required.";
  } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
      $error = "Invalid email format.";
  } else {
      // Check if email exists
      $stmt = $conn->prepare("SELECT EMP_EMAIL FROM employee WHERE EMP_EMAIL = ?");
      $stmt->bind_param("s", $email);
      $stmt->execute();
      $stmt->store_result();

      if ($stmt->num_rows > 0) {
          echo "You already have an account. Redirecting...";
          header("Location: login.php");
          exit();
      }

      // Process accepted applicants
      $app_stmt = $conn->prepare("SELECT * FROM APPLICANT JOIN APPLICATION ON APPLICANT.APP_ID = APPLICATION.APP_ID WHERE APP_EMAIL = ? AND STATUS = 'accepted'");
      $app_stmt->bind_param("s", $email);
      $app_stmt->execute();
      $result = $app_stmt->get_result();

      if ($result && $result->num_rows > 0) {
          $resultData = $result->fetch_assoc();
          $hashed_password = password_hash($password, PASSWORD_BCRYPT);

          // Insert into employees
          $emp_stmt = $conn->prepare("INSERT INTO employee (EMP_NAME, EMP_GENDER, EMP_PHONE, EMP_EMAIL, EMP_PASS, EMP_ADDR, EMP_DOB, EMP_ROLE) VALUES (?, ?, ?, ?, ?, ?, ?, ?)");
          $emp_stmt->bind_param("ssssssss", $resultData['APP_NAME'], $resultData['APP_GENDER'], $resultData['APP_PHONE'], $resultData['APP_EMAIL'], $hashed_password, $resultData['APP_ADDR'], $resultData['APP_DOB'], $resultData['APP_TYPE']);
          $emp_stmt->execute();

          $_SESSION['EMP_ID'] = $conn->insert_id;
          $_SESSION['EMP_ROLE'] = $resultData['APP_TYPE'];
          header("Location: parttime.php");
      } else {
          echo "Your application was not approved.";
          header("Location: index.php");
      }
  }
}


$conn->close();
?>
<!DOCTYPE html>
<html>
<head>
    <title>Sign Up</title>
    <link rel="icon" type="image/x-icon" href="image/favicon.ico">
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
      <a href="/groupproject/index.php">&#8592; Back</a>
    </div>
  </header>
  <div style="padding: 80px;">
    <div class="container">
    <h1>Sign Up</h1>
        <form method="POST">
            <label for="email">Email</label>
            <input type="email" id="email" name="email" placeholder="Enter your email" required>
            <label for="password">Password</label>
            <input type="password" id="password" name="password" placeholder="Enter your password" required>
            <button type="submit">Sign Up</button>
        </form>

        <div class="switch-link">
          <p>Already have an account? <a href="login.php">Login</a></p>
        </div>
      </div>
    </div>
</body>
</html>
