<?php
session_start();
include 'dbconnection.php';

$message = ""; // Variable to store success or error message

// Fetch employee data
$sql = "SELECT emp_id, emp_name, emp_phone, emp_email, emp_addr, emp_dob, emp_gender FROM employee WHERE emp_ID = '{$_SESSION['EMP_ID']}'";
$stmt = $conn->prepare($sql);
if (!$stmt) {
    die("Query preparation failed: " . $conn->error);
}

if (!$stmt->execute()) {
    die("Query execution failed: " . $stmt->error);
}

$result = $stmt->get_result();
if ($result && $result->num_rows > 0) {
    $employee = $result->fetch_assoc();
} else {
    die("No employee found with the provided ID.");
}

// Update employee data
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $emp_id = $employee['emp_id'];
    $name = $_POST['name'];
    $phone = $_POST['phone'];
    $gender = $_POST['gender']; // Get gender from radio buttons
    $email = $_POST['email'];
    $new_password = $_POST['password'];
    $address = $_POST['address'];
    $dob = $_POST['dob'];

    if (!empty($_POST['password'])) {
        $update_sql = "UPDATE employee SET emp_name = ?, emp_phone = ?, emp_email = ?, emp_addr = ?, emp_dob = ?, emp_gender = ?, emp_pass = ? WHERE emp_id = ?";
        $update_stmt = $conn->prepare($update_sql); // Prepare the statement
        if (!$update_stmt) {
            $message = "Statement preparation failed: " . $conn->error;
        }

        $latestPassword = password_hash($new_password, PASSWORD_BCRYPT);

        $update_stmt->bind_param("sssssssi", $name, $phone, $email, $address, $dob, $gender, $latestPassword, $emp_id);
    } else {
        $update_sql = "UPDATE employee SET emp_name = ?, emp_phone = ?, emp_gender = ?, emp_email = ?, emp_addr = ?, emp_dob = ? WHERE emp_id = ?";
        $update_stmt = $conn->prepare($update_sql); // Prepare the statement
        if (!$update_stmt) {
            $message = "Statement preparation failed: " . $conn->error;
        }
        $update_stmt->bind_param("ssssssi", $name, $phone, $gender, $email, $address, $dob, $emp_id);
    }

    if ($update_stmt->execute()) {
        $message = "Profile updated successfully.";
    } else {
        $message = "Failed to update profile.";
    }
}

// Close the database connection
$conn->close();
?>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Edit Employee Info</title>
<link rel="icon" type="image/x-icon" href="image/favicon.ico">
<link rel="stylesheet" href="style.css">
<style>
    body {
        background-color: #f8f9fa;
        margin: 0;
        padding: 0;
        color: #333;
    }
    .content {
        margin: 50px auto;
        width: 50%;
        padding: 20px;
        background-color: white;
        border-radius: 10px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    }
    .message {
        padding: 10px;
        margin-bottom: 15px;
        border-radius: 5px;
        text-align: center;
    }
    .success {
        background-color: #d4edda;
        color: #155724;
        border: 1px solid #c3e6cb;
    }
    .error {
        background-color: #f8d7da;
        color: #721c24;
        border: 1px solid #f5c6cb;
    }
    label {
        display: block;
        font-weight: bold;
        color: #008161;
        margin-bottom: 5px;
    }
    input {
        margin-bottom: 15px;
        padding: 10px;
        width: calc(100% - 20px);
        border: 2px solid #ff8d8d;
        border-radius: 5px;
        font-size: 14px;
        color: #333;
        background-color: #fff;
    }
    input[type="radio"] {
        margin-right: 10px;
        width: auto;
        height: auto;
        vertical-align: middle;
    }
    .btn {
        background-color: #008161;
        color: white;
        font-size: 16px;
        border: none;
        padding: 10px 20px;
        border-radius: 5px;
        cursor: pointer;
        margin-top: 20px;
    }
    .btn:hover {
        background-color: #006644;
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
            <a href="javascript:void(0);" onclick="window.history.back();">&#8592; Back</a>
        </div>
    </header>

    <div class="content">
        <h1 style="color:green">Employee Profile:</h1>

        <!-- Display Success or Error Message -->
        <?php if (!empty($message)): ?>
            <div class="message <?php echo strpos($message, 'successfully') !== false ? 'success' : 'error'; ?>">
                <?php echo htmlspecialchars($message); ?>
            </div>
        <?php endif; ?>

        <!-- Employee Data Form -->
        <form method="post" style="margin-top:20px;">
            <p>
                <label for="name">NAME:</label>
                <input type="text" id="name" name="name" value="<?php echo htmlspecialchars($employee['emp_name']); ?>" required>
            </p>
            <p>
                <label for="phone">PHONE:</label>
                <input type="text" id="phone" name="phone" value="<?php echo htmlspecialchars($employee['emp_phone']); ?>" required>
            </p>
            <p>
                <label for="gender">GENDER:</label><br>
                <input type="radio" id="male" name="gender" value="M" <?php echo ($employee['emp_gender'] == 'M') ? 'checked' : ''; ?>> Male
                <input type="radio" id="female" name="gender" value="F" <?php echo ($employee['emp_gender'] == 'F') ? 'checked' : ''; ?>> Female
            </p>
            <p>
                <label for="email">EMAIL:</label>
                <input type="email" id="email" name="email" value="<?php echo htmlspecialchars($employee['emp_email']); ?>" required>
            </p>
            <p>
                <label for="password">NEW PASSWORD:</label>
                <input type="password" id="password" name="password" placeholder="Enter new password (leave blank to keep current)">
            </p>
            <p>
                <label for="address">ADDRESS:</label>
                <input type="text" id="address" name="address" value="<?php echo htmlspecialchars($employee['emp_addr']); ?>" required>
            </p>
            <p>
                <label for="dob">DATE OF BIRTH:</label>
                <input type="date" id="dob" name="dob" value="<?php echo htmlspecialchars($employee['emp_dob']); ?>" required>
            </p>
            <button class="btn" type="submit">SAVE CHANGES</button>
        </form>
    </div>
</body>
</html>

