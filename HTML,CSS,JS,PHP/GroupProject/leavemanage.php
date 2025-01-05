<?php
session_start();
// Include the database connection
include "dbconnection.php";

// Initialize month filter
$monthFilter = isset($_POST['month']) ? $_POST['month'] : date('Y-m');

// Fetch leave requests based on the month filter
$sql = "SELECT e.EMP_ID, e.EMP_NAME, l.STARTDATE, l.ENDDATE, l.TYPE, 
        DATEDIFF(l.ENDDATE, l.STARTDATE) AS leave_duration, l.LEAVE_STATUS
        FROM `leave` l 
        JOIN `employee` e ON l.EMP_ID = e.EMP_ID
        WHERE DATE_FORMAT(l.STARTDATE, '%Y-%m') = '$monthFilter'"; 

$result = mysqli_query($conn, $sql);

if (!isset($_SESSION['EMP_ID'])) {
    echo "Manager employee not logged in. Please log in to continue, the system will redirect you to login page in 5 seconds";
    header("refresh:5; url=/groupproject/login.php");
    exit();
} elseif ($_SESSION['EMP_ROLE'] != 'manager') {
    echo "You are not a manager, you are a part-timer, the system will redirect you to the correct portal in 5 seconds";
    header("refresh:5; url=/groupproject/parttime.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Manage Leave Requests</title>
    <link rel="icon" type="image/x-icon" href="image/favicon.ico">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    <link rel="stylesheet" href="style.css">
    <style>
        body {
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .container {
            padding: 20px;
            
        }

        .table-container {
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin-top: 20px;
            margin-left: 20px;
            margin-right: 20px;
        }

        .filter-container label, .filter-container select {
            font-size: 16px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 10px;
        }

        table th, table td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: center;
        }

        table th {
            background-color: #ff6600;
            color: white;
        }

        .button {
            padding: 8px 16px;
            border: none;
            border-radius: 4px;
            color: white;
            cursor: pointer;
            transition: transform 0.2s, box-shadow 0.2s;
        }

        .button:hover {
            transform: scale(1.1);
            box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.2);
        }

        .accept {
            background-color: #4CAF50;
        }

        .reject {
            background-color: #f44336;
        }

        tr:hover {
            background-color: #f1f1f1;
            transition: background-color 0.3s;
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

    

        <!-- Table Section -->
        <div class="table-container">
            <h2 style="color:green;">Manage Part-Timer Leave Requests</h2>

            <form method="POST">
                <label for="month">Filter by Month:</label>
                <select id="month" name="month" onchange="this.form.submit()">
                    <?php
                    $currentYear = date('Y');
                    $currentMonth = date('m');
                    for ($i = 0; $i < 12; $i++) {
                        $monthValue = date('Y-m', strtotime("-$i month"));
                        $monthLabel = date('F Y', strtotime("-$i month"));
                        $selected = $monthValue === $monthFilter ? 'selected' : '';
                        echo "<option value='$monthValue' $selected>$monthLabel</option>";
                    }
                    ?>
                </select>
            </form>

            <table>
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Employee Name</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Type</th>
                        <th>Leave Duration</th>
                        <th>Status</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <?php if ($result->num_rows > 0): ?>
                        <?php $counter = 1; ?>
                        <?php while ($row = $result->fetch_assoc()): ?>
                            <tr>
                                <td><?php echo $counter++; ?></td>
                                <td><?php echo htmlspecialchars($row['EMP_NAME']); ?></td>
                                <td><?php echo $row['STARTDATE']; ?></td>
                                <td><?php echo $row['ENDDATE']; ?></td>
                                <td><?php echo $row['TYPE']; ?></td>
                                <td><?php echo $row['leave_duration'] . " Day"; ?></td>
                                <td><?php echo $row['LEAVE_STATUS']; ?></td>
                                <td>
                                    <button class="button accept">Accept</button>
                                    <button class="button reject">Reject</button>
                                </td>
                            </tr>
                        <?php endwhile; ?>
                    <?php else: ?>
                        <tr>
                            <td colspan="8">No leave requests found for this month</td>
                        </tr>
                    <?php endif; ?>
                </tbody>
            </table>
        </div>
    </div>

    <script>
        document.querySelectorAll('.accept').forEach(button => {
            button.addEventListener('click', function() {
                const row = button.closest('tr');
                const id = row.querySelector('td:first-child').textContent.trim();
                updateLeaveStatus(id, 'Accepted');
            });
        });

        document.querySelectorAll('.reject').forEach(button => {
            button.addEventListener('click', function() {
                const row = button.closest('tr');
                const id = row.querySelector('td:first-child').textContent.trim();
                updateLeaveStatus(id, 'Rejected');
            });
        });

        function updateLeaveStatus(id, status) {
            fetch('update_leave_status.php', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ id: id, status: status })
            })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert(`Leave request ${status}`);
                    location.reload(); 
                } else {
                    alert(`Error updating leave status: ${data.error}`);
                }
            })
            .catch(error => console.error('Error:', error));
        }
    </script>
</body>
</html>

<?php
mysqli_close($conn);
?>
