<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if employee details are stored in the session and check if the user is indeed a part timer not manager
if (!isset($_SESSION['EMP_ID'])) 
{
    echo "Part timer employee not logged in. Please log in to continue, the system will redirect you to login page in 5 seconds";
    header("refresh:5; url=/groupproject/login.php");
    exit();
}
elseif ($_SESSION['EMP_ROLE'] == 'manager')
{
    echo "Your not an part timer, your a manager, the system will redirect you to the correct portal in 5 seconds";
    header("refresh:5; url=/groupproject/manager.php");
    exit();
}

$emp_id = $_SESSION['EMP_ID'];

// Fetch shift details
$shift_query = "SELECT JOB_ID, EMP_ID, STARTTIME, ENDTIME, PAYRATE, DATE FROM shift WHERE EMP_ID = ?";
$stmt = $conn->prepare($shift_query);
$stmt->bind_param("i", $emp_id);
$stmt->execute();
$shift_result = $stmt->get_result();

?>

<!DOCTYPE html>
<html>
<head>
    <title>Part Time</title>
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
    </style>
</head>
<body>
<header>
    <div class="company-info">
        <img src="image/7eleven.png" alt="7-Eleven Logo">
        7-Eleven
    </div>
    <div class="nav-buttons">
        <a href="/groupproject/attendance.php">Attendance</a>
        <a href="/groupproject/reqleave.php">Request Leave</a>
        <a href="/groupproject/profile.php">Profile</a>
        <a href="/groupproject/index.php">&#8592; Back</a>
    </div>
</header>
<div style="display: flex; justify-content: center; align-items: center; padding: 80px">
    <div class="container">
        <h1>PART TIME TIMETABLE</h1>

        <!-- Display Shift Details -->
        <table>
            <thead>
                <tr>
                    <th>Job ID</th>
                    <th>Start Time</th>
                    <th>End Time</th>
                    <th>Pay Rate</th>
                    <th>Date</th>
                </tr>
            </thead>
            <tbody>
                <?php if (!empty($shift)) : ?>
                    <?php while ($shift = $shift_result->fetch_assoc()): ?>
                        <tr>
                            <td><?php echo htmlspecialchars($shift['JOB_ID']); ?></td>
                            <td><?php echo htmlspecialchars($shift['STARTTIME']); ?></td>
                            <td><?php echo htmlspecialchars($shift['ENDTIME']); ?></td>
                            <td><?php echo htmlspecialchars($shift['PAYRATE']); ?></td>
                            <td><?php echo htmlspecialchars($shift['DATE']); ?></td>
                        </tr>
                    <?php endwhile; ?>
                <?php else : ?>
                    <div class="panel">
                        <p>No shifts assigned to you</p>
                    </div>
                <?php endif; ?>
            </tbody>
        </table>

    </div>
</div>
</body>
</html>

<?php
$conn->close(); // Close the database connection
?>
