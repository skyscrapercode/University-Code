<?php
// Include the database connection file
include 'dbconnection.php';

// Fetch job data from the database
$jobs = [];
$query = "SELECT * FROM JOB";
$result = mysqli_query($conn, $query);
if ($result && mysqli_num_rows($result) > 0) {
    while ($row = mysqli_fetch_assoc($result)) {
        $jobs[] = $row;
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Homepage</title>
  <link rel="icon" type="image/x-icon" href="image/favicon.ico">
  <link rel="stylesheet" href="style.css">
  <style>

    body {
      margin: 0;
      color: white;
      display: flex;
      flex-direction: column;
      min-height: 100vh; 
    }

    .container {
      flex: 1;
      width: 90%;
      margin: 20px auto;
      padding: 20px;
      background-color: white;
      color: black;
      border-radius: 10px;
      box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
      background-color: rgba(255, 255, 255, 0.9);
    }


    /* Main Content Layout */
    .content {
      display: flex;
      gap: 10px;
    }

    .slideshow,
    .hiring-notice {
      padding: 20px;
      background-color: #f4a460;
      border-radius: 10px;
      color: white;
      font-size: 18px;
      font-weight: bold;
    }

    .slideshow {
      flex: 2;
      height: 500px;
      background-color: #ffa07a;
      position: relative;
      overflow: hidden;
    }

    .slideshow img {
      width: 95%;
      height: 500px;
      border-radius: 5px;
      position: absolute;
      opacity: 0;
      transition: opacity 1s ease-in-out;
    }

    .slideshow img.active {
      opacity: 1;
    }

    .hiring-notice {
      flex: 1;
      height: 500px;
      background-color: #b22222;
    }
  </style>
  <script>
    document.addEventListener('DOMContentLoaded', function() {
      const images = document.querySelectorAll('.slideshow img');
      let currentIndex = 0;

      setInterval(() => {
        images[currentIndex].classList.remove('active');
        currentIndex = (currentIndex + 1) % images.length;
        images[currentIndex].classList.add('active');
      }, 3000);
    });
  </script>
</head>
<body>
  <header>
    <div class="company-info">
      <img src="image/7eleven.png" alt="7-Eleven Logo">
      7-Eleven
    </div>
    <div class="nav-buttons">
      <a href="index.php">Home</a>
	    <a href="/aboutus.html">About Us</a>
	    <a href="/">Status</a>
	    <a href="/apply.html">Apply Job</a>
      <a href="/login.php">Login</a>
    </div>
  </header>

  <div class="container">
    <!-- Content -->
    <div class="content">
      <!-- Slideshow -->
      <div class="slideshow">
        <img src="image/slideshow1.png" alt="Slideshow Image 1" class="active">
        <img src="image/slideshow2.png" alt="Slideshow Image 2">
        <img src="image/slideshow3.png" alt="Slideshow Image 3">
      </div>

      <!-- Hiring Notice -->
      <div class="hiring-notice">
        <p>Hiring Notice</p>
        <ul style="list-style: none; padding: 0;">
          <?php if (!empty($jobs)) : ?>
            <?php foreach ($jobs as $job) : ?>
              <li>Position: <?php echo htmlspecialchars($job['name']); ?></li>
              <li>Salary: <?php echo htmlspecialchars($job['salary']); ?></li>
              <hr>
            <?php endforeach; ?>
          <?php else : ?>
            <li>No job openings available at the moment.</li>
          <?php endif; ?>
        </ul>
      </div>
    </div>
  </div>

  <footer> © 2024 7-Eleven. All rights reserved.</footer>
</body>
</html>
