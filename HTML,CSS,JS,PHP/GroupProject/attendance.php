<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if employee details are stored in the session
if (!isset($_SESSION['EMP_ID'])) {
    die("Employee not logged in. Please log in to continue.");
}

$emp_id = $_SESSION['EMP_ID'];

// Fetch attendance data from the database
$attendance_query = "SELECT EMP_NAME, ATTENDANCE FROM shift JOIN employees ON shift.EMP_ID = employees.EMP_ID WHERE employees.EMP_ID = ?";
$stmt = $conn->prepare($attendance_query);
$stmt->bind_param("i", $emp_id);
$stmt->execute();
$attendance_result = $stmt->get_result();

// Function to update attendance
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['attendance'])) {
    $attendance_status = $_POST['attendance'] === '1' ? 1 : 0;
    $update_query = "UPDATE shift SET ATTENDANCE = ? WHERE EMP_ID = ?";
    $stmt = $conn->prepare($update_query);
    $stmt->bind_param("ii", $attendance_status, $emp_id);
    $stmt->execute();
    header("Location: attendance.php"); // Refresh the page after update
    exit;
}
?>

<!DOCTYPE html>
<html>
<head>
  <title>Attendance</title>
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

    .back-button {
      display: block;
      text-align: center;
      margin-top: 20px;
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

    .update-form {
      text-align: center;
      margin-top: 20px;
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
      <a href="/parttime.php">&#8592; Back</a>
    </div>
  </header>
  <div style="padding: 80px;">
    <div class="container">
      <h1>Attendance List</h1>
      <table>
        <thead>
          <tr>
            <th>No</th>
            <th>Worker Name</th>
            <th>Attendance</th>
          </tr>
        </thead>
        <tbody>
          <?php $counter = 1; ?>
          <?php while ($row = $attendance_result->fetch_assoc()): ?>
            <tr>
              <td><?php echo $counter++; ?></td>
              <td><?php echo htmlspecialchars($row['EMP_NAME']); ?></td>
              <td><?php echo $row['ATTENDANCE'] ? 'Present' : 'Absent'; ?></td>
            </tr>
          <?php endwhile; ?>
        </tbody>
      </table>

      <div class="update-form">
        <form method="POST">
          <label for="attendance">Mark Attendance:</label>
          <select name="attendance" id="attendance">
            <option value="1">Present</option>
            <option value="0">Absent</option>
          </select>
          <button type="submit">Update</button>
        </form>
      </div>
    </div>
  </div>
</body>
</html>

<?php
$conn->close(); // Close the database connection
?>
