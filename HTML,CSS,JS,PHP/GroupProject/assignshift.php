<?php
include 'dbconnection.php';

// Fetch jobs from the jobs table
$jobs = [];
$sql = "SELECT JOB_ID, JOB_NAME FROM job";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    while ($row = $result->fetch_assoc()) {
        $jobs[] = $row;
    }
}

// Handle form submission
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $employee_id = $_POST['employee_id'];
    $job_id = $_POST['job'];
    $start_time = $_POST['start_time'];
    $work_duration = $_POST['work_duration']; // Work duration in hours
    $date = $_POST['date'];

    // Get current date
    $current_date = date('Y-m-d');

    // Check if the selected date is before the current date
    if ($date < $current_date) {
        $message = "<strong style='color:red'>Cannot assign shift for a date before today.</strong>";
    } else {
        // Determine the pay rate based on JOB_ID
        if ($job_id == 1) {
            $pay_rate = 13;
        } elseif ($job_id == 2) {
            $pay_rate = 12;
        } elseif ($job_id == 3) {
            $pay_rate = 11;
        } else {
            $pay_rate = 0;
        }

        // Calculate the end time based on start time and work duration
        $end_time = date('H:i:s', strtotime("$start_time + $work_duration hours"));

        // Check if the shift already exists
        $check_sql = "SELECT * FROM shift WHERE EMP_ID = '$employee_id' AND JOB_ID = '$job_id' AND DATE = '$date'";
        $check_result = $conn->query($check_sql);

        if ($check_result->num_rows > 0) {
            $message = "<strong style='color:red'>This employee already has a task today</strong>";
        } else {
            // Insert the assignment into the shift table
            $attendance = 0; // Default attendance to false (0)
            $sql = "INSERT INTO shift (EMP_ID, JOB_ID, STARTTIME, ENDTIME, PAYRATE, DATE, ATTENDANCE) 
                    VALUES ('$employee_id', '$job_id', '$start_time', '$end_time', '$pay_rate', '$date', '$attendance')";

            if ($conn->query($sql) === TRUE) {
                $message = "Job and shift assigned successfully!";
            } else {
                $message = "Error assigning job and shift: " . $conn->error;
            }
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Assign Jobs/Shift</title>
  <link rel="icon" type="image/x-icon" href="image/favicon.ico">
  <link rel="stylesheet" href="style.css">
  <script>
    // AJAX to fetch employees based on job selection
    function fetchEmployees(jobId) {
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "fetch_employees.php", true);
        xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                document.getElementById("employee_id").innerHTML = xhr.responseText;
            }
        };
        xhr.send("job_id=" + jobId);
    }

    // Set the minimum date for the shift to today's date
    window.onload = function() {
        var today = new Date().toISOString().split('T')[0]; // Get current date in YYYY-MM-DD format
        document.getElementById("date").setAttribute("min", today);
    };
  </script>
  <style>
    body {
      margin: 0;
      padding: 0;
      width: 100%;
      height: 100%;
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
    .form-section {
      background-color: #ffffff;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
      width: 100%;
    }
    .form-group {
      margin-bottom: 15px;
    }
    .form-group label {
      display: block;
      font-weight: bold;
    }
    .form-group select, .form-group input {
      width: 100%;
      padding: 8px;
      border-radius: 4px;
      border: 1px solid #ccc;
    }
    .submit-btn {
      background-color: #008161;
      color: white;
      padding: 10px 20px;
      border: none;
      border-radius: 4px;
      cursor: pointer;
      font-size: 16px;
    }
    .submit-btn:hover {
      background-color: #005f4b;
    }
    .message {
      text-align: center;
      font-size: 18px;
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
      <a href="/groupproject/attendancelist.php">Check Attendance</a>
      <a href="/groupproject/assignshift.php">Assign Jobs/Shift</a>
      <a href="/groupproject/leavemanage.php">Manage Leave</a>
      <a href="/groupproject/applicants.php">New Applicant</a>
      <a href="/groupproject/profile.php">Profile</a>
      <a href="/groupproject/manager.php">&#8592; Back</a>
    </div>
  </header>

  <div class="container">
    <div class="form-section">
      <h3 align="center">Assign Job and Shift</h3>

      <!-- Show success/error message -->
      <?php if (isset($message)) { ?>
        <div class="message"><?php echo $message; ?></div>
      <?php } ?>

      <form action="" method="POST">
        <div class="form-group">
          <label for="job">Select Job</label>
          <select name="job" id="job" required onchange="fetchEmployees(this.value)">
            <option value="">Select Job</option>
            <?php foreach ($jobs as $job) { ?>
              <option value="<?php echo $job['JOB_ID']; ?>"><?php echo $job['JOB_NAME']; ?></option>
            <?php } ?>
          </select>
        </div>

        <div class="form-group">
          <label for="employee_id">Select Employee</label>
          <select name="employee_id" id="employee_id" required>
            <option value="">Select Employee</option>
          </select>
        </div>

        <div class="form-group">
          <label for="start_time">Start Time</label>
          <input type="time" name="start_time" id="start_time" required>
        </div>

        <div class="form-group">
          <label for="work_duration">Work Duration (hours)</label>
          <select name="work_duration" id="work_duration" required>
            <?php for ($i = 1; $i <= 12; $i++) { ?>
              <option value="<?php echo $i; ?>"><?php echo $i; ?> hour<?php echo $i > 1 ? 's' : ''; ?></option>
            <?php } ?>
          </select>
        </div>

        <div class="form-group">
          <label for="date">Shift Date</label>
          <input type="date" name="date" id="date" required>
        </div>

        <div class="form-group">
          <button type="submit" class="submit-btn">Assign Job & Shift</button>
        </div>
      </form>
    </div>
  </div>
</body>
</html>
