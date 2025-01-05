<?php
session_start();
include 'dbconnection.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $email = trim($_POST['email']);
    $password = trim($_POST['password']);

    if (empty($email) || empty($password)) {
        $error = "Both fields are required.";
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $error = "Invalid email format.";
    } else {
        $stmt = $conn->prepare("SELECT EMP_ID, EMP_ROLE, EMP_PASS FROM employee WHERE EMP_EMAIL = ?");
        $stmt->bind_param("s", $email);
        $stmt->execute();
        $result = $stmt->get_result();

        if ($result && $result->num_rows > 0) {
            $user = $result->fetch_assoc();

            // Use password_verify for secure password checking
            if (password_verify($password, $user['EMP_PASS'])) {
                $_SESSION['EMP_ID'] = $user['EMP_ID'];
                $_SESSION['EMP_ROLE'] = $user['EMP_ROLE'];

                // Redirect based on EMP_ROLE
                if ($user['EMP_ROLE'] === 'manager') {
                    header("Location: manager.php");
                } else {
                    header("Location: parttime.php");
                }
                exit;
            } else {
                $error = "Invalid email or password.";
            }
        } else {
            $error = "Invalid email or password.";
        }
    }
}

$conn->close();

?>



<!DOCTYPE html>
<html>
<head>
  <title>Login</title>
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
      <h1>Login</h1>
      <?php if (!empty($error)): ?>
        <div class="error"> <?php echo htmlspecialchars($error); ?> </div>
      <?php endif; ?>
      <form method="POST">
        <label for="email">Email</label>
        <input type="email" id="email" name="email" placeholder="Enter your email" required>

        <label for="password">Password</label>
        <input type="password" id="password" name="password" placeholder="Enter your password" required>

        <button type="submit">Login</button>
      </form>
      <div class="switch-link">
        <p>Don't have an account? <a href="signup.php">Sign Up</a></p>
      </div>
    </div>
</body>
</html> 