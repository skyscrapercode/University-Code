<?php
// Start a session
session_start();

include 'dbconnection.php';

// Initialize variables
$status_message = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Get the email input
    $email = mysqli_real_escape_string($conn, $_POST['email']);

    // SQL query to fetch the approval status of the user
   $sql = "SELECT a.APP_NAME, app.STATUS 
            FROM applicant a
            JOIN application app ON a.APP_ID = app.APP_ID
            WHERE a.APP_EMAIL = '$email'";

    $result = mysqli_query($conn, $sql);

    if ($result && mysqli_num_rows($result) > 0) {
        // Fetch user status
        $row = mysqli_fetch_assoc($result);
        $app_name = $row['APP_NAME'];
        $status = $row['STATUS'];

        // Set the message based on the status
        if (strtolower($status) == "accepted") {
            $status_message = "Hello $app_name, your status is <strong style='color:green;'>APPROVED</strong>.<p>You can now <a href='signup.php'>Sign up here</p></a>";
        } elseif (strtolower($status) == "rejected") {
            $status_message = "Hello $app_name, your status is <strong style='color:red;'>REJECTED</strong>.";
        } else {
            $status_message = "Hello $app_name, your status is <strong style='color:orange;'>PENDING</strong>.";
        }
    } else {
        $status_message = "<span style='color:black;'>It looks like you have not applied yet.<a href='apply.php'><p>APPLY HERE!!!</p></a></span>";
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Status Check</title>
    <link rel="stylesheet" href="style.css">
    <style>
        body {
            font-family: Arial, sans-serif;
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

        .status-message {
            text-align: center;
            margin-top: 20px;
            font-size: 18px;
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
        <h1>Check Status</h1>
        <form action="" method="POST">
            <label for="email">Email</label>
            <input type="email" id="email" name="email" placeholder="Enter your email" required>

            <button type="submit">Check</button>
        </form>

        <?php if ($status_message): ?>
            <div class="status-message">
                <?php echo $status_message; ?>
            </div>
        <?php endif; ?>
    </div>
</div>
</body>
</html>
