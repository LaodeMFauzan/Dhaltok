-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 23 Okt 2017 pada 11.31
-- Versi Server: 10.1.26-MariaDB
-- PHP Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dhaltokdb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_perjalanan`
--

CREATE TABLE `tbl_perjalanan` (
  `travel_code` int(11) NOT NULL,
  `from` text NOT NULL,
  `to` text NOT NULL,
  `time` varchar(10) NOT NULL,
  `price` text NOT NULL,
  `seat_available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_perjalanan`
--

INSERT INTO `tbl_perjalanan` (`travel_code`, `from`, `to`, `time`, `price`, `seat_available`) VALUES
(1, 'Malang', 'Bekasi', '08:00 AM', '500000', 35),
(2, 'Malang', 'Jakarta', '10:00 AM', '700000', 25),
(3, 'Malang', 'Bali', '05:00 PM', '450000', 40),
(4, 'Malang', 'Sidoarjo', '09:45 AM', '520000', 20),
(5, 'Malang', 'Bandung', '03:00 AM', '1250000', 46);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(32) NOT NULL,
  `Email` varchar(32) NOT NULL,
  `Telepon` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id`, `Username`, `Password`, `Email`, `Telepon`) VALUES
(1, 'hanafi', '12345', 'hanafi111@gmail.com', 8080808),
(2, 'aaa', '123', 'aa@yahoo.co.id', 22222),
(3, 'pehul', '12345', 'pehullalala@gmail.com', 888988),
(4, '1', '1', 'asas@sdsd', 199202);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_perjalanan`
--
ALTER TABLE `tbl_perjalanan`
  ADD PRIMARY KEY (`travel_code`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
