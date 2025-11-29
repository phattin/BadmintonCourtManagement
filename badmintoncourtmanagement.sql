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

-- INSERT INTO `billbooking` (`BillBookingId`, `EmployeeId`, `CustomerId`, `BookingId`, `TotalPrice`, `PrePayment`) VALUES
-- ('BB00001', 'EM00001', 'CU00001', 'BK00001', 120000, 60000),
-- ('BB00002', 'EM00001', 'CU00002', 'BK00002', 160000, 80000),
-- ('BB00003', 'EM00001', 'CU00003', 'BK00003', 180000, 90000),
-- ('BB00004', 'EM00001', 'CU00004', 'BK00004', 120000, 60000),
-- ('BB00005', 'EM00001', 'CU00005', 'BK00005', 160000, 80000);


-- --------------------------------------------------------

--
-- Table structure for table `billimportproductdetail`
--

CREATE TABLE `billimportproductdetail` (
  `ImportBillDetailId` varchar(10) NOT NULL,
  `ImportBillId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `Status` enum('active','inactive') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- INSERT INTO `billimportproductdetail` (`ImportBillDetailId`, `ImportBillId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`, `Status`) VALUES
-- ('IBD001', 'IB00001', 'PD00001', 10, 300000, 3000000, 'active'),
-- ('IBD002', 'IB00001', 'PD00006', 20, 50000, 1000000, 'active'),

-- ('IBD003', 'IB00002', 'PD00002', 8, 350000, 2800000, 'active'),
-- ('IBD004', 'IB00002', 'PD00007', 15, 40000, 600000, 'active'),

-- ('IBD005', 'IB00003', 'PD00003', 5, 450000, 2250000, 'active'),
-- ('IBD006', 'IB00003', 'PD00008', 12, 60000, 720000, 'active');


-- --------------------------------------------------------

--
-- Table structure for table `billproduct`
--

CREATE TABLE `billproduct` (
  `BillProductId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL,
  `DateCreated` datetime NOT NULL,
  `Status` enum('paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- INSERT INTO `billproduct` (`BillProductId`, `EmployeeId`, `TotalPrice`, `DateCreated`, `Status`) VALUES
-- ('BP00001', 'EM00001', 600000, '2025-10-17 09:00:00', 'paid'),
-- ('BP00002', 'EM00001', 450000, '2025-10-17 11:00:00', 'paid'),
-- ('BP00003', 'EM00001', 350000, '2025-10-17 13:30:00', 'unpaid'),
-- ('BP00004', 'EM00001', 900000, '2025-10-18 09:45:00', 'paid'),
-- ('BP00005', 'EM00001', 250000, '2025-10-18 15:10:00', 'paid');


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

-- INSERT INTO `billproductdetail` (`BillProductId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`) VALUES
-- ('BP00001', 'PD00001', 1, 300000, 300000),
-- ('BP00001', 'PD00006', 6, 50000, 300000),

-- ('BP00002', 'PD00002', 1, 350000, 350000),
-- ('BP00002', 'PD00007', 2, 50000, 100000),

-- ('BP00003', 'PD00003', 1, 350000, 350000),

-- ('BP00004', 'PD00001', 2, 300000, 600000),
-- ('BP00004', 'PD00006', 6, 50000, 300000),

-- ('BP00005', 'PD00008', 5, 50000, 250000);


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

-- INSERT INTO `booking` (`BookingId`, `CourtId`, `Status`, `StartTime`, `EndTime`) VALUES
-- ('BK00001', 'CO00001', 'successful', '2025-10-17 08:00:00', '2025-10-17 10:00:00'),
-- ('BK00002', 'CO00002', 'successful', '2025-10-17 10:00:00', '2025-10-17 12:00:00'),
-- ('BK00003', 'CO00003', 'played',     '2025-10-17 12:00:00', '2025-10-17 14:00:00'),
-- ('BK00004', 'CO00004', 'successful', '2025-10-18 08:00:00', '2025-10-18 10:00:00'),
-- ('BK00005', 'CO00005', 'played',     '2025-10-18 14:00:00', '2025-10-18 16:00:00');


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
('BR00004', 'Kumpoo'),
('BR00005', 'Mizuno'),
('BR00006', 'Adidas');

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

-- INSERT INTO `customer` (`CustomerId`, `CustomerName`, `Phone`, `IsDeleted`) VALUES
-- ('CU00001', 'Nguyễn Văn A', '0901000001', 0),
-- ('CU00002', 'Trần Thị B', '0901000002', 0),
-- ('CU00003', 'Lê Văn C', '0901000003', 0),
-- ('CU00004', 'Phạm Thị D', '0901000004', 0),
-- ('CU00005', 'Hoàng Văn E', '0901000005', 0);


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

INSERT INTO `employee` (`EmployeeId`, `EmployeeName`, `Phone`, `Address`, `Username`, `RoleId`) VALUES
('EM00001', 'Admin', '0900000001', 'HCM', 'admin', 'R00001');


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
  `DateCreated`datetime NOT NULL,
  `TotalPrice` double NOT NULL,
  `Status` enum('pending','delivered', 'cancelled', 'paid', 'unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- INSERT INTO `importbill` (`ImportBillId`, `EmployeeId`, `SupplierId`, `DateCreated`, `TotalPrice`, `Status`) VALUES
-- ('IB00001', 'EM00001', 'SPU00001', '2025-10-17 09:00:00', 5000000, 'delivered'),
-- ('IB00002', 'EM00001', 'SPU00002', '2025-10-17 10:00:00', 3500000, 'delivered'),
-- ('IB00003', 'EM00001', 'SPU00003', '2025-10-17 11:00:00', 4200000, 'delivered');


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

-- INSERT INTO `payment` (`PaymentId`, `BillProductId`, `PaymentMethod`, `TimePayment`, `AmountPaid`, `RemainingAmount`) VALUES
-- ('PAY001', 'BP00001', 'Cash', '2025-10-17 09:10:00', 600000, 0),
-- ('PAY002', 'BP00002', 'Banking', '2025-10-17 11:20:00', 450000, 0),
-- ('PAY003', 'BP00004', 'Cash', '2025-10-18 09:50:00', 900000, 0),
-- ('PAY004', 'BP00005', 'Banking', '2025-10-18 15:30:00', 250000, 0);


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

-- INSERT INTO `pricerule` (`PriceRuleId`, `Price`, `StartTime`, `EndTime`, `StartDate`, `EndDate`, `EndType`, `Description`, `Status`) VALUES
-- ('PR0001', 60000, '05:00:00', '16:00:00', NULL, NULL, 'Weekday', 'Ngày thường', 'Đang áp dụng'),
-- ('PR0002', 80000, '16:00:00', '23:00:00', NULL, NULL, 'Weekday', 'Ngày thường', 'Đang áp dụng');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ProductId` varchar(10) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `SupplierId` varchar(10) NOT NULL,
  `ProductImg` varchar(255) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `BrandId` varchar(10) NOT NULL,
  `TypeId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ProductId`, `ProductName`, `SupplierId`, `ProductImg`, `Quantity`, `BrandId`, `TypeId`, `IsDeleted`) VALUES
('PD00001', 'Yonex Astrox 99', 'SPU00001', 'yonex-astrox-99_2.png', 0, 'BR00001', 'TP00001', 0),
('PD00002', 'Yonex Nanoflare 700', 'SPU00001', 'yonex-nanoflare-700.png', 0, 'BR00001', 'TP00001', 0),
('PD00003', 'Kumpoo Power Control E88L', 'SPU00002', 'kumpoo-power-control-e88l.png', 0, 'BR00004', 'TP00001', 0),
('PD00004', 'Yonex Nanoflare 1000', 'SPU00001', 'yonex-nanoflare-1000z.png', 0, 'BR00001', 'TP00001', 0),
('PD00005', 'Yonex Astrox 100 Tour VA', 'SPU00001', 'yonex-astrox-100-tour-va.png', 0, 'BR00001', 'TP00001', 0),
('PD00006', 'Yonex Aerosensa Feather (12pcs)', 'SPU00001', 'yonex-aerosensa-20.png', 0, 'BR00001', 'TP00002', 0),
('PD00007', 'Yonex Voltric Z Force II LCW Limited', 'SPU00001', 'yonex-voltric-z-force-ii-lcw-limited.jpg', 0, 'BR00001', 'TP00001', 0),
('PD00008', 'Yonex Doura 10', 'SPU00001', 'yonex-doura-10.png', 0, 'BR00001', 'TP00001', 0),
('PD00009', 'Yonex ArcSaber 11', 'SPU00001', 'yonex-arcsaber-11.jpg', 0, 'BR00001', 'TP00001', 0),
('PD00010', 'Lining Woods N90 III', 'SPU00003', 'lining-woods-n90-iii.png', 0, 'BR00003', 'TP00001', 0),
('PD00011', 'Lining Aeronaut 6000', 'SPU00003', 'lining-aeronaut-6000.jpg', 0, 'BR00003', 'TP00001', 0),
('PD00012', 'Mizuno Fortius 10 Power', 'SPU00003', 'mizuno-fortius-10-power.jpg', 0, 'BR00005', 'TP00001', 0),
('PD00013', 'Adidas Spieler Grip', 'SPU00002', 'adidas-spieler-grip.jpg', 0, 'BR00006', 'TP00003', 0);

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `RoleId` varchar(10) NOT NULL,
  `RoleName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `role` (`RoleId`, `RoleName`) VALUES
('R00001', 'Quản lý'),
('R00002', 'Nhân viên');


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

-- INSERT INTO `storage` (`StorageId`, `ImportBillId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`, `Status`) VALUES
-- ('KH001', 'IB00001', 'PD00001', 10, 300000, 3000000, 'active'),
-- ('KH002', 'IB00001', 'PD00006', 20, 50000, 1000000, 'active'),
-- ('KH003', 'IB00001', 'PD00002', 8, 350000, 2800000, 'active'),
-- ('KH004', 'IB00001', 'PD00007', 15, 40000, 600000, 'active'),
-- ('KH005', 'IB00001', 'PD00003', 5, 450000, 2250000, 'active'),
-- ('KH006', 'IB00001', 'PD00008', 12, 60000, 720000, 'active'),
-- ('KH007', 'IB00001', 'PD00004', 9, 320000, 2880000, 'active'),
-- ('KH008', 'IB00001', 'PD00005', 7, 400000, 2800000, 'active'),
-- ('KH009', 'IB00001', 'PD00001', 15, 300000, 4500000, 'active'),
-- ('KH010', 'IB00001', 'PD00006', 25, 50000, 1250000, 'active'),
-- ('KH011', 'IB00001', 'PD00002', 10, 350000, 3500000, 'active'),
-- ('KH012', 'IB00001', 'PD00007', 18, 40000, 720000, 'active'),
-- ('KH013', 'IB00001', 'PD00003', 6, 450000, 2700000, 'active'),
-- ('KH014', 'IB00001', 'PD00008', 14, 60000, 840000, 'active'),
-- ('KH015', 'IB00001', 'PD00004', 8, 320000, 2560000, 'active'),
-- ('KH016', 'IB00001', 'PD00005', 10, 400000, 4000000, 'active'),
-- ('KH017', 'IB00001', 'PD00001', 12, 300000, 3600000, 'active'),
-- ('KH018', 'IB00001', 'PD00006', 22, 50000, 1100000, 'active'),
-- ('KH019', 'IB00001', 'PD00002', 7, 350000, 2450000, 'active'),
-- ('KH020', 'IB00001', 'PD00007', 16, 40000, 640000, 'active');



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

INSERT INTO `supplier` (`SupplierId`, `SupplierName`, `Email`, `Address`, `IsDeleted`) VALUES
('SPU00001', 'Yonex Supplier', 'yonex@supplier.com', 'Tokyo', 0),
('SPU00002', 'Victor Supplier', 'victor@supplier.com', 'Taipei', 0),
('SPU00003', 'Li-Ning Supplier', 'lining@supplier.com', 'Beijing', 0),
('SPU00004', ' Kumpoo Supplier', 'kumpoo@supplier.com', 'Japan', 0),
('SPU00005', 'Mizuno Supplier', 'mizuno@supplier.com', 'Japan', 0),
('SPU00006', 'Adidas Supplier', 'adidas@supplier.com', 'USA', 0);

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
  ADD KEY `EmployeeId` (`EmployeeId`);

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
  ADD KEY `TypeId` (`TypeId`),
  ADD KEY `SupplierId` (`SupplierId`);

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
  ADD CONSTRAINT `billproduct_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`);

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
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`BrandId`) REFERENCES `brand` (`BrandId`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `typeproduct` (`TypeId`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`SupplierId`) REFERENCES `supplier` (`SupplierId`);

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
