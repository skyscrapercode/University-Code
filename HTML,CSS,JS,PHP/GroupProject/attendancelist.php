<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if manager details are stored in the session
if (!isset($_SESSION['EMP_ID'])) {
    echo "Manager not logged in. Please log in to continue, the system will redirect you to login page in 5 seconds";
    header("refresh:5; url=/groupproject/login.php");
    exit();
} elseif ($_SESSION['EMP_ROLE'] != 'manager') {
    echo "You're not authorized to view this page. Redirecting to the correct portal in 5 seconds";
    header("refresh:5; url=/groupproject/parttime.php");
    exit();
}

// Fetch all employees for the dropdown
$employee_query = "SELECT EMP_ID, EMP_NAME FROM employee WHERE EMP_ROLE <> 'manager'";
$employee_result = $conn->query($employee_query);

// Filter attendance data for selected employee
$attendance_query = "SELECT SHIFT_ID, employee.EMP_ID, EMP_NAME, ATTENDANCE, DATE 
                     FROM shift 
                     JOIN employee ON shift.EMP_ID = employee.EMP_ID";
if (isset($_POST['employee_id'])) {
    $employee_id = $_POST['employee_id'];
    $attendance_query .= " WHERE shift.EMP_ID = '$employee_id'"; // Filter by employee ID
}
$stmt = $conn->prepare($attendance_query);
$stmt->execute();
$attendance_result = $stmt->get_result();
?>

<!DOCTYPE html>
<html>
<head>
  <title>Attendance - Manager View</title>
  <link rel="icon" type="image/x-icon" href="image/favicon.ico">
  <link rel="stylesheet" href="style.css">
  <style>
    body {
      background-color: #FFF8E7;
      margin: 0; 
    }

    .container {
      max-width: 900px;
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
      background-color: #c0e2b3; /* Light green background */
    }

    th, td {
      border: 1px solid #ccc;
      padding: 10px;
      text-align: center;
    }

    th {
      background-color: #006400; /* Dark Green */
      color: white;
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

    .status-present {
      color: green;
      font-weight: bold;
    }

    .status-absent {
      color: red;
      font-weight: bold;
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
      <a href="/groupproject/attendancelist.php">Check Attendance</a>
      <a href="/groupproject/assignshift.php">Assign Jobs/Shift</a>
      <a href="/groupproject/leavemanage.php">Manage Leave</a>
      <a href="/groupproject/applicants.php">New Applicant</a>
      <a href="/groupproject/profile.php">Profile</a>
      <a href="/groupproject/manager.php">&#8592; Back</a>
    </div>
  </header>

  <div style="padding: 80px;">
    <div class="container">
      <h1>Attendance List</h1>

      <!-- Employee selection form -->
      <form method="POST">
        <div class="form-group">
          <label for="employee_id">Select Employee: </label>
          <select name="employee_id" id="employee_id" required onchange="this.form.submit()">
            <option value="">Select Employee</option>
            <?php while ($row = $employee_result->fetch_assoc()) { ?>
              <option value="<?php echo $row['EMP_ID']; ?>" <?php if (isset($employee_id) && $employee_id == $row['EMP_ID']) echo 'selected'; ?>>
                <?php echo htmlspecialchars($row['EMP_NAME']); ?>
              </option>
            <?php } ?>
          </select>
        </div>
      </form>

      <!-- Display attendance table -->
      <table>
        <thead>
          <tr>
            <th>No</th>
            <th>Worker Name</th>
            <th>Date</th>
            <th>Attendance Status</th>
          </tr>
        </thead>
        <tbody>
          <?php $counter = 1; ?>
          <?php while ($row = $attendance_result->fetch_assoc()): ?>
            <tr>
              <td><?php echo $counter++; ?></td>
              <td><?php echo htmlspecialchars($row['EMP_NAME']); ?></td>
              <td><?php echo htmlspecialchars($row['DATE']); ?></td>
              <td>
                <?php 
                  if ($row['ATTENDANCE'] == 1) {
                      echo "<span class='status-present'>Present</span>";
                  } else {
                      echo "<span class='status-absent'>Absent</span>";
                  }
                ?>
              </td>
            </tr>
          <?php endwhile; ?>
        </tbody>
      </table>
    </div>
  </div>
</body>
</html>

<?php
$conn->close(); // Close the database connection
?>
