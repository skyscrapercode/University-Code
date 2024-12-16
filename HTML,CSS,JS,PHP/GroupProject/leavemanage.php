<?php
// Include the database connection
include 'db_connection.php';

// Fetch leave requests
$sql = "SELECT * FROM leave_requests";
$result = $conn->query($sql);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Manage Leave Requests</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    <link rel="stylesheet" href="style.css">
    <style>
        body {
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .header {
            background-color: #026635;
            color: white;
            padding: 10px 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .header .back-button {
            color: white;
            text-decoration: none;
            font-size: 1.2em;
        }

        .header img {
            height: 40px;
        }

        .header .back-button {
            order: 2;
        }

        .header h1 {
            color: #ff6600;
            margin-left: 10px;
            order: 1;
            flex-grow: 1;
        }

        .container {
            padding: 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
            background-color: white;
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

        .footer {
            text-align: center;
            padding: 10px;
            background-color: #ff6600;
            color: white;
            position: absolute;
            bottom: 0;
            width: 100%;
        }

        tr:hover {
            background-color: #f1f1f1;
            transition: background-color 0.3s;
        }
    </style>
</head>
<body>
    <div class="header">
        <h1>7-Eleven</h1>
        <img src="image/7eleven.png" alt="7-Eleven Logo">
        <a href="javascript:history.back()" class="back-button">&larr; Back</a>
    </div>

    <div class="container">
        <h2>Manage Part-Timer Leave Requests</h2>

        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Position</th>
                    <th>Leave Date</th>
                    <th>Status</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <?php if ($result->num_rows > 0): ?>
                    <?php while ($row = $result->fetch_assoc()): ?>
                        <tr>
                            <td><?php echo $row['id']; ?></td>
                            <td><?php echo $row['name']; ?></td>
                            <td><?php echo $row['position']; ?></td>
                            <td><?php echo $row['leave_date']; ?></td>
                            <td><?php echo $row['status']; ?></td>
                            <td>
                                <button class="button accept">Accept</button>
                                <button class="button reject">Reject</button>
                            </td>
                        </tr>
                    <?php endwhile; ?>
                <?php else: ?>
                    <tr>
                        <td colspan="6">No leave requests found</td>
                    </tr>
                <?php endif; ?>
            </tbody>
        </table>
    </div>

    <div class="footer">
        &copy; 2024 7-Eleven. All rights reserved.
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
                    location.reload(); // Reload to reflect the changes
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
$conn->close();
?>
