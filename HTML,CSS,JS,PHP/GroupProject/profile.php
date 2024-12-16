<?php
// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "ptms";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Start the session at the very beginning of the file
session_start();

// Check if the email session variable is set
if (isset($_SESSION['email'])) {
    $email = $_SESSION['email']; // Retrieve the email from the session
}

// Fetch employee data (Example: Fetch first employee for demonstration)
$sql = "SELECT * FROM employee WHERE emp_email = $email"; // Adjust condition as needed
$result = $conn->query($sql);

if ($result && $result->num_rows > 0) {
    $employee = $result->fetch_assoc(); // Fetch employee data as associative array
} else {
    $employee = [];
}

// Close the database connection
$conn->close();
?>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Employee Info</title>
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
    table {
        margin: auto;
        text-align: center;
    }
    .profile-img {
        border-radius: 50%;
        border: 5px solid #ff8d8d;
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
    input[readonly] {
        background-color: #f8f8f8;
    }
    .btn-back {
        background-color: #f01b2d;
        color: white;
        font-size: 16px;
        border: none;
        padding: 10px 20px;
        border-radius: 5px;
        cursor: pointer;
        margin-top: 20px;
    }
    .btn-back:hover {
        background-color: #f4821f;
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

    <div class="content">
        <!-- Profile Picture -->
        <table width="35%" border="0" align="center">
            <tbody>
                <tr>
                    <td height="105" colspan="2" align="center">
                        <img src="image/defaultpfp.jpg" width="124" height="124" alt="Logo" class="profile-img">
                    </td>
                </tr>
            </tbody>
        </table>

        <!-- Employee Data Form -->
        <form style="margin-top:20px;">
            <p>
                <label for="name">NAME:</label>
                <input type="text" id="name" name="name" value="<?php echo htmlspecialchars($employee['emp_name']); ?>" readonly>
            </p>
            <p>
                <label for="phone">PHONE:</label>
                <input type="text" id="phone" name="phone" value="<?php echo htmlspecialchars($employee['emp_phone']); ?>" readonly>
            </p>
            <p>
                <label for="email">EMAIL:</label>
                <input type="email" id="email" name="email" value="<?php echo htmlspecialchars($employee['emp_email']); ?>" readonly>
            <p>
                <label for="address">ADDRESS:</label>
                <input type="text" id="address" name="address" value="<?php echo htmlspecialchars($employee['emp_addr']); ?>" readonly>
            </p>
            <p>
                <label for="dob">DATE OF BIRTH:</label>
                <input type="text" id="dob" name="dob" value="<?php echo htmlspecialchars($employee['emp_dob']); ?>" readonly>
            </p>
            <p>
                <label for="role">ROLE:</label>
                <input type="text" id="role" name="role" value="<?php echo htmlspecialchars($employee['emp_role']); ?>" readonly>
            </p>
            <button class="btn-back" type="button" onclick="window.history.back();">BACK</button>
        </form>
    </div>
</body>
</html>
