<?php
session_start();
include 'dbconnection.php';

// Check if employee details are stored in the session and if the user is indeed a manager
if (!isset($_SESSION['EMP_ID'])) {
    echo "Manager employee not logged in. Please log in to continue, the system will redirect you to login page in 5 seconds";
    header("refresh:5; url=/groupproject/login.php");
    exit();
} elseif ($_SESSION['EMP_ROLE'] != 'manager') {
    echo "You are not a manager, you are a part-timer. The system will redirect you to the correct portal in 5 seconds";
    header("refresh:5; url=/groupproject/parttime.php");
    exit();
}

$sql1 = "SELECT EMP_NAME FROM employee WHERE EMP_ID = '{$_SESSION['EMP_ID']}'";
$resultSQL = mysqli_query($conn, $sql1);
$row = mysqli_fetch_assoc($resultSQL);
$results = $row['EMP_NAME'];

// Handle role filter
$selectedRole = isset($_GET['role']) ? $_GET['role'] : '';

$sqlFilter = "SELECT EMP_NAME, EMP_PHONE, EMP_EMAIL, EMP_ADDR, EMP_DOB, EMP_ROLE FROM employee WHERE EMP_ROLE <> 'manager'";
if (!empty($selectedRole)) {
    $sqlFilter .= " AND EMP_ROLE = '" . mysqli_real_escape_string($conn, $selectedRole) . "'";
}

$result = $conn->query($sqlFilter);
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Manager Dashboard</title>
  <link rel="icon" type="image/x-icon" href="image/favicon.ico">
  <link rel="stylesheet" href="style.css">
  <style>
     body { 
      margin: 0; /* Remove default body margin */
      padding: 0; /* Remove default padding */
      display: flex;
      flex-direction: column;
      background-color: #f8f8f8;
    }
    .container {
      flex: 1;
      display: flex;
      flex-direction: column;
      max-width: 1200px;
      margin: auto;
      padding: 20px;
      width: 100%;
    }
    .content {
      display: flex;
      flex: 1;
    }
    .left-panel {
      flex: 1;
    }
    .right-panel {
      flex: 1;
      margin-right: -100px;
      margin-left: 50px;
    }

    .right-panel a {
      text-decoration: none; /* Remove underline from the link */
      color: inherit; /* Inherit the color to prevent default blue text */
    }
    .table-section {
      background-color: #ffffff;
      border-radius: 8px;
      padding: 20px;
      box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
      margin-left: -40px;
    }
    table {
      width: 100%;
      border-collapse: collapse;
    }
    th, td {
      border: 1px solid #ddd;
      padding: 8px;
      text-align: left;
    }
    th {
      background-color: #008161;
      color: #ffffff;
    }

    .graph-section {
      height: 300px;
      background-color: #008161;
      border-radius: 8px;
      text-align: center;
      line-height: 300px;
      font-size: 40px;
      color: #ffffff;
      margin-bottom: 20px;
      cursor: pointer;
      transition: all 0.3s ease;
      border: 2px solid black;
    }
    .graph-section:hover {
      background: url('image/statimange.jpg') no-repeat center center;
      background-size: cover;
      color: transparent;
    }
    .bottom-buttons {
      display: flex;
      justify-content: space-between;
    }
    .bottom-buttons a {
      flex: 1;
      background-color: #ff8d8d;
      color: #ffffff;
      padding: 15px;
      text-align: center;
      border-radius: 8px;
      font-size: 22px;
      transition: all 0.3s ease;
    }
    .bottom-buttons a:hover {
      background-color: #f01b2d;
      transform: scale(1.1);
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
      <a href="/groupproject/logout.php">Logout</a>
    </div>
  </header>

  <div class="container">
    <div class="content">
      <!-- Left Panel -->
      <div class="left-panel">
        <div class="table-section">
          <h3>Welcome, <?php echo $results; ?></h3>
          <h3>Part Timer List</h3>
          <form method="get" action="">
            <label for="role">Filter by Role:</label>
            <select id="role" name="role" onchange="this.form.submit()">
              <option value="">All</option>
              <option value="cleaner" <?php echo $selectedRole == 'cleaner' ? 'selected' : ''; ?>>Cleaner</option>
              <option value="stocker" <?php echo $selectedRole == 'stocker' ? 'selected' : ''; ?>>Stocker</option>
              <option value="cashier" <?php echo $selectedRole == 'cashier' ? 'selected' : ''; ?>>Cashier</option>
            </select>
          </form>
          <table>
            <thead>
              <tr>
                <th>No.</th>
                <th>Employee's Name</th>
                <th>Employee's Number</th>
                <th>Employee's Email</th>
                <th>Employee's Address</th>
                <th>Employee's Date of Birth</th>
                <th>Employee's Role</th>
              </tr>
            </thead>
            <tbody>
              <?php
              $counter = 1;

              if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                  echo "<tr>
                          <td>{$counter}</td>
                          <td>{$row['EMP_NAME']}</td>
                          <td>{$row['EMP_PHONE']}</td>
                          <td>{$row['EMP_EMAIL']}</td>
                          <td>{$row['EMP_ADDR']}</td>
                          <td>{$row['EMP_DOB']}</td>
                          <td>{$row['EMP_ROLE']}</td>
                        </tr>";
                  $counter++;
                }
              } else {
                echo "<tr><td colspan='7'>No Data Available</td></tr>";
              }
              $conn->close();
              ?>
            </tbody>
          </table>
        </div>
      </div>

      <!-- Right Panel -->
      <div class="right-panel">
        <a href="/groupproject/statistic.php">
          <div class="graph-section">Statistics</div>
        </a>
      </div>
    </div>
  </div>
</body>
</html>
