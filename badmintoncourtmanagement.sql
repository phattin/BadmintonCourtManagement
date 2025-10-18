-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2025 at 02:01 PM
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
-- Database: `badmintoncourtmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `PermissionId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`Username`, `Password`, `PermissionId`, `IsDeleted`) VALUES
('admin', 'admin123', 'P00001', 0);

-- --------------------------------------------------------

--
-- Table structure for table `billbooking`
--

CREATE TABLE `billbooking` (
  `BillBookingId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `CustomerId` varchar(10) NOT NULL,
  `BookingId` varchar(10) NOT NULL,
  `TotalPrice` double DEFAULT 0,
  `PrePayment` double DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `billimportproductdetail`
--

CREATE TABLE `billimportproductdetail` (
  `ImportBillId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `Status` enum('paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `billproduct`
--

CREATE TABLE `billproduct` (
  `BillProductId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `CustomerId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL,
  `DateCreated` datetime NOT NULL,
  `Status` enum('paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `billproductdetail`
--

CREATE TABLE `billproductdetail` (
  `BillProductId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` int(11) DEFAULT NULL,
  `TotalPrice` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `BookingId` varchar(10) NOT NULL,
  `CourtId` varchar(10) NOT NULL,
  `Status` enum('successful','played') DEFAULT NULL,
  `StartTime` datetime NOT NULL,
  `EndTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `BrandId` varchar(10) NOT NULL,
  `BrandName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`BrandId`, `BrandName`) VALUES
('BR00001', 'Yonex'),
('BR00002', 'Victor'),
('BR00003', 'Li-Ning'),
('BR00004', 'Kumpoo');

-- --------------------------------------------------------

--
-- Table structure for table `court`
--

CREATE TABLE `court` (
  `CourtId` varchar(10) NOT NULL,
  `CourtName` varchar(50) NOT NULL,
  `Status` enum('active','maintenance') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `court`
--

INSERT INTO `court` (`CourtId`, `CourtName`, `Status`) VALUES
('CO00001', 'Sân 01', 'active'),
('CO00002', 'Sân 02', 'active'),
('CO00003', 'Sân 03', 'active'),
('CO00004', 'Sân 04', 'active'),
('CO00005', 'Sân 05', 'active'),
('CO00006', 'Sân 06', 'active'),
('CO00007', 'Sân 07', 'active'),
('CO00008', 'Sân 08', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerId` varchar(10) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EmployeeId` varchar(10) NOT NULL,
  `EmployeeName` varchar(30) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Username` varchar(30) NOT NULL,
  `RoleId` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `function`
--

CREATE TABLE `function` (
  `FunctionId` varchar(10) NOT NULL,
  `FunctionName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `function`
--

INSERT INTO `function` (`FunctionId`, `FunctionName`) VALUES
('F03', 'Bán hàng'),
('F05', 'Nhập hàng'),
('F04', 'Quản lý hóa đơn đặt sân'),
('F08', 'Quản lý khách hàng'),
('F07', 'Quản lý nhà cung cấp'),
('F09', 'Quản lý nhân viên'),
('F11', 'Quản lý phân quyền'),
('F02', 'Quản lý sân'),
('F06', 'Quản lý sản phẩm'),
('F10', 'Quản lý tài khoản'),
('F12', 'Thống kê'),
('F01', 'Đặt sân');

-- --------------------------------------------------------

--
-- Table structure for table `importbill`
--

CREATE TABLE `importbill` (
  `ImportBillId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `SupplierId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL,
  `Status` enum('pending','delivered') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentId` varchar(10) NOT NULL,
  `BillProductId` varchar(10) NOT NULL,
  `PaymentMethod` varchar(50) NOT NULL,
  `TimePayment` datetime NOT NULL,
  `AmountPaid` double NOT NULL,
  `RemainingAmount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `permission`
--

CREATE TABLE `permission` (
  `PermissionId` varchar(10) NOT NULL,
  `PermissionName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `permission`
--

INSERT INTO `permission` (`PermissionId`, `PermissionName`) VALUES
('P00002', 'Admin'),
('P00001', 'Quản lý');

-- --------------------------------------------------------

--
-- Table structure for table `permissiondetail`
--

CREATE TABLE `permissiondetail` (
  `PermissionId` varchar(10) NOT NULL,
  `FunctionId` varchar(10) NOT NULL,
  `Option` enum('View','Insert','Update','Delete') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_nopad_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `permissiondetail`
--

INSERT INTO `permissiondetail` (`PermissionId`, `FunctionId`, `Option`) VALUES
('P00002', 'F11', 'Delete'),
('P00002', 'F11', 'Update'),
('P00002', 'F11', 'Insert'),
('P00002', 'F11', 'View'),
('P00002', 'F10', 'Delete'),
('P00002', 'F10', 'Update'),
('P00002', 'F10', 'Insert'),
('P00002', 'F10', 'View'),
('P00002', 'F09', 'View'),
('P00001', 'F12', 'View'),
('P00001', 'F11', 'Delete'),
('P00001', 'F11', 'Update'),
('P00001', 'F11', 'Insert'),
('P00001', 'F11', 'View'),
('P00001', 'F10', 'Delete'),
('P00001', 'F10', 'Update'),
('P00001', 'F10', 'Insert'),
('P00001', 'F10', 'View'),
('P00001', 'F09', 'Delete'),
('P00001', 'F09', 'Update'),
('P00001', 'F09', 'Insert'),
('P00001', 'F09', 'View'),
('P00001', 'F08', 'Update'),
('P00001', 'F08', 'Insert'),
('P00001', 'F08', 'View'),
('P00001', 'F07', 'Delete'),
('P00001', 'F07', 'Update'),
('P00001', 'F07', 'Insert'),
('P00001', 'F07', 'View'),
('P00001', 'F06', 'Delete'),
('P00001', 'F06', 'Update'),
('P00001', 'F06', 'Insert'),
('P00001', 'F06', 'View'),
('P00001', 'F05', 'Insert'),
('P00001', 'F05', 'View'),
('P00001', 'F04', 'View'),
('P00001', 'F03', 'Insert'),
('P00001', 'F03', 'View'),
('P00001', 'F02', 'Delete'),
('P00001', 'F02', 'Update'),
('P00001', 'F02', 'Insert'),
('P00001', 'F01', 'Insert'),
('P00001', 'F01', 'View'),
('P00001', 'F02', 'View');

-- --------------------------------------------------------

--
-- Table structure for table `pricebookingdetail`
--

CREATE TABLE `pricebookingdetail` (
  `PriceRuleId` varchar(10) NOT NULL,
  `BillBookingId` varchar(10) NOT NULL,
  `PriceApplied` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pricerule`
--

CREATE TABLE `pricerule` (
  `PriceRuleId` varchar(10) NOT NULL,
  `Price` int(11) DEFAULT NULL,
  `StartTime` time DEFAULT NULL,
  `EndTime` time DEFAULT NULL,
  `StartDate` datetime DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  `EndType` enum('Holiday','Weekday','Weekend') NOT NULL DEFAULT 'Holiday',
  `Description` varchar(255) DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pricerule`
--

INSERT INTO `pricerule` (`PriceRuleId`, `Price`, `StartTime`, `EndTime`, `StartDate`, `EndDate`, `EndType`, `Description`, `Status`) VALUES
('PR0001', 60000, '05:00:00', '16:00:00', NULL, NULL, 'Weekday', 'Ngày thường', 'Đang áp dụng'),
('PR0002', 80000, '16:00:00', '23:00:00', NULL, NULL, 'Weekday', 'Ngày thường', 'Đang áp dụng');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ProductId` varchar(10) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `ProductImg` varchar(255) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `BrandId` varchar(10) NOT NULL,
  `TypeId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ProductId`, `ProductName`, `ProductImg`, `Quantity`, `BrandId`, `TypeId`, `IsDeleted`) VALUES
('PD00001', 'Yonex Astrox 99', 'yonex-astrox-99_2.png', 12, 'BR00001', 'TP00001', 0),
('PD00002', 'Yonex Nanoflare 700', 'yonex-nanoflare-700.png', 15, 'BR00001', 'TP00001', 0),
('PD00003', 'Kumpoo Power Control E88L', 'kumpoo-power-control-e88l.png', 10, 'BR00004', 'TP00001', 0),
('PD00004', 'Yonex Nanoflare 1000', 'yonex-nanoflare-1000z.png', 8, 'BR00001', 'TP00001', 0),
('PD00005', 'Yonex Astrox 100 Tour VA', 'yonex-astrox-100-tour-va.png', 9, 'BR00001', 'TP00001', 0),
('PD00006', 'Yonex Aerosensa Feather (12pcs)', 'yonex-aerosensa-20.png', 50, 'BR00001', 'TP00002', 0),
('PD00007', 'Victor Master Shuttle (12pcs)', '', 40, 'BR00002', 'TP00002', 0),
('PD00008', 'Li-Ning Professional Shuttle (12pcs)', '', 35, 'BR00003', 'TP00002', 0);

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `RoleId` varchar(10) NOT NULL,
  `RoleName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `storage`
--

CREATE TABLE `storage` (
  `StorageId` varchar(10) NOT NULL,
  `ImportBillId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `Status` enum('active','inactive') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SupplierId` varchar(10) NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `typeproduct`
--

CREATE TABLE `typeproduct` (
  `TypeId` varchar(10) NOT NULL,
  `TypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `typeproduct`
--

INSERT INTO `typeproduct` (`TypeId`, `TypeName`) VALUES
('TP00001', 'Racket'),
('TP00002', 'Shuttlecock'),
('TP00003', 'Grip');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`Username`),
  ADD KEY `PermissionId` (`PermissionId`);

--
-- Indexes for table `billbooking`
--
ALTER TABLE `billbooking`
  ADD PRIMARY KEY (`BillBookingId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `CustomerId` (`CustomerId`),
  ADD KEY `BookingId` (`BookingId`);

--
-- Indexes for table `billimportproductdetail`
--
ALTER TABLE `billimportproductdetail`
  ADD PRIMARY KEY (`ImportBillId`,`ProductId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Indexes for table `billproduct`
--
ALTER TABLE `billproduct`
  ADD PRIMARY KEY (`BillProductId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `CustomerId` (`CustomerId`);

--
-- Indexes for table `billproductdetail`
--
ALTER TABLE `billproductdetail`
  ADD PRIMARY KEY (`BillProductId`,`ProductId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`BookingId`),
  ADD KEY `CourtId` (`CourtId`);

--
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`BrandId`);

--
-- Indexes for table `court`
--
ALTER TABLE `court`
  ADD PRIMARY KEY (`CourtId`),
  ADD UNIQUE KEY `CourtName` (`CourtName`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerId`),
  ADD UNIQUE KEY `Phone` (`Phone`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeId`),
  ADD UNIQUE KEY `Phone` (`Phone`),
  ADD KEY `Username` (`Username`),
  ADD KEY `RoleId` (`RoleId`);

--
-- Indexes for table `function`
--
ALTER TABLE `function`
  ADD PRIMARY KEY (`FunctionId`),
  ADD UNIQUE KEY `FunctionName` (`FunctionName`);

--
-- Indexes for table `importbill`
--
ALTER TABLE `importbill`
  ADD PRIMARY KEY (`ImportBillId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `SupplierId` (`SupplierId`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentId`),
  ADD KEY `BillProductId` (`BillProductId`);

--
-- Indexes for table `permission`
--
ALTER TABLE `permission`
  ADD PRIMARY KEY (`PermissionId`),
  ADD UNIQUE KEY `PermissionName` (`PermissionName`);

--
-- Indexes for table `permissiondetail`
--
ALTER TABLE `permissiondetail`
  ADD KEY `FunctionId` (`FunctionId`);

--
-- Indexes for table `pricebookingdetail`
--
ALTER TABLE `pricebookingdetail`
  ADD PRIMARY KEY (`PriceRuleId`,`BillBookingId`),
  ADD KEY `BillBookingId` (`BillBookingId`);

--
-- Indexes for table `pricerule`
--
ALTER TABLE `pricerule`
  ADD PRIMARY KEY (`PriceRuleId`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductId`),
  ADD KEY `BrandId` (`BrandId`),
  ADD KEY `TypeId` (`TypeId`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`RoleId`),
  ADD UNIQUE KEY `RoleName` (`RoleName`);

--
-- Indexes for table `storage`
--
ALTER TABLE `storage`
  ADD PRIMARY KEY (`StorageId`),
  ADD KEY `ImportBillId` (`ImportBillId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierId`);

--
-- Indexes for table `typeproduct`
--
ALTER TABLE `typeproduct`
  ADD PRIMARY KEY (`TypeId`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`PermissionId`) REFERENCES `permission` (`PermissionId`);

--
-- Constraints for table `billbooking`
--
ALTER TABLE `billbooking`
  ADD CONSTRAINT `billbooking_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `billbooking_ibfk_2` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`),
  ADD CONSTRAINT `billbooking_ibfk_3` FOREIGN KEY (`BookingId`) REFERENCES `booking` (`BookingId`);

--
-- Constraints for table `billimportproductdetail`
--
ALTER TABLE `billimportproductdetail`
  ADD CONSTRAINT `billimportproductdetail_ibfk_1` FOREIGN KEY (`ImportBillId`) REFERENCES `importbill` (`ImportBillId`),
  ADD CONSTRAINT `billimportproductdetail_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);

--
-- Constraints for table `billproduct`
--
ALTER TABLE `billproduct`
  ADD CONSTRAINT `billproduct_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `billproduct_ibfk_2` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`);

--
-- Constraints for table `billproductdetail`
--
ALTER TABLE `billproductdetail`
  ADD CONSTRAINT `billproductdetail_ibfk_1` FOREIGN KEY (`BillProductId`) REFERENCES `billproduct` (`BillProductId`),
  ADD CONSTRAINT `billproductdetail_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);

--
-- Constraints for table `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`CourtId`) REFERENCES `court` (`CourtId`);

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`Username`) REFERENCES `account` (`Username`),
  ADD CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`RoleId`) REFERENCES `role` (`RoleId`);

--
-- Constraints for table `importbill`
--
ALTER TABLE `importbill`
  ADD CONSTRAINT `importbill_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `importbill_ibfk_2` FOREIGN KEY (`SupplierId`) REFERENCES `supplier` (`SupplierId`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`BillProductId`) REFERENCES `billproduct` (`BillProductId`);

--
-- Constraints for table `pricebookingdetail`
--
ALTER TABLE `pricebookingdetail`
  ADD CONSTRAINT `pricebookingdetail_ibfk_1` FOREIGN KEY (`PriceRuleId`) REFERENCES `pricerule` (`PriceRuleId`),
  ADD CONSTRAINT `pricebookingdetail_ibfk_2` FOREIGN KEY (`BillBookingId`) REFERENCES `billbooking` (`BillBookingId`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`BrandId`) REFERENCES `brand` (`BrandId`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `typeproduct` (`TypeId`);

--
-- Constraints for table `storage`
--
ALTER TABLE `storage`
  ADD CONSTRAINT `storage_ibfk_1` FOREIGN KEY (`ImportBillId`) REFERENCES `importbill` (`ImportBillId`),
  ADD CONSTRAINT `storage_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
