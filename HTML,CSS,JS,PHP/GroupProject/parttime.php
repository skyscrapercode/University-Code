<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if employee details are stored in the session and check if the user is indeed a part-timer, not a manager
if (!isset($_SESSION['EMP_ID'])) {
    echo "Part-timer employee not logged in. Please log in to continue. The system will redirect you to the login page in 5 seconds.";
    header("refresh:5; url=/groupproject/login.php");
    exit();
} elseif ($_SESSION['EMP_ROLE'] == 'manager') {
    echo "You are not a part-timer, you are a manager. The system will redirect you to the correct portal in 5 seconds.";
    header("refresh:5; url=/groupproject/manager.php");
    exit();
}

$emp_id = $_SESSION['EMP_ID'];

// Fetch shift details
$shift_query = "SELECT SHIFT_ID, JOB_ID, EMP_ID, STARTTIME, ENDTIME, PAYRATE, DATE, ATTENDANCE FROM shift WHERE EMP_ID = ?";
$stmt = $conn->prepare($shift_query);

if (!$stmt) {
    die("Failed to prepare query: " . $conn->error);
}

$stmt->bind_param("i", $emp_id);
$stmt->execute();
$shift_result = $stmt->get_result();

$sql1 = "SELECT EMP_NAME FROM employee WHERE EMP_ID = '{$_SESSION['EMP_ID']}'";
$resultSQL = mysqli_query($conn, $sql1);
$row = mysqli_fetch_assoc($resultSQL);
$results = $row['EMP_NAME'];

// Function to update attendance
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['attendance']) && isset($_POST['shift_id'])) {
    $attendance_status = $_POST['attendance'];
    $shift_id = $_POST['shift_id'];

    // Ensure the attendance status is a valid integer (either 1 or 0)
    if ($attendance_status == 1 || $attendance_status == 0) {
        $update_query = "UPDATE shift SET ATTENDANCE = ? WHERE SHIFT_ID = ?";
        $stmt = $conn->prepare($update_query);
        $stmt->bind_param("ii", $attendance_status, $shift_id);
        $stmt->execute();
        header("Location: parttime.php"); // Refresh the page after update
        exit;
    } else {
        echo "Invalid attendance status.";
    }
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Part Time</title>
    <link rel="icon" type="image/x-icon" href="image/favicon.ico">
    <link rel="stylesheet" href="style.css">
    <style>
    body {
      background-color: #FFF8E7;
      margin: 0; 
    }

    .container {
      max-width: 600px;
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
    }

    table {
      width: 100%;
      border-collapse: collapse;
      margin: 20px 0;
    }

    th, td {
      border: 1px solid #ccc;
      padding: 10px;
      text-align: center;
    }

    th {
      background-color: #ff8d8d;
    }

    .panel {
      padding: 10px;
      border: 1px solid #008161;
      margin-top: 20px;
      background-color: #FFF8E7; /* Warm white */
    }

    .panel p {
      margin: 0;
      color: #008161; /* Green text */
    }

    button {
      background-color: #f4821f;
      color: white;
      padding: 10px 20px;
      border: none;
      cursor: pointer;
      border-radius: 5px;
    }

    button:hover {
      background-color: #008161;
    }

    .attendance-dropdown {
      width: 120px;
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
        <a href="/groupproject/reqleave.php">Request Leave</a>
        <a href="/groupproject/profile.php">Profile</a>
        <a href="/groupproject/logout.php">Logout</a>
    </div>
</header>
<div style="display: flex; justify-content: center; align-items: center; padding: 80px">
    <div class="container">
        <h3> Welcome, <?php echo $results; ?> </h3>
        <h1>PART TIME TIMETABLE</h1>

        <!-- Display Shift Details -->
        <table>
            <thead>
                <tr>
                    <th>No.</th>
                    <th>Start Time</th>
                    <th>End Time</th>
                    <th>Pay Rate</th>
                    <th>Date</th>
                    <th>Total Pay</th>
                    <th>Attendance</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <?php if ($shift_result && $shift_result->num_rows > 0): ?>
                    <?php 
                    $counter = 1; // Initialize counter
                    while ($shift = $shift_result->fetch_assoc()): 
                        // Calculate total pay
                        $start_time = new DateTime($shift['STARTTIME']);
                        $end_time = new DateTime($shift['ENDTIME']);
                        $interval = $start_time->diff($end_time);
                        $hours_worked = $interval->h + ($interval->i / 60); // Include minutes as fractional hours
                        $total_pay = $hours_worked * $shift['PAYRATE'];

                        // Format times
                        $formatted_start_time = $start_time->format('g:i A');
                        $formatted_end_time = $end_time->format('g:i A');

                        // Convert attendance values
                        $attendance = ($shift['ATTENDANCE'] == 1) ? 'Present' : ($shift['ATTENDANCE'] == 0 ? 'Absent' : 'Unknown');
                    ?>
                        <tr>
                            <td><?php echo $counter++; ?></td> <!-- Display increasing number -->
                            <td><?php echo htmlspecialchars($formatted_start_time); ?></td>
                            <td><?php echo htmlspecialchars($formatted_end_time); ?></td>
                            <td><?php echo htmlspecialchars($shift['PAYRATE']); ?></td>
                            <td><?php echo htmlspecialchars($shift['DATE']); ?></td>
                            <td><?php echo number_format($total_pay, 2); ?></td>
                            <td>
                                <form method="POST">
                                    <select name="attendance" class="attendance-dropdown">
                                        <option value="1" <?php echo $shift['ATTENDANCE'] == 1 ? 'selected' : ''; ?>>Present</option>
                                        <option value="0" <?php echo $shift['ATTENDANCE'] == 0 ? 'selected' : ''; ?>>Absent</option>
                                    </select>
                                    <input type="hidden" name="shift_id" value="<?php echo $shift['SHIFT_ID']; ?>" />
                            </td>
                            <td>
                                <button type="submit">Update</button>
                                </form>
                            </td>
                        </tr>
                    <?php endwhile; ?>
                <?php else: ?>
                    <div class="panel">
                        <p>No shifts assigned to you.</p>
                    </div>
                <?php endif; ?>
            </tbody>
        </table>

    </div>
</div>
</body>
</html>

<?php
$stmt->close(); // Close the statement
$conn->close(); // Close the database connection
?>
