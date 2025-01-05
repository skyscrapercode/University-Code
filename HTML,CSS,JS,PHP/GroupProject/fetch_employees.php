<?php
include 'dbconnection.php';

if (isset($_POST['job_id'])) {
    $job_id = $_POST['job_id'];
    $sql = "SELECT EMP_ID, EMP_NAME FROM employee 
            INNER JOIN job ON employee.EMP_ROLE = job.JOB_NAME
            WHERE job.JOB_ID = '$job_id'";
    $result = $conn->query($sql);

    echo "<option value=''>Select Employee</option>";
    if ($result->num_rows > 0) {
        while ($row = $result->fetch_assoc()) {
            echo "<option value='{$row['EMP_ID']}'>{$row['EMP_NAME']}</option>";
        }
    } else {
        echo "<option value=''>No matching employees</option>";
    }
}
?>
