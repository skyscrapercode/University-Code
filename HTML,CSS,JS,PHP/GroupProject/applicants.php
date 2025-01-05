<?php 
include 'dbconnection.php';

$status_message = ""; // Initialize status message
$selected_month = isset($_GET['month']) ? $_GET['month'] : date('Y-m'); // Default to current month

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Process form submission
    $statuses = isset($_POST['status']) ? $_POST['status'] : [];
    $interviews = isset($_POST['interview']) ? $_POST['interview'] : [];
    $success_updates = 0;
    $error_updates = 0;

    foreach ($statuses as $app_id => $status) {
        if ($status === 'delete') {
            // If "Delete" is selected, delete the applicant from both tables
            $sql = "DELETE FROM application WHERE app_id = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("i", $app_id);

            if ($stmt->execute()) {
                $sql = "DELETE FROM applicant WHERE app_id = ?";
                $stmt = $conn->prepare($sql);
                $stmt->bind_param("i", $app_id);

                if ($stmt->execute()) {
                    $success_updates++;
                } else {
                    $error_updates++;
                }
            } else {
                $error_updates++;
            }
        } else {
            // Update status for applicants
            $sql = "UPDATE application SET status = ? WHERE app_id = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("si", $status, $app_id);

            if ($stmt->execute()) {
                $success_updates++;
            } else {
                $error_updates++;
            }
        }
    }

    foreach ($interviews as $app_id => $interview_date) {
        // Update the interview date in the database
        if (!empty($interview_date)) {
            $sql = "UPDATE application SET INTERVIEW_DATE = ? WHERE app_id = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("si", $interview_date, $app_id);

            if ($stmt->execute()) {
                $success_updates++;
            } else {
                $error_updates++;
            }
        }
    }

    // Set status message
    if ($success_updates > 0) {
        $status_message .= "<p style='color: green;'>Data updated successfully.</p>";
    }
    if ($error_updates > 0) {
        $status_message .= "<p style='color: red;'>Data could not be updated.</p>";
    }
}
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>New Applicants</title>
<link rel="icon" type="image/x-icon" href="image/favicon.ico">
<link rel="stylesheet" href="style.css">
<style>
    body {
        background-color: #f8f9fa;
        color: #333;
        margin: 0;
        padding: 0;
    }

    .content {
        margin: 50px auto;
        width: 80%;
        padding: 20px;
        background-color: white;
        border-radius: 10px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    }
    .status-message {
        text-align: center;
        margin-bottom: 20px;
        font-size: 16px;
        padding: 10px;
        background-color: #e9f7ef;
        border: 1px solid #a2d4ae;
        border-radius: 5px;
        color: #2c662d;
    }
    .status-message.error {
        background-color: #fbeae9;
        border: 1px solid #f5c2c7;
        color: #842029;
    }
    table {
        width: 100%;
        margin: 0 auto;
        border-collapse: collapse;
        background-color: white;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        border-radius: 10px;
        overflow: hidden;
    }
    th, td {
        padding: 10px;
        text-align: center;
        border: 1px solid #ff8d8d;
    }
    th {
        background-color: #008161;
        color: white;
        font-weight: bold;
    }
    tr:nth-child(even) {
        background-color: #f8f8f8;
    }
    tr:nth-child(odd) {
        background-color: #fff;
    }
    select {
        padding: 5px;
        border: 2px solid #f01b2d;
        border-radius: 5px;
        background-color: #fff;
        color: #333;
    }
    input[type="date"] {
        padding: 5px;
        border: 2px solid #f4821f;
        border-radius: 5px;
        background-color: #fff;
        color: #333;
    }
    input[type="date"]:hover, select:hover {
        border-color: #f01b2d;
    }
    button {
        margin-top: 20px;
        padding: 10px 20px;
        background-color: #008161;
        color: white;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }
    button:hover {
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
            <a href="/groupproject/attendancelist.php">Check Attendance</a>
            <a href="/groupproject/assignshift.php">Assign Jobs/Shift</a>
            <a href="/groupproject/leavemanage.php">Manage Leave</a>
            <a href="/groupproject/applicants.php">New Applicant</a>
            <a href="/groupproject/profile.php">Profile</a>
            <a href="/groupproject/manager.php">&#8592; Back</a>
        </div>
    </header>
    
    <div class="content">
        <!-- Status Message -->
        <?php if (!empty($status_message)): ?>
            <div class="status-message">
                <?php echo $status_message; ?>
            </div>
        <?php endif; ?>

        <!-- Dropdown to filter by month -->
        <form method="get" action="">
            <label for="month">Select Month:</label>
            <input type="month" id="month" name="month" value="<?php echo htmlspecialchars($selected_month); ?>">
            <button type="submit">Filter</button>
        </form>

        <form method="post" action="">
            <table>
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Name</th>
                        <th>Gender</th>
                        <th>Phone</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Date of Birth</th>
                        <th>Status Application</th>
                        <th>Interview Session</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    $start_date = $selected_month . "-01";
                    $end_date = date("Y-m-t", strtotime($start_date)); // Get the last day of the month

                    $sql = "SELECT a.app_id, a.app_name, a.app_gender, a.app_phone, a.app_email, a.app_addr, a.app_dob, ap.status, ap.interview_date 
                            FROM applicant a 
                            JOIN application ap ON a.app_id = ap.app_id
                            WHERE ap.apply_date BETWEEN ? AND ?";
                    $stmt = $conn->prepare($sql);
                    $stmt->bind_param("ss", $start_date, $end_date);
                    $stmt->execute();
                    $result = $stmt->get_result();
                    $counter = 1;

                    if ($result->num_rows > 0) {
                        while ($row = $result->fetch_assoc()) {
                            echo "<tr>";
                            echo "<td>" . $counter++ . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_name']) . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_gender']) . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_phone']) . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_email']) . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_addr']) . "</td>";
                            echo "<td>" . htmlspecialchars($row['app_dob']) . "</td>";
                            echo "<td>";
                            echo "<select name='status[" . htmlspecialchars($row['app_id']) . "]'>";
                            echo "<option value='Null'" . ($row['status'] == 'Null' ? ' selected' : '') . ">None</option>";
                            echo "<option value='accepted'" . ($row['status'] == 'accepted' ? ' selected' : '') . ">Accept</option>";
                            echo "<option value='rejected'" . ($row['status'] == 'rejected' ? ' selected' : '') . ">Reject</option>";
                            echo "<option value='delete'>Delete</option>";
                            echo "</select>";
                            echo "</td>";
                            echo "<td>";
                            if ($row['status'] === 'rejected') {
                                echo "<input type='date' name='interview[" . htmlspecialchars($row['app_id']) . "]' value='" . htmlspecialchars($row['interview_date']) . "' disabled>";
                            } else {
                                echo "<input type='date' name='interview[" . htmlspecialchars($row['app_id']) . "]' value='" . htmlspecialchars($row['interview_date']) . "'>";
                            }
                            echo "</td>";
                            echo "</tr>";
                        }
                    } else {
                        echo "<tr><td colspan='8'>No records found for this month</td></tr>";
                    }
                    ?>
                </tbody>
            </table>
            <button type="submit">Update Status</button>
        </form>
    </div>
</body>
</html>
