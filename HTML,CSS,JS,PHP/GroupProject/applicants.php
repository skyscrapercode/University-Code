<?php 
include 'dbconnection.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Process form submission
    $statuses = isset($_POST['status']) ? $_POST['status'] : [];
    $interviews = isset($_POST['interview']) ? $_POST['interview'] : [];

    foreach ($statuses as $app_id => $status) {
        // Update the status in the database
        $sql = "UPDATE application SET status = ? WHERE app_id = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("si", $status, $app_id);
        $stmt->execute();
    }

    foreach ($interviews as $app_id => $interview_date) {
        // Update the interview date in the database
        if (!empty($interview_date)) {
            $sql = "UPDATE application SET INTERVIEW_DATE = ? WHERE app_id = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("si", $interview_date, $app_id);
            $stmt->execute();
        }
    }
}
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>New Applicants</title>
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
          <a href="/groupproject/manager.php">&#8592; Back</a>
        </div>
    </header>
    
    <div class="content">
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
                    $sql =  "SELECT a.app_id, a.app_name, a.app_gender, a.app_phone, a.app_email, a.app_addr, a.app_dob, ap.status, ap.interview_date 
                    FROM applicant a 
                    JOIN application ap ON a.app_id = ap.app_id";
                    $result = $conn->query($sql);
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
                            echo "</select>";
                            echo "</td>";
                            echo "<td><input type='date' name='interview[" . htmlspecialchars($row['app_id']) . "]' value='" . htmlspecialchars($row['interview_date']) . "'></td>";
                            echo "</tr>";
                        }
                    } else {
                        echo "<tr><td colspan='8'>No records found</td></tr>";
                    }
                    ?>
                </tbody>
            </table>
            <button type="submit">Submit Changes</button>
        </form>
    </div>
</body>
</html>
