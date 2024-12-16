<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if employee details are stored in the session
if (!isset($_SESSION['EMP_ID'])) {
    die("Employee not logged in. Please log in to continue.");
}

$emp_id = $_SESSION['EMP_ID'];

// Fetch leave status from the database
$leave_query = "SELECT STARTDATE, ENDDATE, TYPE, LEAVE_STATUS FROM `leave` WHERE EMP_ID = ?";
$stmt = $conn->prepare($leave_query);
$stmt->bind_param("i", $emp_id);
$stmt->execute();
$leave_result = $stmt->get_result();
?>

<!DOCTYPE html>
<html>
<head>
  <title>Leave Status</title>
  <link rel="stylesheet" href="style.css">
  <style>
    body {
      background-color: #FFF8E7;
      margin: 0;
    }

    .container {
      max-width: 800px;
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

  </style>
</head>
<body>
  <header>
    <div class="company-info">
      <img src="image/7eleven.png" alt="7-Eleven Logo">
      7-Eleven
    </div>
    <div class="nav-buttons">
      <a href="/groupproject/reqleave.php">&#8592; Back</a>
    </div>
  </header>
  <div style="padding: 80px;">
    <div class="container">
      <h1>Leave Status</h1>
      <table>
        <thead>
          <tr>
            <th>No</th>
            <th>Start Date</th>
            <th>End Date</th>
            <th>Leave Type</th>
            <th>Status</th>
          </tr>
        </thead>
        <tbody>
          <?php if ($leave_result->num_rows > 0): ?>
            <?php $counter = 1; ?>
            <?php while ($row = $leave_result->fetch_assoc()): ?>
              <tr>
                <td><?php echo $counter++; ?></td>
                <td><?php echo htmlspecialchars($row['STARTDATE']); ?></td>
                <td><?php echo htmlspecialchars($row['ENDDATE']); ?></td>
                <td><?php echo htmlspecialchars($row['TYPE']); ?></td>
                <td><?php echo htmlspecialchars($row['LEAVE_STATUS']); ?></td>
              </tr>
            <?php endwhile; ?>
          <?php else: ?>
            <tr>
              <td colspan="5">No leave requests found.</td>
            </tr>
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
