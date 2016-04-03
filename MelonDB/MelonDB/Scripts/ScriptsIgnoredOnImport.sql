
-- phpMyAdmin SQL Dump
-- version 3.5.8.2
-- http://www.phpmyadmin.net
--
-- Host: sql207.byetcluster.com
-- Generation Time: Mar 25, 2016 at 10:56 PM
-- Server version: 5.6.29-76.2
-- PHP Version: 5.3.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `feton_17740989_demoAppDB`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `products_id` varchar(6) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
  `products_name` varchar(20) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
  `products_balance` int(5) NOT NULL,
  `products_arrive_count` int(5) NOT NULL,
  `products_depart_count` int(5) NOT NULL,
  `products_arrive_date` date NOT NULL,
  `products_depart_date` date NOT NULL,
  `products_type` varchar(6) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
  `products_vender_name` varchar(20) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
  PRIMARY KEY (`products_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`products_id`, `products_name`, `products_balance`, `products_arrive_count`, `products_depart_count`, `products_arrive_date`, `products_depart_date`, `products_type`, `products_vender_name`) VALUES
('000001', 'FISH', 20, 0, 0, '2016-03-01', '2016-03-18', 'EXP', 'TAN WUTTISAKDANON'),
('000002', 'PORK', 40, 2, 6, '2016-03-02', '2016-03-17', 'EXP', 'XVP');
('000003', 'MEAL', 60, 6, 8, '2016-03-23', '2016-03-28', 'EXP', 'IZE');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
GO

--Syntax Error: Incorrect syntax near `.
---- phpMyAdmin SQL Dump
---- version 3.5.8.2
---- http://www.phpmyadmin.net
----
---- Host: sql207.byetcluster.com
---- Generation Time: Mar 25, 2016 at 10:56 PM
---- Server version: 5.6.29-76.2
---- PHP Version: 5.3.3
--
--SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
--SET time_zone = "+00:00";
--
--
--/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
--/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
--/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
--/*!40101 SET NAMES utf8 */;
--
----
---- Database: `feton_17740989_demoAppDB`
----
--
---- --------------------------------------------------------
--
----
---- Table structure for table `products`
----
--
--CREATE TABLE IF NOT EXISTS `products` (
--  `products_id` varchar(6) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
--  `products_name` varchar(20) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
--  `products_balance` int(5) NOT NULL,
--  `products_arrive_count` int(5) NOT NULL,
--  `products_depart_count` int(5) NOT NULL,
--  `products_arrive_date` date NOT NULL,
--  `products_depart_date` date NOT NULL,
--  `products_type` varchar(6) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
--  `products_vender_name` varchar(20) CHARACTER SET utf16 COLLATE utf16_unicode_ci NOT NULL,
--  PRIMARY KEY (`products_id`)
--) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
--
----
---- Dumping data for table `products`
----
--
--INSERT INTO `products` (`products_id`, `products_name`, `products_balance`, `products_arrive_count`, `products_depart_count`, `products_arrive_date`, `products_depart_date`, `products_type`, `products_vender_name`) VALUES
--('000001', 'FISH', 20, 0, 0, '2016-03-01', '2016-03-18', 'EXP', 'TAN WUTTISAKDANON'),
--('000002', 'PORK', 40, 2, 6, '2016-03-02', '2016-03-17', 'EXP', 'XVP');
--('000003', 'MEAL', 60, 6, 8, '2016-03-23', '2016-03-28', 'EXP', 'IZE');
--
--/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
--/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
--/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;



GO
