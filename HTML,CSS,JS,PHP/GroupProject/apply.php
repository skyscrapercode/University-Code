<?php
include 'dbconnection.php';

$message = ""; // Variable to hold error or success message

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = strtoupper(htmlspecialchars($_POST['name']));
    $dob = $_POST['dob'];
    $gender = $_POST['gender'];
    $phone = $_POST['phone'];
    $email = htmlspecialchars($_POST['email']);
    $address = htmlspecialchars($_POST['address']);
    $type = $_POST['type'];

    if (strlen($phone) < 8 || strlen($phone) > 12) {
        $message = "<p style='color: red;'>Error: Phone number must be between 8 and 12 digits.</p>";
    } else {
        if (!preg_match("/^[a-zA-Z\s]+$/", $name)) {
            $message = "<p style='color: red;'>Error: Name can only contain letters and spaces.</p>";
        } else {
            // Check if the applicant has already applied based on the `apply_date` field
            $checkquery = "SELECT application.APP_ID FROM application 
                           INNER JOIN applicant ON application.APP_ID = applicant.APP_ID 
                           WHERE applicant.APP_EMAIL = '$email' AND application.apply_date IS NOT NULL";

            $result = mysqli_query($conn, $checkquery);

            if ($result && $result->num_rows > 0) {
                $message = "<p style='color: orange;'>You have already applied today. Please check your status <a href='/groupproject/status.php'>here</a></p>";
            } else {
                // Insert the applicant's details
                $sql = "INSERT INTO applicant (APP_NAME, APP_GENDER, APP_PHONE, APP_EMAIL, APP_ADDR, APP_DOB, APP_TYPE)
                        VALUES ('$name', '$gender', '$phone', '$email', '$address', '$dob', '$type')";

                if (mysqli_query($conn, $sql)) {
                    $applicant_id = mysqli_insert_id($conn);

                    // Get the job ID based on the selected type
                    $sql3 = "SELECT JOB_ID FROM job WHERE JOB_NAME = '$type'";
                    $jobResult = mysqli_query($conn, $sql3);
                    $jobRow = mysqli_fetch_assoc($jobResult);
                    $jobID = $jobRow['JOB_ID']; 

                    // Insert into the application table with the current date
                    $currentDate = date('Y-m-d');
                    $sql4 = "INSERT INTO application (APP_ID, JOB_ID, apply_date, STATUS) 
                             VALUES ('$applicant_id', '$jobID', '$currentDate', 'NULL')";

                    if (mysqli_query($conn, $sql4)) {
                        $message = "<p style='color: green;'>Application submitted successfully!</p>";
                    } else {
                        $message = "<p style='color: red;'>Error: " . $conn->error . "</p>";
                    }
                } else {
                    $message = "<p style='color: red;'>Error: " . $conn->error . "</p>";
                }
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
    <title>Apply Job</title>
    <link rel="icon" type="image/x-icon" href="image/favicon.ico">
    <link rel="stylesheet" href="style.css">

    <style>
        body {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 0;
            background-color: #FFF8E7; /* Light cream background */
            color: #000000; /* Black text for contrast */
        }
        h1 { 
            text-align: center;
            color: #ffffff; 
            padding-bottom: 5px;
            background-color: #008161;
            padding: 5px 10px; /* Add padding around the text */
            border-radius: 5px; /* Round the edges */
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2); /* Add subtle shadow */
            text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.3); /* Add a shadow to the text */
        }
        form {
            background-color: #ffffff; /* White background for form */
            border: 1px solid #ccc; /* Light gray border */
            border-radius: 10px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
            padding: 35px;
            width: 800px;
        }
        fieldset {
            border: none;
            margin-bottom: 20px;
        }
        legend {
            font-size: 1.5em;
            margin-bottom: 10px;
            color: #ff8d8d; /* Light red for emphasis */
        }
        label {
            display: block;
            margin-top: 10px;
            color: #000000; /* Black for labels */
        }
        input[type="text"],
        input[type="date"],
        input[type="tel"],
        input[type="email"] {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            border: 1px solid #ccc; /* Light gray border */
            border-radius: 5px;
            background-color: #f9f9f9; /* Very light gray input background */
            color: #000000; /* Black text in inputs */
        }
        input[type="radio"] {
            margin-top: 5px;
            accent-color: #ff8d8d; /* Light red for radio buttons */
        }
        button {
            display: block;
            width: 100%;
            padding: 10px;
            margin-top: 10px;
            border: none;
            border-radius: 5px;
            background-color: #f4821f; /* Orange background */
            color: #ffffff; /* White text for contrast */
            cursor: pointer;
            font-size: 1em;
        }
        button:hover {
            background-color: #008161; /* Green on hover */
        }

        .message {
            text-align: center;
            margin-bottom: 20px;
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
          <a href="/groupproject/index.php">&#8592; Back</a>
        </div>
      </header>
      
    <h1>Application Form</h1>

    <form action="" method="POST">
        <div class="message">
            <?php echo $message; ?>
        </div>
        <fieldset>
            <legend>Personal Information</legend>

            <label for="name">Full Name:</label>
            <input type="text" id="name" name="name" placeholder="Full Name" required>

            <label for="dob">Date of Birth:</label>
            <input type="date" id="dob" name="dob" max="<?php echo date('Y-m-d', strtotime('-18 years')); ?>" required>


            <label for="gender">Gender:</label>
            <input type="radio" id="male" name="gender" value="M" required><span style="color: #008161;"> Male</span>
            <input type="radio" id="female" name="gender" value="F"><span style="color: #008161;"> Female</span>

            <label for="phone">Phone Number:</label>
            <input type="tel" id="phone" name="phone" pattern="\d{8,12}" required>

            <label for="email">Email Address:</label>
            <input type="email" id="email" name="email" required>

            <label for="address">Full Address:</label>
            <input type="text" id="fullAddress" name="address" required>

            <label for="type">Job Role:</label>
            <input type="radio" id="cashier" name="type" value="cashier" required><span style="color: #008161;"> Cashier </span><br>
            <input type="radio" id="stocker" name="type" value="stocker"><span style="color: #008161;"> Stocker </span><br>
            <input type="radio" id="cleaner" name="type" value="cleaner"><span style="color: #008161;"> Cleaner </span>

        </fieldset>

        <button type="submit">Submit</button>
    </form>
</body>
</html>
