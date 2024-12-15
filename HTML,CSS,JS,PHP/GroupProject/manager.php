<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Manager Dashboard</title>
  <link rel="stylesheet" href="style.css">
  <style>
    html, body {
      height: 100%;
      margin: 0;
      padding: 0;
    }
    body {
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
      margin-top: 20px;
      flex: 1;
    }
    .left-panel {
      flex: 1;
      margin-right: 20px;
    }
    .right-panel {
      flex: 1;
    }
    .table-section {
      background-color: #ffffff;
      border-radius: 8px;
      padding: 20px;
      box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
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
    .button-section {
      margin-top: 20px;
      text-align: center;
    }
    .button-section a {
      display: block;
      background-color: #ff8d8d;
      color: #ffffff;
      text-align: center;
      text-decoration: none;
      border-radius: 8px;
      font-size: 22px;
      padding: 15px 0;
      transition: all 0.3s ease;
    }
    .button-section a:hover {
      background-color: #f01b2d;
      transform: scale(1.1);
    }
    .graph-section {
      height: 300px;
      background-color: #f4821f;
      border-radius: 8px;
      text-align: center;
      line-height: 300px;
      font-size: 24px;
      color: #ffffff;
      margin-bottom: 20px;
    }
    .bottom-buttons {
      display: flex;
      justify-content: space-between;
      gap: 10px;
    }
    .bottom-buttons a {
      flex: 1;
      background-color: #ff8d8d;
      color: #ffffff;
      padding: 15px;
      text-align: center;
      text-decoration: none;
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
      <a href="#">&#8592; Back</a>
    </div>
  </header>

  <div class="container">
    <div class="content">
      <!-- Left Panel -->
      <div class="left-panel">
        <div class="table-section">
          <h3>Part Timer List</h3>
          <table>
            <thead>
              <tr>
                <th>Name</th>
                <th>Position</th>
                <th>Contact</th>
                <th>Address</th>
              </tr>
            </thead>
            <tbody>
              <!-- PHP Code to Fetch Data -->
              <?php
              include 'db_connection.php';
              $sql = "SELECT name, position, contact, address FROM part_timers";
              $result = $conn->query($sql);

              if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                  echo "<tr>
                          <td>{$row['name']}</td>
                          <td>{$row['position']}</td>
                          <td>{$row['contact']}</td>
                          <td>{$row['address']}</td>
                        </tr>";
                }
              } else {
                echo "<tr><td colspan='4'>No Data Available</td></tr>";
              }
              $conn->close();
              ?>
            </tbody>
          </table>
        </div>
        <div class="button-section">
          <a href="applicant.html">New Applicant</a>
        </div>
      </div>

      <!-- Right Panel -->
      <div class="right-panel">
        <div class="graph-section">Graph Placeholder</div>
        <div class="bottom-buttons">
          <a href="#">Assign Jobs/Shift</a>
          <a href="#">Manage Leave</a>
        </div>
      </div>
    </div>
  </div>

  <footer>© 2024 7-Eleven. All rights reserved.</footer>
</body>
</html>
