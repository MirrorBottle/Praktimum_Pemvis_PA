-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 01:06 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `s4_ck_po`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_name` varchar(20) NOT NULL,
  `contact_number` varchar(255) NOT NULL,
  `address` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`id`, `name`, `contact_name`, `contact_number`, `address`) VALUES
(1, 'Mobiljaya Group', 'Budi Santoso', '081234567890', 'Jalan Gatot Subroto No. 123, Jakarta Selatan'),
(2, 'Otomotifku Sejahtera', 'Rina Amelia', '082345678901', 'Jalan Diponegoro No. 456, Surabaya Barat'),
(3, 'Automotifindo Bersama', 'Ahmad Ibrahim', '083456789012', 'Jalan Asia Afrika No. 789, Bandung Utara'),
(4, 'Mobilberkah Pratama', 'Rahmat Surya', '084567890123', 'Jalan Sudirman No. 10, Medan Timur'),
(5, 'Otomobil Lancar Jaya', 'Siti Rahayu', '085678901234', 'Jalan Pemuda No. 111, Semarang Selatan'),
(6, 'Mobilberjaya Sejahtera', 'Linda Wijaya', '086789012345', 'Jalan Gatot Subroto No. 222, Denpasar Timur'),
(7, 'Otomotif Sukses Makmur', 'Rudi Pratama', '087890123456', 'Jalan Ahmad Yani No. 333, Palembang Baru'),
(8, 'Motorjaya Abadi Sentosa', 'Faisal Nugraha', '088901234567', 'Jalan Veteran No. 444, Makassar Utara'),
(9, 'Automotif Lestari', 'Dewi Setiawati', '089012345678', 'Jalan Seturan No. 555, Yogyakarta Selatan'),
(10, 'Motorberkah Jaya', 'Johnatan Gunawan', '090123456789', 'Jalan Diponegoro No. 666, Bandar Lampung Timur'),
(11, 'Mobilberkah Makmur', 'Sinta Devi', '091234567890', 'Jalan Pahlawan No. 777, Manado Barat'),
(12, 'Otomotifberkat Jaya', 'Siti Rahayu', '092345678901', 'Jalan Sudirman No. 888, Balikpapan Tengah');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `code` varchar(100) NOT NULL,
  `name` varchar(200) NOT NULL,
  `price` bigint(20) NOT NULL,
  `category` varchar(200) NOT NULL,
  `color` varchar(100) NOT NULL,
  `brand` varchar(200) NOT NULL,
  `uom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `supplier_id`, `code`, `name`, `price`, `category`, `color`, `brand`, `uom`) VALUES
(21, 6, 'P001', 'Lampu Depan', 250000, 'Lighting', 'Clear', 'Bosch', 'Piece'),
(22, 4, 'P002', 'Rem Cakram', 350000, 'Braking System', 'Silver', 'Brembo', 'Piece'),
(23, 2, 'P003', 'Busi', 50000, 'Ignition System', 'Silver', 'NGK', 'Piece'),
(24, 12, 'P004', 'Filter Udara', 75000, 'Filters', 'Black', 'Mann', 'Piece'),
(25, 3, 'P005', 'Oli Mesin', 100000, 'Lubricants', 'Golden', 'Shell', 'Liter'),
(26, 3, 'P006', 'Bearing Roda', 120000, 'Suspension', 'Silver', 'FAG', 'Piece'),
(27, 7, 'P007', 'Kampas Rem', 200000, 'Braking System', 'Black', 'Akebono', 'Set'),
(28, 1, 'P008', 'Radiator', 500000, 'Cooling System', 'Silver', 'Behr', 'Piece'),
(29, 6, 'P009', 'Kopling', 800000, 'Transmission System', 'Black', 'Sachs', 'Set'),
(30, 4, 'P010', 'Saringan Oli', 30000, 'Filters', 'Yellow', 'Hengst', 'Piece'),
(31, 12, 'P011', 'Shock Absorber', 400000, 'Suspension', 'Black', 'KYB', 'Piece'),
(32, 2, 'P012', 'Timing Belt', 150000, 'Engine Components', 'Black', 'Contitech', 'Piece'),
(33, 8, 'P013', 'Alternator', 800000, 'Electrical System', 'Silver', 'Bosch', 'Piece'),
(34, 11, 'P014', 'Power Steering Pump', 600000, 'Steering System', 'Silver', 'ZF', 'Piece'),
(35, 5, 'P015', 'Kabel Busi', 20000, 'Ignition System', 'Black', 'NGK', 'Piece'),
(36, 6, 'P016', 'Gardan', 900000, 'Drivetrain', 'Silver', 'GKN', 'Piece'),
(37, 12, 'P017', 'Sensor Oksigen', 400000, 'Engine Components', 'Silver', 'Bosch', 'Piece'),
(38, 4, 'P018', 'Koil', 100000, 'Ignition System', 'Black', 'Denso', 'Piece'),
(39, 10, 'P019', 'Thermostat', 80000, 'Cooling System', 'Silver', 'Gates', 'Piece'),
(40, 3, 'P020', 'Kampas Kopling', 600000, 'Transmission System', 'Black', 'Luk', 'Set');

-- --------------------------------------------------------

--
-- Table structure for table `purchase_orders`
--

CREATE TABLE `purchase_orders` (
  `id` int(11) NOT NULL,
  `code` varchar(255) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `logistic_id` int(11) DEFAULT NULL,
  `status` tinyint(4) NOT NULL DEFAULT 0 COMMENT '0 = Pending, 1 = Admin Approved, 2 = Logistik Approved, 3 = Done',
  `note` text DEFAULT NULL,
  `total_amount` bigint(20) NOT NULL,
  `payed_amount` bigint(20) DEFAULT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp(),
  `approval_at` date DEFAULT NULL,
  `logistic_at` date DEFAULT NULL,
  `finish_at` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchase_orders`
--

INSERT INTO `purchase_orders` (`id`, `code`, `customer_id`, `logistic_id`, `status`, `note`, `total_amount`, `payed_amount`, `created_at`, `approval_at`, `logistic_at`, `finish_at`) VALUES
(2, 'PO-001', 1, 3, 1, '', 700000, NULL, '2023-05-22', '2023-05-22', NULL, NULL),
(3, 'PO-002', 1, 2, 2, '', 150000, 150000, '2023-05-22', '2023-05-22', '2023-05-23', NULL),
(5, 'PO-003', 1, 2, 3, '', 700000, 700000, '2023-05-22', '2023-05-23', '2023-05-23', '2023-05-23'),
(6, 'PO-004', 1, 3, 3, 'Test', 1135000, 775000, '2023-05-23', '2023-05-23', '2023-05-23', '2023-05-23'),
(7, 'PO-005', 1, 2, 3, '', 1740000, 1700000, '2023-05-23', '2023-05-23', '2023-05-23', '2023-05-23');

-- --------------------------------------------------------

--
-- Table structure for table `purchase_order_items`
--

CREATE TABLE `purchase_order_items` (
  `id` int(11) NOT NULL,
  `purchase_order_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `amount_request` int(11) NOT NULL,
  `price_request` bigint(20) NOT NULL,
  `is_fulfilled` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchase_order_items`
--

INSERT INTO `purchase_order_items` (`id`, `purchase_order_id`, `item_id`, `amount_request`, `price_request`, `is_fulfilled`) VALUES
(1, 2, 22, 2, 700000, 0),
(2, 3, 23, 3, 150000, 1),
(3, 5, 22, 2, 700000, 1),
(4, 6, 22, 2, 700000, 1),
(5, 6, 24, 1, 75000, 1),
(6, 6, 26, 3, 360000, 2),
(7, 7, 35, 2, 40000, 2),
(8, 7, 36, 1, 900000, 1),
(9, 7, 31, 2, 800000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL,
  `code` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_name` varchar(100) NOT NULL,
  `contact_number` varchar(100) NOT NULL,
  `address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`id`, `code`, `name`, `contact_name`, `contact_number`, `address`) VALUES
(1, 'SUP001', 'PT. Autopartindo', 'John Doe', '+6282311111', 'Jalan Raya Asemka No. 123, Jakarta Selatan'),
(2, 'SUP002', 'PT. Autopartnesia', 'Jane Smith', '+6282311112', 'Jalan Gajah Mada No. 456, Surabaya Barat'),
(3, 'SUP003', 'PT. Suplayera Utama', 'Ahmad Ibrahim', '+6282311113', 'Jalan Asia Afrika No. 789, Bandung Utara'),
(4, 'SUP004', 'PT. Partmaju Bersama', 'Siti Rahayu', '+6282311115', 'Jalan Raden Saleh No. 10, Medan Timur'),
(5, 'SUP005', 'PT. Parteka Perkasa', 'Budi Santoso', '+6282311117', 'Jalan Ambarawa No. 111, Semarang Selatan'),
(6, 'SUP006', 'PT. Partduta Jaya', 'Linda Susanti', '+6282311119', 'Jalan Gatot Subroto No. 222, Denpasar Timur'),
(7, 'SUP007', 'PT. Partindo Mandiri', 'Rudi Pratama', '+6282311121', 'Jalan Diponegoro No. 333, Palembang Baru'),
(8, 'SUP008', 'PT. Partdama Sejati', 'Siti Rahayu', '+6282311123', 'Jalan Veteran No. 444, Makassar Utara'),
(9, 'SUP009', 'PT. Partmas Jaya', 'Fahri Hasan', '+6282311155', 'Jalan Seturan No. 555, Yogyakarta Selatan'),
(10, 'SUP010', 'PT. Partlampung Bersama', 'Rina Sari', '+6282312111', 'Jalan Kartini No. 666, Bandar Lampung Timur'),
(11, 'SUP011', 'PT. Partsulut Mandiri', 'Hadi Susilo', '+6282311411', 'Jalan Pahlawan No. 777, Manado Barat'),
(12, 'SUP012', 'PT. Partbalikpapan Jaya', 'Dewi Setiawati', '+6282311161', 'Jalan Sudirman No. 888, Balikpapan Tengah');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(200) NOT NULL,
  `name` varchar(100) NOT NULL,
  `role` enum('1','2','3','') NOT NULL COMMENT '1 = Admin, 2 = Logistik, 3 = Customer',
  `customer_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`, `role`, `customer_id`) VALUES
(1, 'admin', '123123', 'Admin', '1', NULL),
(2, 'logistik1', '123123', 'Logistik 1', '2', NULL),
(3, 'logistik2', '123123', 'Logistik 2', '2', NULL),
(17, 'Budi', '123123', 'Budi', '3', 1),
(18, 'Rina', '123123', 'Rina', '3', 2),
(19, 'Ahmad', '123123', 'Ahmad', '3', 3),
(20, 'Rahmat', '123123', 'Rahmat', '3', 4),
(21, 'SitiRahayu', '123123', 'Siti Rahayu', '3', 5),
(22, 'Linda', '123123', 'Linda', '3', 6),
(23, 'Rudi', '123123', 'Rudi', '3', 7),
(24, 'Faisal', '123123', 'Faisal', '3', 8),
(25, 'Dewi', '123123', 'Dewi', '3', 9),
(26, 'Johnatan', '123123', 'Johnatan', '3', 10),
(27, 'Sinta', '123123', 'Sinta', '3', 11),
(28, 'Siti', '123123', 'Siti', '3', 12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `items_supplier_id_foreign` (`supplier_id`);

--
-- Indexes for table `purchase_orders`
--
ALTER TABLE `purchase_orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `purchase_orders_customer_id_foreign` (`customer_id`),
  ADD KEY `purchase_orders_logistic_id_foreign` (`logistic_id`);

--
-- Indexes for table `purchase_order_items`
--
ALTER TABLE `purchase_order_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `purchase_order_items_item_id_foreign` (`item_id`),
  ADD KEY `purchase_order_items_purchase_order_id_foreign` (`purchase_order_id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `users_customer_id_foreign` (`customer_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `purchase_orders`
--
ALTER TABLE `purchase_orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `purchase_order_items`
--
ALTER TABLE `purchase_order_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_supplier_id_foreign` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchase_orders`
--
ALTER TABLE `purchase_orders`
  ADD CONSTRAINT `purchase_orders_customer_id_foreign` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `purchase_orders_logistic_id_foreign` FOREIGN KEY (`logistic_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchase_order_items`
--
ALTER TABLE `purchase_order_items`
  ADD CONSTRAINT `purchase_order_items_item_id_foreign` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `purchase_order_items_purchase_order_id_foreign` FOREIGN KEY (`purchase_order_id`) REFERENCES `purchase_orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_customer_id_foreign` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
