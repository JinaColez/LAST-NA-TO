-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Jun 29, 2024 at 04:17 AM
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
-- Database: `login`
--

-- --------------------------------------------------------

--
-- Table structure for table `candidacy`
--

CREATE TABLE `candidacy` (
  `id` int(11) NOT NULL,
  `candidateID` int(30) NOT NULL,
  `name` varchar(255) NOT NULL,
  `pos` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `candidacy`
--

INSERT INTO `candidacy` (`id`, `candidateID`, `name`, `pos`) VALUES
(1, 1, 'ERIC', 'PRESIDENT'),
(2, 2, 'DANNY', 'PRESIDENT'),
(3, 3, 'MARKY', 'PRESIDENT');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(255) NOT NULL,
  `email` varchar(50) NOT NULL COMMENT 'userEmail',
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `email`, `username`, `password`) VALUES
(1, 'JimenezRenz@gmail.com', 'RenzJimenez', 'Pass123'),
(2, 'reymark@gmail.com', 'Reymark', 'lacolaco'),
(3, 'Imot@gmail.com', 'AkosiImot', 'helloworld'),
(4, 'test@gmail.com', 'testtest', 'helloworld'),
(5, 'cjguiyab@gmail.com', 'Christian', 'Jakerrr'),
(6, 'l4-mang@fmale.com', 'SystemPrint', 'HelloWorld'),
(8, 'Loryel@gmail.com', 'LorsLors', 'anona'),
(9, 'kagawad@gmail.com', 'JoshuaBards', 'LacoTuleg'),
(10, 'awdahdjha', 'dawdhaldhwakh', 'dwadjahdklhwakd'),
(11, 'Nyosua@gmail.com', 'LacoLAco', 'LacoBaliw'),
(13, 'akosiTokis@gmail.com', 'Paeng', 'Paeng'),
(14, 'Paeng@gmail.com', 'JameTV', 'prodigong'),
(15, 'ReymarkLato@gmail.com', 'LATOLATO', 'OTALOTAL'),
(16, 'emailtest@gmail.com', 'anon ', 'passwordpasswor'),
(17, 'anotherTest@gmail.com', 'TestAccount2', '12345678'),
(18, 'practice123@gmail.com', 'practice123', 'practice123'),
(19, 'jimenezrenz@gmail.com', 'renzPogi', '12345678'),
(20, 'hello@gmail.com', 'hello', 'helloulet'),
(21, 'hellopare@gmail.com', 'hipo', 'hihihi'),
(22, 'ReymarkLato@gmail.com', 'ReymarkReymark', 'Baimaku'),
(23, 'KuyaImot@gmail.com', 'KuyaMomot', 'imotimot');

-- --------------------------------------------------------

--
-- Table structure for table `totality`
--

CREATE TABLE `totality` (
  `id` int(11) NOT NULL,
  `candidateID` int(30) NOT NULL,
  `votes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `totality`
--

INSERT INTO `totality` (`id`, `candidateID`, `votes`) VALUES
(1, 1, 1),
(2, 1, 1),
(3, 1, 1),
(4, 1, 1),
(5, 2, 1),
(6, 1, 1),
(7, 2, 1),
(8, 1, 1),
(9, 1, 1),
(10, 3, 1),
(11, 3, 1),
(12, 4, 1),
(13, 2, 1),
(14, 1, 1),
(15, 1, 1),
(16, 3, 1),
(17, 1, 1),
(18, 2, 1),
(19, 0, 1),
(20, 0, 1),
(21, 0, 1),
(22, 1, 1),
(23, 2, 1),
(24, 2, 1),
(25, 1, 1),
(26, 0, 1),
(27, 2, 1),
(28, 0, 1),
(29, 0, 1),
(30, 1, 1),
(31, 1, 1),
(32, 2, 1),
(33, 3, 1),
(34, 0, 1),
(35, 11, 1),
(36, 2, 1),
(37, 3, 1),
(38, 1, 1),
(39, 1, 1),
(40, 1, 1),
(41, 0, 1),
(42, 0, 1),
(43, 2, 1),
(44, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `votes`
--

CREATE TABLE `votes` (
  `id` int(11) NOT NULL,
  `category` varchar(50) NOT NULL,
  `candidate` varchar(50) NOT NULL,
  `votecount` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `votes`
--

INSERT INTO `votes` (`id`, `category`, `candidate`, `votecount`) VALUES
(1, 'President', 'OFFICIAL 3', 1),
(2, 'Secretary', 'OFFICIAL 3', 1),
(3, 'Secretary', 'OFFICIAL 5', 1),
(4, 'President', 'OFFICIAL 1', 1),
(5, 'Secretary', 'OFFICIAL 3', 1),
(6, 'Secretary', 'OFFICIAL 5', 1),
(7, 'President', 'OFFICIAL 2', 1),
(8, 'Vice President', 'OFFICIAL 4', 1),
(9, 'Secretary', 'OFFICIAL 2', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `candidacy`
--
ALTER TABLE `candidacy`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `totality`
--
ALTER TABLE `totality`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `votes`
--
ALTER TABLE `votes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `candidacy`
--
ALTER TABLE `candidacy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `totality`
--
ALTER TABLE `totality`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `votes`
--
ALTER TABLE `votes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
