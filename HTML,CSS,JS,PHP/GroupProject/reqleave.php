<?php
session_start(); // Start the session

include 'dbconnection.php'; // Include the database connection file

// Check if employee details are stored in the session
if (!isset($_SESSION['EMP_ID'])) {
    die("Employee not logged in. Please log in to continue.");
}

$emp_id = $_SESSION['EMP_ID'];

// Handle leave request submission
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $start_date = $_POST['start_date'];
    $end_date = $_POST['end_date'];
    $type = $_POST['type'];
    $other_reason = $_POST['other_reason'] ?? null;

    if ($type === 'other' && empty($other_reason)) {
        die("Please specify the reason for leave.");
    }

    $reason = ($type === 'other') ? $other_reason : $type;

    $insert_query = "INSERT INTO leave (EMP_ID, STARTDATE, ENDDATE, TYPE) VALUES (?, ?, ?, ?)";
    $stmt = $conn->prepare($insert_query);
    $stmt->bind_param("isss", $emp_id, $start_date, $end_date, $reason);

    if ($stmt->execute()) {
        echo "Leave request submitted successfully.";
    } else {
        echo "Error: " . $conn->error;
    }
}
?>

<!DOCTYPE html>
<html>
<head>
  <title>Request Leave</title>
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

    form {
      display: flex;
      flex-direction: column;
    }

    label {
      margin: 10px 0 5px;
      font-weight: bold;
    }

    input, select, textarea, button {
      padding: 10px;
      margin-bottom: 15px;
      border: 1px solid #ccc;
      border-radius: 5px;
      font-size: 16px;
    }

    textarea {
      resize: vertical;
      height: 100px;
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

    .hidden {
      display: none;
    }
  </style>
  <script>
    function toggleOtherReason() {
      const typeField = document.getElementById('type');
      const otherReasonField = document.getElementById('other-reason-container');

      if (typeField.value === 'other') {
        otherReasonField.classList.remove('hidden');
      } else {
        otherReasonField.classList.add('hidden');
        document.getElementById('other-reason').value = ''; // Clear the input when hidden
      }
    }
  </script>
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

  <div style="padding: 80px;">
    <div class="container">
      <h1>Request Leave</h1>
      <form method="POST">
        <label for="start-date">Start Date</label>
        <input type="date" id="start-date" name="start_date" required>

        <label for="end-date">End Date</label>
        <input type="date" id="end-date" name="end_date" required>

        <label for="type">Leave Type</label>
        <select id="type" name="type" onchange="toggleOtherReason()" required>
          <option value="" disabled selected>Select a reason</option>
          <option value="sick">Sick Leave</option>
          <option value="vacation">Vacation</option>
          <option value="emergency">Emergency</option>
          <option value="other">Other</option>
        </select>

        <div id="other-reason-container" class="hidden">
          <label for="other-reason">Specify Reason</label>
          <textarea id="other-reason" name="other_reason" placeholder="Write your reason here..."></textarea>
        </div>

        <button type="submit">Submit Request</button>
      </form>
    </div>
  </div>
</body>
</html>
