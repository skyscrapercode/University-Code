-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 01, 2025 at 03:20 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ptms`
--

-- --------------------------------------------------------

--
-- Table structure for table `applicant`
--

CREATE TABLE `applicant` (
  `APP_ID` int(11) NOT NULL,
  `APP_NAME` varchar(50) NOT NULL,
  `APP_GENDER` varchar(1) NOT NULL,
  `APP_PHONE` varchar(16) NOT NULL,
  `APP_EMAIL` varchar(100) NOT NULL,
  `APP_ADDR` varchar(100) NOT NULL,
  `APP_DOB` date NOT NULL,
  `APP_TYPE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `applicant`
--

INSERT INTO `applicant` (`APP_ID`, `APP_NAME`, `APP_GENDER`, `APP_PHONE`, `APP_EMAIL`, `APP_ADDR`, `APP_DOB`, `APP_TYPE`) VALUES
(2, 'MUHAMAD AZIM HAFIZI BIN CHE MAT', 'M', '0192564313', 'azimhafizi@gmail.com', 'Kota Bharu, Kelantan', '2004-05-05', 'stocker'),
(5, 'GIGI', 'F', '12', 'mm@mm.com', 'qwerty', '2024-12-17', 'stocker'),
(9, 'HANNAH NABIELA BINTI ARSHAD', 'F', '01125708510', 'bella@gmail.com', 'Selangor', '2005-06-07', 'cashier'),
(18, 'UDIN MAHMUD', 'M', '58627586', 'udin@gmail.com', 'Lot 20, Taman Firdaus', '2006-12-06', 'stocker'),
(19, 'SYAMSUL', 'M', '1234567890', 'syamsul@gmail.com', '345vsdvbdfbd b bnss', '2006-12-01', 'cashier'),
(20, 'MUHAMMAD IMAN BIN ALIF', 'M', '0168177726', 'iman@gmail.com', 'no 39 jalan nova u5/74', '2004-03-10', 'cashier');

-- --------------------------------------------------------

--
-- Table structure for table `application`
--

CREATE TABLE `application` (
  `APPLY_ID` int(10) NOT NULL,
  `APP_ID` int(11) NOT NULL,
  `JOB_ID` int(11) NOT NULL,
  `STATUS` varchar(20) NOT NULL,
  `INTERVIEW_DATE` date DEFAULT NULL,
  `APPLY_DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `application`
--

INSERT INTO `application` (`APPLY_ID`, `APP_ID`, `JOB_ID`, `STATUS`, `INTERVIEW_DATE`, `APPLY_DATE`) VALUES
(1, 2, 3, 'NULL', '2024-12-17', '2024-12-15'),
(2, 5, 3, 'rejected', '2024-12-18', '2024-12-16'),
(3, 9, 3, 'rejected', '2024-12-21', '2024-12-18'),
(4, 18, 3, 'accepted', '2024-12-19', '2024-12-17'),
(5, 19, 2, 'accepted', '2024-12-24', '2024-12-20'),
(6, 20, 2, 'Null', NULL, '2025-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EMP_ID` int(11) NOT NULL,
  `EMP_NAME` varchar(50) NOT NULL,
  `EMP_GENDER` varchar(1) NOT NULL,
  `EMP_PHONE` varchar(16) NOT NULL,
  `EMP_EMAIL` varchar(100) NOT NULL,
  `EMP_PASS` varchar(255) DEFAULT NULL,
  `EMP_ADDR` varchar(100) NOT NULL,
  `EMP_DOB` date NOT NULL,
  `EMP_ROLE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EMP_ID`, `EMP_NAME`, `EMP_GENDER`, `EMP_PHONE`, `EMP_EMAIL`, `EMP_PASS`, `EMP_ADDR`, `EMP_DOB`, `EMP_ROLE`) VALUES
(1, 'SHEIKH ADAM BAJUNID BIN MOHD FAISAL', 'M', '0168177726', 'sheikhadam2004@gmail.com', '$2y$10$NWOC7TSU/63NoeBt9l.MwO5hVXoy97fZuxFB1SnKm1vI57Iuv9zI.', 'Shah Alam, Selangor', '2004-05-18', 'cleaner'),
(2, 'MUHAMAD AZIM HAFIZI BIN CHE MAT', 'M', '0192564313', 'azimhafizi@gmail.com', '$2y$10$/fEsBU1Peqs9jGyFR6N1HePMAL0SdIppchuCsQK8uu0rJZM4VJKoG', 'Kota Bharu, Kelantan', '2004-05-05', 'manager'),
(5, 'MUHAMMAD ADIB BIN KHAIRIL ANWAR', 'M', '01125569877', 'muhdadib@gmail.com', '$2y$10$.UoqfY.zAW8/g9gGrxQvq.xfS7ouh3C3sqSkKOtlYhJVJbEWjtWDq', 'Selangor', '2004-06-16', 'cleaner'),
(6, 'MOHAMAD IMAN MUZAKKIR BIN ISMAIL', 'M', '01161091829', 'imanmuzakkir@gmail.com', '$2y$10$KhpTryvSeF/8AFer..wQEuBvK8EitIlW.ln0AcQObTT5OqOLExU76', 'Lot 26 lorong sek keb 3 jalan kuala krai 15150 kota bharu kelantan', '2004-10-28', 'cashier'),
(7, 'FARISH HAQEEM BIN FAIZUL NIZAM', 'M', '0179595421', 'Farishhaqeem@gmail.com', '$2y$10$Y3yy2QnnLHynbNSUqjwtv.8HOZRuJ67Y2KUfKPMBejuioDyfRrnaC', 'Kelantan', '2003-08-19', 'cleaner'),
(8, 'HAKIM MUSTAPA BIN AMIN', 'M', '01155007821', 'hakimstopa@gmail.com', '$2y$10$NDmqzu4fLKpfbYWY6loqo.mnQlUKQJslTIcNUweE4g4Qw34Ss3FE.', 'Kelantan', '2002-11-26', 'stocker'),
(9, 'NOOR SHERINA BINTI NASSIR', 'F', '0199092356', 'noorsherina@gmail.com', '$2y$10$fucgRW29fQqnllJtv2s6W.cpmVLGV8zGlyznIQaITqhlyXAmzQc4.', 'Lot 02, Jalan Bestari 3, ', '2003-05-29', 'cleaner'),
(10, 'AQIL SHAFIQ BIN AHMAD RAZIQ', 'M', '0198930021', 'aqilshafiq@gmail.com', '$2y$10$tHLpdYCXzkevpbeWz.z.heV8FZ8aUAkYHZQjjBjz035B5JUPlFEbG', 'Lot 90, Pengkalan Chepa', '2003-09-17', 'cashier'),
(11, 'KAMARUL DANIEL BIN KAMARULZAMAN', 'M', '0128902345', 'kamarulzaman@gmail.com', '$2y$10$4OpMS0dk7AIylJtz3cDnquHidoYzXaJvvH2TGhrX0nn4wQIlXnnQi', 'Lot 20, Taman Firdaus ', '2006-12-11', 'cleaner'),
(12, 'AIMAN HASANUDDIN BIN KARIM', 'M', '0139277890', 'aimeyhasey@gmail.com', '$2y$10$4iactsJ/Dz9YT7VDvyAnSOpqPsagM50Bu4pPxtvlAFSFolBl/13du', 'Lot 111, Kubang Kerian', '2003-06-13', 'stocker'),
(13, 'ADRIANA ZALIKHA BINTI YUSOF', 'F', '0179671290', 'adrianaZalikha@gmail.com', '$2y$10$Me8FN3TaHg7i2W5nhGoFp.GcZYr5kSzjlf9e8SHtw0WssMNDrC1zK', 'Lot 120, Kubang Kerian', '2002-06-20', 'stocker'),
(14, 'MUHAMMAD RAZIQ BIN MUHAMMAD HAMIDI', 'M', '0109830769', 'raziqcomel@gmail.com', '$2y$10$NxXPhbKQ494yuyvFhEUgpO4kZg.A0gMQIjoKP6okl.iGG2IGbUylu', 'Lot 2, Central Park Valley', '2003-12-18', 'cashier'),
(15, 'UDIN MAHMUD', 'M', '58627586', 'udin@gmail.com', '$2y$10$opJj60sPSzJBzcfHw1xzbu2Szd9lL5w4ZlaU/.kwzZA7dxVfv0M8G', 'Lot 20, Taman Firdaus', '2006-12-06', 'stocker'),
(16, 'SYAMSUL', 'M', '1234567890', 'syamsul@gmail.com', '$2y$10$MlyikQJdXgwoeqTsIMcvLuSilLFv2dhCE6qcaOugHjgkkzYGqZ5RK', '345vsdvbdfbd b bnss', '2006-12-01', 'cashier');

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE `job` (
  `JOB_ID` int(11) NOT NULL,
  `JOB_NAME` varchar(100) NOT NULL,
  `JOB_SALARY` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`JOB_ID`, `JOB_NAME`, `JOB_SALARY`) VALUES
(1, 'cleaner', 1000.00),
(2, 'cashier', 900.00),
(3, 'stocker', 800.00);

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE `leave` (
  `LEAVE_ID` int(11) NOT NULL,
  `EMP_ID` int(11) NOT NULL,
  `STARTDATE` date NOT NULL,
  `ENDDATE` date NOT NULL,
  `TYPE` varchar(20) NOT NULL,
  `LEAVE_STATUS` enum('Pending','Accepted','Rejected') DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `leave`
--

INSERT INTO `leave` (`LEAVE_ID`, `EMP_ID`, `STARTDATE`, `ENDDATE`, `TYPE`, `LEAVE_STATUS`) VALUES
(1, 1, '2024-12-16', '2025-01-17', 'Vacation', 'Pending'),
(2, 1, '2024-12-18', '2024-12-25', 'Sick Leave', 'Accepted'),
(3, 5, '2024-12-20', '2025-01-02', 'Vacation', 'Pending'),
(4, 7, '2024-12-22', '2024-12-30', 'Maternity', 'Accepted'),
(5, 2, '2025-01-01', '2025-01-07', 'Personal Leave', 'Rejected'),
(6, 9, '2024-12-28', '2025-01-04', 'Sick Leave', 'Pending'),
(7, 12, '2025-01-05', '2025-01-12', 'Vacation', 'Accepted'),
(8, 15, '2025-01-08', '2025-01-15', 'Personal Leave', 'Pending'),
(9, 6, '2025-01-10', '2025-01-17', 'Sick Leave', 'Accepted'),
(10, 11, '2025-01-12', '2025-01-18', 'Vacation', 'Rejected'),
(11, 8, '2025-01-15', '2025-01-20', 'Personal Leave', 'Accepted');

-- --------------------------------------------------------

--
-- Table structure for table `shift`
--

CREATE TABLE `shift` (
  `SHIFT_ID` int(11) NOT NULL,
  `JOB_ID` int(11) NOT NULL,
  `EMP_ID` int(11) NOT NULL,
  `STARTTIME` time NOT NULL,
  `ENDTIME` time NOT NULL,
  `PAYRATE` decimal(8,2) NOT NULL,
  `DATE` date NOT NULL,
  `ATTENDANCE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shift`
--

INSERT INTO `shift` (`SHIFT_ID`, `JOB_ID`, `EMP_ID`, `STARTTIME`, `ENDTIME`, `PAYRATE`, `DATE`, `ATTENDANCE`) VALUES
(1, 1, 1, '11:00:00', '23:00:00', 15.00, '2024-12-26', 1),
(2, 1, 1, '11:00:00', '23:00:00', 15.00, '2024-12-25', 1),
(3, 1, 9, '11:30:00', '23:30:00', 15.00, '2024-12-25', 0),
(4, 2, 10, '11:00:00', '23:00:00', 15.00, '2024-12-25', 0),
(5, 1, 9, '10:00:00', '19:00:00', 15.00, '2024-12-26', 0),
(6, 2, 10, '15:00:00', '11:00:00', 15.00, '2024-12-26', 0),
(7, 1, 11, '11:00:00', '23:00:00', 15.00, '2024-12-24', 0),
(8, 1, 11, '10:00:00', '20:00:00', 15.00, '2024-12-27', 0),
(9, 1, 11, '11:00:00', '21:00:00', 15.00, '2024-12-28', 0),
(10, 3, 12, '21:00:00', '07:00:00', 15.00, '2024-12-25', 0),
(11, 3, 12, '23:00:00', '08:00:00', 15.00, '2024-12-27', 0),
(12, 3, 13, '08:00:00', '15:00:00', 15.00, '2024-12-27', 0),
(13, 3, 13, '10:00:00', '17:00:00', 15.00, '2024-12-28', 0),
(14, 2, 14, '19:00:00', '07:00:00', 15.00, '2024-12-18', 0),
(15, 2, 14, '07:00:00', '15:00:00', 15.00, '2024-12-29', 0),
(16, 1, 7, '11:00:00', '19:00:00', 15.00, '2024-12-25', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `applicant`
--
ALTER TABLE `applicant`
  ADD PRIMARY KEY (`APP_ID`);

--
-- Indexes for table `application`
--
ALTER TABLE `application`
  ADD PRIMARY KEY (`APPLY_ID`),
  ADD KEY `fk_application_applicant` (`APP_ID`),
  ADD KEY `fk_application_job` (`JOB_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EMP_ID`);

--
-- Indexes for table `job`
--
ALTER TABLE `job`
  ADD PRIMARY KEY (`JOB_ID`);

--
-- Indexes for table `leave`
--
ALTER TABLE `leave`
  ADD PRIMARY KEY (`LEAVE_ID`),
  ADD KEY `EMP_ID` (`EMP_ID`);

--
-- Indexes for table `shift`
--
ALTER TABLE `shift`
  ADD PRIMARY KEY (`SHIFT_ID`),
  ADD KEY `fk_shift_job` (`JOB_ID`),
  ADD KEY `fk_shift_employee` (`EMP_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `applicant`
--
ALTER TABLE `applicant`
  MODIFY `APP_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `application`
--
ALTER TABLE `application`
  MODIFY `APPLY_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EMP_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `job`
--
ALTER TABLE `job`
  MODIFY `JOB_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `leave`
--
ALTER TABLE `leave`
  MODIFY `LEAVE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `shift`
--
ALTER TABLE `shift`
  MODIFY `SHIFT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `application`
--
ALTER TABLE `application`
  ADD CONSTRAINT `fk_application_applicant` FOREIGN KEY (`APP_ID`) REFERENCES `applicant` (`APP_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_application_job` FOREIGN KEY (`JOB_ID`) REFERENCES `job` (`JOB_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `leave`
--
ALTER TABLE `leave`
  ADD CONSTRAINT `leave_ibfk_1` FOREIGN KEY (`EMP_ID`) REFERENCES `employee` (`EMP_ID`);

--
-- Constraints for table `shift`
--
ALTER TABLE `shift`
  ADD CONSTRAINT `fk_shift_employee` FOREIGN KEY (`EMP_ID`) REFERENCES `employee` (`EMP_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_shift_job` FOREIGN KEY (`JOB_ID`) REFERENCES `job` (`JOB_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
