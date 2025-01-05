<?php
include 'dbconnection.php';

// Initialize gender counts
$male_count = 0;
$female_count = 0;

// SQL query to fetch the count of part-time employees by gender (excluding managers)
$sql_gender = "SELECT EMP_GENDER, COUNT(*) as total 
               FROM employee 
               WHERE EMP_ROLE <> 'manager' 
               GROUP BY EMP_GENDER";

$result_gender = $conn->query($sql_gender);

if ($result_gender->num_rows > 0) {
    while ($row = $result_gender->fetch_assoc()) {
        if ($row['EMP_GENDER'] == 'M') {
            $male_count = $row['total'];
        } elseif ($row['EMP_GENDER'] == 'F') {
            $female_count = $row['total'];
        }
    }
}

// Fetch the number of part-time employees by role (excluding managers)
$sql_role = "SELECT EMP_ROLE, COUNT(*) as total 
             FROM employee 
             WHERE EMP_ROLE <> 'manager' 
             GROUP BY EMP_ROLE";

$result_role = $conn->query($sql_role);
$roles_data = [];
if ($result_role->num_rows > 0) {
    while ($row = $result_role->fetch_assoc()) {
        $roles_data[] = [$row['EMP_ROLE'], (int)$row['total']];
    }
}

// Fetch working hours and calculate salaries
$sql_shift = "SELECT STARTTIME, ENDTIME, PAYRATE FROM shift";
$result_shift = $conn->query($sql_shift);

$salary_data = [];
if ($result_shift->num_rows > 0) {
    while ($row = $result_shift->fetch_assoc()) {
        $start = new DateTime($row['STARTTIME']);
        $end = new DateTime($row['ENDTIME']);
        $diff = $end->diff($start);
        $hours = $diff->h + ($diff->i / 60); // Total hours worked
        $salary = $hours * $row['PAYRATE']; // Calculate salary
        $salary_data[] = $salary; // Store salaries
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Part-Time Employees Statistics</title>
  <link rel="icon" type="image/x-icon" href="image/favicon.ico">
  <link rel="stylesheet" href="style.css">
  <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
  <script type="text/javascript">
    google.charts.load('current', {'packages':['corechart', 'bar', 'line']});
    google.charts.setOnLoadCallback(drawCharts);

    function drawCharts() {
        // Pie chart for gender distribution
        var data_gender = google.visualization.arrayToDataTable([
            ['Gender', 'Number of Employees'],
            ['Male', <?php echo $male_count; ?>],
            ['Female', <?php echo $female_count; ?>]
        ]);

        var options_gender = {
            title: 'Gender Distribution of Part-Time Employees in 2024',
            pieHole: 0.4,
            colors: ['#4CAF50', '#FF5733'],
            animation: { startup: true, duration: 2000, easing: 'out' }
        };

        var chart_gender = new google.visualization.PieChart(document.getElementById('piechart'));
        chart_gender.draw(data_gender, options_gender);

        // Bar chart for employee roles
        var data_role = google.visualization.arrayToDataTable([
            ['Role', 'Number of Employees'],
            <?php foreach ($roles_data as $role) {
                echo "['" . $role[0] . "', " . $role[1] . "],";
            } ?>
        ]);

        var options_role = {
            title: 'Number of Part-Time Employees by Role in 2024',
            bars: 'vertical',
            colors: ['#66b3ff'],
            animation: { startup: true, duration: 1500, easing: 'out' },
            hAxis: { title: 'Number of Employees' },
            vAxis: { title: 'Role' }
        };

        var chart_role = new google.visualization.BarChart(document.getElementById('barchart'));
        chart_role.draw(data_role, options_role);

        // Stacked bar chart for salary distribution
        var salary_ranges = {
            '0-50': 0,
            '51-100': 0,
            '101-150': 0,
            '151-200': 0,
            '201-250': 0,
            '251+': 0
        };

        <?php foreach ($salary_data as $salary) {
            if ($salary <= 50) {
                echo "salary_ranges['0-50']++;";
            } elseif ($salary <= 100) {
                echo "salary_ranges['51-100']++;";
            } elseif ($salary <= 150) {
                echo "salary_ranges['101-150']++;";
            } elseif ($salary <= 200) {
                echo "salary_ranges['151-200']++;";
            } elseif ($salary <= 250) {
                echo "salary_ranges['201-250']++;";
            } else {
                echo "salary_ranges['251+']++;";
            }
        } ?>

        var data_salary = google.visualization.arrayToDataTable([
            ['Salary Range', 'Number of Employees'],
            ['0-50', salary_ranges['0-50']],
            ['51-100', salary_ranges['51-100']],
            ['101-150', salary_ranges['101-150']],
            ['151-200', salary_ranges['151-200']],
            ['201-250', salary_ranges['201-250']],
            ['251+', salary_ranges['251+']]
        ]);

        var options_salary = {
            title: 'Salary Distribution of Part-Time Employees in 2024',
            isStacked: true,
            legend: { position: 'none' },
            bar: { groupWidth: '60%' }, // Adjust bar thickness
            colors: ['#76A7FA'],
            vAxis: {
                title: 'Number of Employees'
            },
            hAxis: {
                title: 'Salary Range (RM)'
            },
            animation: {
                startup: true,
                duration: 1500,
                easing: 'out'
            }
        };

        var chart_salary = new google.visualization.ColumnChart(document.getElementById('salarychart'));
        chart_salary.draw(data_salary, options_salary);
    }
  </script>
  <style>
    body {
      width: 100%;
      height: 100%;
      display: flex;
      flex-direction: column;
      background-color: #f8f8f8;
      margin: 0;
      padding: 0;
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
      text-align: center;
      margin-bottom: 30px;
      animation: fadeIn 1.5s ease-in-out;
    }
    header .company-info {
      display: flex;
      align-items: center;
      gap: 10px;
      font-size: 24px;
      font-weight: bold;
      margin: 20px;
    }
    header img {
      width: 50px;
      height: auto;
    }
    #piechart, #barchart, #salarychart {
      margin-top: 20px;
      width: 100%;
      height: 400px;
      animation: growChart 2s ease-out;
    }
    @keyframes fadeIn {
      from { opacity: 0; }
      to { opacity: 1; }
    }
    @keyframes growChart {
      0% { transform: scale(0); opacity: 0; }
      100% { transform: scale(1); opacity: 1; }
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
    <!-- Pie chart section -->
    <div class="form-section">
      <h1>Gender Distribution of Part-Time Employees in 2024</h1>
      <div id="piechart"></div>
    </div>

    <!-- Bar chart section -->
    <div class="form-section">
      <h1>Number of Part-Time Employees by Role in 2024</h1>
      <div id="barchart"></div>
    </div>

    <!-- Stacked Bar chart for salary distribution -->
    <div class="form-section">
      <h1>Salary Distribution of Part-Time Employees in 2024</h1>
      <div id="salarychart"></div>
    </div>
  </div>
</body>
</html>
