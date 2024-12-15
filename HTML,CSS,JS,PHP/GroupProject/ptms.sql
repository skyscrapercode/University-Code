-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2024 at 01:32 PM
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
  `APP_PHONE` varchar(16) NOT NULL,
  `APP_EMAIL` varchar(100) NOT NULL,
  `APP_ADDR` varchar(100) NOT NULL,
  `APP_DOB` date NOT NULL,
  `APP_TYPE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `application`
--

CREATE TABLE `application` (
  `APP_ID` int(11) NOT NULL,
  `JOB_ID` int(11) NOT NULL,
  `STATUS` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EMP_ID` int(11) NOT NULL,
  `EMP_NAME` varchar(50) NOT NULL,
  `EMP_PHONE` varchar(16) NOT NULL,
  `EMP_EMAIL` varchar(100) NOT NULL,
  `EMP_ADDR` varchar(100) NOT NULL,
  `EMP_DOB` date NOT NULL,
  `EMP_ROLE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE `job` (
  `JOB_ID` int(11) NOT NULL,
  `JOB_NAME` varchar(100) NOT NULL,
  `JOB_SALARY` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE `leave` (
  `LEAVE_ID` int(11) NOT NULL,
  `EMP_ID` int(11) NOT NULL,
  `STARTDATE` date NOT NULL,
  `ENDDATE` date NOT NULL,
  `TYPE` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `shift`
--

CREATE TABLE `shift` (
  `JOB_ID` int(11) NOT NULL,
  `EMP_ID` int(11) NOT NULL,
  `STARTTIME` time NOT NULL,
  `ENDTIME` time NOT NULL,
  `PAYRATE` decimal(8,2) NOT NULL,
  `DATE` date NOT NULL,
  `ATTENDANCE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  ADD PRIMARY KEY (`APP_ID`,`JOB_ID`),
  ADD KEY `JOB_ID` (`JOB_ID`);

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
  ADD PRIMARY KEY (`JOB_ID`,`EMP_ID`),
  ADD KEY `EMP_ID` (`EMP_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `applicant`
--
ALTER TABLE `applicant`
  MODIFY `APP_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EMP_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `job`
--
ALTER TABLE `job`
  MODIFY `JOB_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `leave`
--
ALTER TABLE `leave`
  MODIFY `LEAVE_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `application`
--
ALTER TABLE `application`
  ADD CONSTRAINT `application_ibfk_1` FOREIGN KEY (`APP_ID`) REFERENCES `applicant` (`APP_ID`),
  ADD CONSTRAINT `application_ibfk_2` FOREIGN KEY (`JOB_ID`) REFERENCES `job` (`JOB_ID`);

--
-- Constraints for table `leave`
--
ALTER TABLE `leave`
  ADD CONSTRAINT `leave_ibfk_1` FOREIGN KEY (`EMP_ID`) REFERENCES `employee` (`EMP_ID`);

--
-- Constraints for table `shift`
--
ALTER TABLE `shift`
  ADD CONSTRAINT `shift_ibfk_1` FOREIGN KEY (`EMP_ID`) REFERENCES `employee` (`EMP_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
