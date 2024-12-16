<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Manager Dashboard</title>
  <link rel="stylesheet" href="style.css">
  <style>
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
      background-color: #021eed;
      border-radius: 8px;
      text-align: center;
      line-height: 300px;
      font-size: 24px;
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
      <a href="#">Assign Jobs/Shift</a>
      <a href="#">Manage Leave</a>
      <a href="applicant.html">New Applicant</a>
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
                <th>Employee's ID</th>
                <th>Employee's Name</th>
                <th>Employee's Number</th>
                <th>Employee's Email</th>
                <th>Employee's Address</th>
                <th>Employee's Date of Birth</th>
                <th>Employee's Role</th>
              </tr>
            </thead>
            <tbody>
              <!-- PHP Code to Fetch Data -->
              <?php
              include 'dbconnection.php';
              $sql = "SELECT EMP_ID, EMP_NAME, EMP_PHONE, EMP_EMAIL, EMP_ADDR, EMP_DOB, EMP_ROLE FROM employee WHERE EMP_ROLE <> 'manager'";
              $result = $conn->query($sql);

              if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                  echo "<tr>
                          <td>{$row['EMP_ID']}</td>
                          <td>{$row['EMP_NAME']}</td>
                          <td>{$row['EMP_PHONE']}</td>
                          <td>{$row['EMP_EMAIL']}</td>
                          <td>{$row['EMP_ADDR']}</td>
                          <td>{$row['EMP_DOB']}</td>
                          <td>{$row['EMP_ROLE']}</td>
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
      </div>

      <!-- Right Panel -->
      <div class="right-panel">
        <a href="stat.php">
          <div class="graph-section">Statistics</div>
        </a>
        <div class="bottom-buttons">
        </div>
      </div>
    </div>
  </div>
</body>
</html>
