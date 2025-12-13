-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 08, 2025 lúc 04:42 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `badmintoncourtmanagement`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `account`
--

CREATE TABLE `account` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `PermissionId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `account`
--

INSERT INTO `account` (`Username`, `Password`, `EmployeeId`, `PermissionId`, `IsDeleted`) VALUES
('admin', 'admin123', 'E00001', 'P00001', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billbooking`
--

CREATE TABLE `billbooking` (
  `BillBookingId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `CustomerId` varchar(10) NOT NULL,
  `BookingId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL DEFAULT 0,
  `PrePayment` double DEFAULT 0,
  `RemainingAmount` double NOT NULL DEFAULT 0,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `billbooking`
--

INSERT INTO `billbooking` (`BillBookingId`, `EmployeeId`, `CustomerId`, `BookingId`, `TotalPrice`, `PrePayment`, `RemainingAmount`, `DateCreated`) VALUES
('BB00001', 'E00001', 'CU00002', 'BK00000001', 60000, 0, 60000, '2025-12-08 06:42:53'),
('BB00002', 'E00001', 'CU00001', 'BK00000002', 60000, 0, 60000, '2025-12-08 07:29:39'),
('BB00003', 'E00001', 'CU00001', 'BK00000003', 60000, 20000, 40000, '2025-12-08 07:45:03'),
('BB00004', 'E00001', 'CU00001', 'BK00000004', 60000, 0, 60000, '2025-12-08 07:57:33'),
('BB00005', 'E00001', 'CU00001', 'BK00000005', 60000, 0, 60000, '2025-12-08 08:00:03'),
('BB00006', 'E00001', 'CU00001', 'BK00000007', 60000, 0, 60000, '2025-12-08 08:20:05'),
('BB00007', 'E00001', 'CU00003', 'BK00000008', 240000, 120000, 120000, '2025-12-08 09:51:26'),
('BB00008', 'E00001', 'CU00001', 'BK00000009', 120000, 0, 120000, '2025-12-08 09:56:21'),
('BB00009', 'E00001', 'CU00001', 'BK00000010', 140000, 0, 140000, '2025-12-08 10:00:58'),
('BB00010', 'E00001', 'CU00001', 'BK00000011', 140000, 0, 140000, '2025-12-08 10:05:33');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billimportproductdetail`
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

--
-- Đang đổ dữ liệu cho bảng `billimportproductdetail`
--

INSERT INTO `billimportproductdetail` (`ImportBillDetailId`, `ImportBillId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`, `CreatedAt`, `Status`) VALUES
('ID00001', 'IB00001', 'PD00001', 20, 460000, 9200000, '2025-12-01 14:49:10', ''),
('ID00002', 'IB00002', 'PD00001', 20, 400000, 8000000, '2025-12-01 16:41:21', ''),
('ID00003', 'IB00003', 'PD00005', 30, 580000, 17400000, '2025-12-01 16:56:23', ''),
('ID00004', 'IB00003', 'PD00006', 30, 290000, 8700000, '2025-12-01 16:56:23', ''),
('ID00005', 'IB00003', 'PD00004', 30, 590000, 17700000, '2025-12-01 16:56:23', ''),
('ID00006', 'IB00004', 'PD00002', 50, 740000, 37000000, '2025-12-02 10:03:16', ''),
('ID00007', 'IB00004', 'PD00007', 25, 980000, 24500000, '2025-12-02 10:03:16', ''),
('ID00008', 'IB00004', 'PD00009', 35, 720000, 25200000, '2025-12-02 10:03:16', ''),
('ID00009', 'IB00005', 'PD00003', 20, 450000, 9000000, '2025-12-02 10:04:02', ''),
('ID00010', 'IB00006', 'PD00010', 40, 680000, 27200000, '2025-12-02 10:04:41', ''),
('ID00011', 'IB00006', 'PD00011', 40, 660000, 26400000, '2025-12-02 10:04:41', ''),
('ID00012', 'IB00007', 'PD00008', 35, 840000, 29400000, '2025-12-02 10:05:41', ''),
('ID00013', 'IB00008', 'PD00012', 45, 560000, 25200000, '2025-12-02 10:06:11', ''),
('ID00014', 'IB00009', 'PD00013', 100, 150000, 15000000, '2025-12-02 10:06:40', ''),
('ID00015', 'IB00010', 'PD00001', 30, 650000, 19500000, '2025-12-05 16:54:05', '');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billproduct`
--

CREATE TABLE `billproduct` (
  `BillProductId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL,
  `DateCreated` datetime NOT NULL,
  `Status` enum('paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `billproduct`
--

INSERT INTO `billproduct` (`BillProductId`, `EmployeeId`, `TotalPrice`, `DateCreated`, `Status`) VALUES
('BP00001', 'E00001', 1104000, '2025-12-01 14:50:05', 'paid'),
('BP00002', 'E00001', 1104000, '2025-12-04 13:08:10', 'paid'),
('BP00003', 'E00001', 2060000, '2025-12-04 13:09:10', 'paid'),
('BP00004', 'E00001', 2016000, '2025-12-04 13:09:49', 'paid'),
('BP00005', 'E00001', 888000, '2025-12-04 13:10:01', 'paid'),
('BP00006', 'E00001', 2967000, '2025-12-04 13:10:29', 'paid'),
('BP00007', 'E00001', 1728000, '2025-12-04 13:10:57', 'paid'),
('BP00008', 'E00001', 667000, '2025-12-04 13:11:24', 'paid'),
('BP00009', 'E00001', 667000, '2025-12-04 13:11:37', 'paid'),
('BP00010', 'E00001', 1357000, '2025-12-04 13:13:38', 'paid'),
('BP00011', 'E00001', 888000, '2025-12-04 13:13:55', 'paid'),
('BP00012', 'E00001', 1529500, '2025-12-04 13:14:49', 'paid'),
('BP00013', 'E00001', 862500, '2025-12-04 13:15:36', 'paid'),
('BP00014', 'E00001', 2001000, '2025-12-04 13:15:59', 'paid'),
('BP00015', 'E00001', 5520000, '2025-12-04 13:16:12', 'paid'),
('BP00016', 'E00001', 1656000, '2025-12-04 13:20:25', 'paid'),
('BP00017', 'E00001', 1012000, '2025-12-04 13:46:19', 'paid'),
('BP00018', 'E00001', 10300000, '2025-12-05 17:08:44', 'paid'),
('BP00019', 'E00001', 1725000, '2025-12-08 04:25:20', 'paid');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billproductdetail`
--

CREATE TABLE `billproductdetail` (
  `BillProductDetailId` varchar(10) NOT NULL,
  `BillProductId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` int(11) DEFAULT NULL,
  `TotalPrice` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `billproductdetail`
--

INSERT INTO `billproductdetail` (`BillProductDetailId`, `BillProductId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`) VALUES
('BPD00001', 'BP00001', 'PD00001', 2, 552000, 1104000),
('BPD00002', 'BP00002', 'PD00001', 2, 552000, 1104000),
('BPD00003', 'BP00003', 'PD00006', 1, 333500, 333500),
('BPD00004', 'BP00003', 'PD00009', 1, 864000, 864000),
('BPD00005', 'BP00003', 'PD00013', 5, 172500, 862500),
('BPD00006', 'BP00004', 'PD00008', 2, 1008000, 2016000),
('BPD00007', 'BP00005', 'PD00002', 1, 888000, 888000),
('BPD00008', 'BP00006', 'PD00001', 2, 552000, 1104000),
('BPD00009', 'BP00006', 'PD00006', 3, 333500, 1000500),
('BPD00010', 'BP00006', 'PD00013', 5, 172500, 862500),
('BPD00011', 'BP00007', 'PD00009', 2, 864000, 1728000),
('BPD00012', 'BP00008', 'PD00005', 1, 667000, 667000),
('BPD00013', 'BP00009', 'PD00006', 2, 333500, 667000),
('BPD00014', 'BP00010', 'PD00004', 2, 678500, 1357000),
('BPD00015', 'BP00011', 'PD00002', 1, 888000, 888000),
('BPD00016', 'BP00012', 'PD00004', 1, 678500, 678500),
('BPD00017', 'BP00012', 'PD00006', 1, 333500, 333500),
('BPD00018', 'BP00012', 'PD00013', 3, 172500, 517500),
('BPD00019', 'BP00013', 'PD00004', 2, 678500, 1357000),
('BPD00020', 'BP00013', 'PD00010', 2, 782000, 1564000),
('BPD00021', 'BP00013', 'PD00013', 5, 172500, 862500),
('BPD00022', 'BP00014', 'PD00005', 3, 667000, 2001000),
('BPD00023', 'BP00015', 'PD00001', 10, 552000, 5520000),
('BPD00024', 'BP00016', 'PD00001', 3, 552000, 1656000),
('BPD00025', 'BP00017', 'PD00001', 1, 552000, 552000),
('BPD00026', 'BP00017', 'PD00001', 1, 460000, 460000),
('BPD00027', 'BP00018', 'PD00001', 19, 460000, 8740000),
('BPD00028', 'BP00018', 'PD00001', 2, 780000, 1560000),
('BPD00029', 'BP00019', 'PD00013', 10, 172500, 1725000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `booking`
--

CREATE TABLE `booking` (
  `BookingId` varchar(10) NOT NULL,
  `CourtId` varchar(10) NOT NULL,
  `Status` enum('successful','played') DEFAULT NULL,
  `StartTime` datetime NOT NULL,
  `EndTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `booking`
--

INSERT INTO `booking` (`BookingId`, `CourtId`, `Status`, `StartTime`, `EndTime`) VALUES
('BK00000001', 'CO00001', 'successful', '2025-12-08 06:30:00', '2025-12-08 07:30:00'),
('BK00000002', 'CO00002', 'successful', '2025-12-08 05:30:00', '2025-12-08 06:30:00'),
('BK00000003', 'CO00003', 'successful', '2025-12-08 07:45:00', '2025-12-08 08:45:00'),
('BK00000004', 'CO00002', 'successful', '2025-12-09 08:00:00', '2025-12-09 09:00:00'),
('BK00000005', 'CO00003', 'successful', '2025-12-08 11:00:00', '2025-12-08 12:00:00'),
('BK00000006', 'CO00004', 'successful', '2025-12-08 08:30:00', '2025-12-08 09:30:00'),
('BK00000007', 'CO00004', 'successful', '2025-12-09 08:30:00', '2025-12-09 09:30:00'),
('BK00000008', 'CO00002', 'successful', '2025-12-09 16:00:00', '2025-12-09 19:00:00'),
('BK00000009', 'CO00002', 'successful', '2025-12-08 10:00:00', '2025-12-08 12:00:00'),
('BK00000010', 'CO00002', 'successful', '2025-12-08 15:00:00', '2025-12-08 17:00:00'),
('BK00000011', 'CO00003', 'successful', '2025-12-08 15:00:00', '2025-12-08 17:00:00');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `brand`
--

CREATE TABLE `brand` (
  `BrandId` varchar(10) NOT NULL,
  `BrandName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `brand`
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
-- Cấu trúc bảng cho bảng `court`
--

CREATE TABLE `court` (
  `CourtId` varchar(10) NOT NULL,
  `CourtName` varchar(50) NOT NULL,
  `Status` enum('active','maintenance') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `court`
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
-- Cấu trúc bảng cho bảng `customer`
--

CREATE TABLE `customer` (
  `CustomerId` varchar(10) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `customer`
--

INSERT INTO `customer` (`CustomerId`, `CustomerName`, `Phone`, `IsDeleted`) VALUES
('CU00001', 'Nguyễn Văn A', '0987654321', 0),
('CU00002', 'Nguyễn Thị B', '0987643211', 0),
('CU00003', 'Trần C', '0987654322', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `employee`
--

CREATE TABLE `employee` (
  `EmployeeId` varchar(10) NOT NULL,
  `EmployeeName` varchar(30) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `RoleId` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `employee`
--

INSERT INTO `employee` (`EmployeeId`, `EmployeeName`, `Phone`, `Address`, `RoleId`) VALUES
('E00001', 'Admin', '0900000001', 'HCM', 'R00001');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `function`
--

CREATE TABLE `function` (
  `FunctionId` varchar(10) NOT NULL,
  `FunctionName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `function`
--

INSERT INTO `function` (`FunctionId`, `FunctionName`) VALUES
('F03', 'Bán hàng'),
('F05', 'Nhập hàng'),
('F13', 'Quản lý giá sân'),
('F04', 'Quản lý hóa đơn đặt sân'),
('F08', 'Quản lý khách hàng'),
('F15', 'Quản lý loại sản phẩm'),
('F16', 'Hóa đơn đặt sân'),
('F07', 'Quản lý nhà cung cấp'),
('F09', 'Quản lý nhân viên'),
('F11', 'Quản lý phân quyền'),
('F02', 'Quản lý sân'),
('F06', 'Quản lý sản phẩm'),
('F10', 'Quản lý tài khoản'),
('F12', 'Thống kê'),
('F14', 'Thương hiệu'),
('F01', 'Đặt sân');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `importbill`
--

CREATE TABLE `importbill` (
  `ImportBillId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `SupplierId` varchar(10) NOT NULL,
  `DateCreated` datetime NOT NULL,
  `TotalPrice` double NOT NULL,
  `Status` enum('pending','delivered','cancelled','paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `importbill`
--

INSERT INTO `importbill` (`ImportBillId`, `EmployeeId`, `SupplierId`, `DateCreated`, `TotalPrice`, `Status`) VALUES
('IB00001', 'E00001', 'SPU00001', '2025-12-01 14:49:10', 9200000, 'delivered'),
('IB00002', 'E00001', 'SPU00001', '2025-12-01 16:41:21', 8000000, 'delivered'),
('IB00003', 'E00001', 'SPU00001', '2025-12-01 16:56:23', 43800000, 'delivered'),
('IB00004', 'E00001', 'SPU00001', '2025-12-02 10:03:16', 86700000, 'delivered'),
('IB00005', 'E00001', 'SPU00002', '2025-12-02 10:04:02', 9000000, 'delivered'),
('IB00006', 'E00001', 'SPU00003', '2025-12-02 10:04:41', 53600000, 'delivered'),
('IB00007', 'E00001', 'SPU00001', '2025-12-02 10:05:41', 29400000, 'delivered'),
('IB00008', 'E00001', 'SPU00003', '2025-12-02 10:06:11', 25200000, 'delivered'),
('IB00009', 'E00001', 'SPU00002', '2025-12-02 10:06:40', 15000000, 'delivered'),
('IB00010', 'E00001', 'SPU00001', '2025-12-05 16:54:05', 19500000, 'delivered');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `payment`
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
-- Cấu trúc bảng cho bảng `permission`
--

CREATE TABLE `permission` (
  `PermissionId` varchar(10) NOT NULL,
  `PermissionName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `permission`
--

INSERT INTO `permission` (`PermissionId`, `PermissionName`) VALUES
('P00002', 'Admin'),
('P00003', 'Nhân viên bán hàng'),
('P00001', 'Quản lý');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `permissiondetail`
--

CREATE TABLE `permissiondetail` (
  `PermissionId` varchar(10) NOT NULL,
  `FunctionId` varchar(10) NOT NULL,
  `Option` enum('View','Insert','Update','Delete') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_nopad_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `permissiondetail`
--

INSERT INTO `permissiondetail` (`PermissionId`, `FunctionId`, `Option`) VALUES
('P00001', 'F01', 'Insert'),
('P00001', 'F01', 'View'),
('P00001', 'F02', 'Delete'),
('P00001', 'F02', 'Update'),
('P00001', 'F02', 'Insert'),
('P00001', 'F02', 'View'),
('P00001', 'F03', 'View'),
('P00001', 'F03', 'Insert'),
('P00001', 'F04', 'View'),
('P00001', 'F05', 'Insert'),
('P00001', 'F05', 'View'),
('P00001', 'F06', 'Delete'),
('P00001', 'F06', 'Update'),
('P00001', 'F06', 'Insert'),
('P00001', 'F06', 'View'),
('P00001', 'F07', 'Delete'),
('P00001', 'F07', 'Update'),
('P00001', 'F07', 'Insert'),
('P00001', 'F07', 'View'),
('P00001', 'F08', 'Update'),
('P00001', 'F08', 'Insert'),
('P00001', 'F08', 'View'),
('P00001', 'F09', 'Delete'),
('P00001', 'F09', 'Update'),
('P00001', 'F09', 'Insert'),
('P00001', 'F09', 'View'),
('P00001', 'F10', 'Delete'),
('P00001', 'F10', 'Update'),
('P00001', 'F10', 'Insert'),
('P00001', 'F10', 'View'),
('P00001', 'F11', 'Delete'),
('P00001', 'F11', 'Update'),
('P00001', 'F11', 'Insert'),
('P00001', 'F11', 'View'),
('P00001', 'F12', 'View'),
('P00001', 'F13', 'Insert'),
('P00001', 'F13', 'View'),
('P00001', 'F13', 'Update'),
('P00001', 'F13', 'Delete'),
('P00001', 'F14', 'Insert'),
('P00001', 'F14', 'View'),
('P00001', 'F14', 'Update'),
('P00001', 'F14', 'Delete'),
('P00001', 'F15', 'View'),
('P00001', 'F15', 'Insert'),
('P00001', 'F15', 'Update'),
('P00001', 'F15', 'Delete'),
('P00001', 'F16', 'View'),
('P00002', 'F09', 'View'),
('P00002', 'F13', 'Delete'),
('P00002', 'F13', 'Update'),
('P00002', 'F13', 'Insert'),
('P00002', 'F13', 'View'),
('P00002', 'F11', 'Delete'),
('P00002', 'F11', 'Update'),
('P00002', 'F11', 'Insert'),
('P00002', 'F11', 'View'),
('P00002', 'F10', 'Delete'),
('P00002', 'F10', 'Update'),
('P00002', 'F10', 'Insert'),
('P00002', 'F10', 'View'),
('P00003', 'F08', 'View'),
('P00003', 'F07', 'View'),
('P00003', 'F06', 'View'),
('P00003', 'F03', 'Insert'),
('P00003', 'F03', 'View'),
('P00003', 'F02', 'Update'),
('P00003', 'F01', 'Insert'),
('P00003', 'F01', 'View'),
('P00003', 'F02', 'View');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `pricebookingdetail`
--

CREATE TABLE `pricebookingdetail` (
  `PriceRuleId` varchar(10) NOT NULL,
  `BillBookingId` varchar(10) NOT NULL,
  `PriceApplied` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `pricebookingdetail`
--

INSERT INTO `pricebookingdetail` (`PriceRuleId`, `BillBookingId`, `PriceApplied`) VALUES
('PR0001', 'BB00001', 60000),
('PR0001', 'BB00002', 60000),
('PR0001', 'BB00003', 60000),
('PR0001', 'BB00004', 60000),
('PR0001', 'BB00005', 60000),
('PR0001', 'BB00006', 60000),
('PR0001', 'BB00008', 120000),
('PR0001', 'BB00009', 120000),
('PR0001', 'BB00010', 60000),
('PR0002', 'BB00007', 240000),
('PR0002', 'BB00009', 60000),
('PR0002', 'BB00010', 80000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `pricerule`
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
-- Đang đổ dữ liệu cho bảng `pricerule`
--

INSERT INTO `pricerule` (`PriceRuleId`, `Price`, `StartTime`, `EndTime`, `StartDate`, `EndDate`, `EndType`, `Description`, `Status`) VALUES
('PR0001', 60000, '05:00:00', '16:00:00', NULL, NULL, 'Weekday', 'Buổi sáng ngày thường', '1'),
('PR0002', 80000, '16:00:00', '22:00:00', NULL, NULL, 'Weekday', 'Buổi chiều ngày thường', '1'),
('PR0003', 80000, '05:00:00', '16:00:00', NULL, NULL, 'Weekend', 'Buổi sáng cuối tuần', '1'),
('PR0004', 100000, '16:00:00', '22:00:00', NULL, NULL, 'Weekend', 'Buổi chiều cuối tuần', '1'),
('PR0005', 50000, '05:00:00', '22:00:00', '2025-12-24 00:00:00', '2025-12-25 00:00:00', 'Holiday', 'Giáng sinh', '1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product`
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
-- Đang đổ dữ liệu cho bảng `product`
--

INSERT INTO `product` (`ProductId`, `ProductName`, `SupplierId`, `ProductImg`, `Quantity`, `BrandId`, `TypeId`, `IsDeleted`) VALUES
('PD00001', 'Yonex Astrox 99', 'SPU00001', 'yonex-astrox-99_2.png', 28, 'BR00001', 'TP00001', 0),
('PD00002', 'Yonex Nanoflare 700', 'SPU00001', 'yonex-nanoflare-700.png', 48, 'BR00001', 'TP00001', 0),
('PD00003', 'Kumpoo Power Control E88L', 'SPU00002', 'kumpoo-power-control-e88l.png', 20, 'BR00004', 'TP00001', 0),
('PD00004', 'Yonex Nanoflare 1000', 'SPU00001', 'yonex-nanoflare-1000z.png', 25, 'BR00001', 'TP00001', 0),
('PD00005', 'Yonex Astrox 100 Tour VA', 'SPU00001', 'yonex-astrox-100-tour-va.png', 26, 'BR00001', 'TP00001', 0),
('PD00006', 'Yonex Aerosensa Feather (12pcs)', 'SPU00001', 'yonex-aerosensa-20.png', 23, 'BR00001', 'TP00002', 0),
('PD00007', 'Yonex Voltric Z Force II LCW Limited', 'SPU00001', 'yonex-voltric-z-force-ii-lcw-limited.jpg', 25, 'BR00001', 'TP00001', 0),
('PD00008', 'Yonex Doura 10', 'SPU00001', 'yonex-doura-10.png', 33, 'BR00001', 'TP00001', 0),
('PD00009', 'Yonex ArcSaber 11', 'SPU00001', 'yonex-arcsaber-11.jpg', 32, 'BR00001', 'TP00001', 0),
('PD00010', 'Lining Woods N90 III', 'SPU00003', 'lining-woods-n90-iii.png', 38, 'BR00003', 'TP00001', 0),
('PD00011', 'Lining Aeronaut 6000', 'SPU00003', 'lining-aeronaut-6000.jpg', 40, 'BR00003', 'TP00001', 0),
('PD00012', 'Mizuno Fortius 10 Power', 'SPU00003', 'mizuno-fortius-10-power.jpg', 45, 'BR00005', 'TP00001', 0),
('PD00013', 'Adidas Spieler Grip', 'SPU00002', 'adidas-spieler-grip.jpg', 72, 'BR00006', 'TP00003', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `role`
--

CREATE TABLE `role` (
  `RoleId` varchar(10) NOT NULL,
  `RoleName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `role`
--

INSERT INTO `role` (`RoleId`, `RoleName`) VALUES
('R00002', 'Nhân viên'),
('R00001', 'Quản lý');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `storage`
--

CREATE TABLE `storage` (
  `StorageId` varchar(10) NOT NULL,
  `ImportBillDetailId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `Status` enum('active','inactive') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `storage`
--

INSERT INTO `storage` (`StorageId`, `ImportBillDetailId`, `ProductId`, `Quantity`, `Price`, `TotalPrice`, `CreatedAt`, `Status`) VALUES
('ST00001', 'ID00001', 'PD00001', 0, 552000, 0, '2025-12-01 14:49:06', 'inactive'),
('ST00002', 'ID00002', 'PD00001', 0, 460000, 0, '2025-12-01 16:41:03', 'inactive'),
('ST00003', 'ID00003', 'PD00005', 26, 667000, 17342000, '2025-12-01 16:55:58', 'active'),
('ST00004', 'ID00004', 'PD00006', 23, 333500, 7670500, '2025-12-01 16:56:04', 'active'),
('ST00005', 'ID00005', 'PD00004', 25, 678500, 16962500, '2025-12-01 16:56:16', 'active'),
('ST00006', 'ID00006', 'PD00002', 48, 888000, 42624000, '2025-12-02 10:02:12', 'active'),
('ST00007', 'ID00007', 'PD00007', 25, 1176000, 29400000, '2025-12-02 10:02:47', 'active'),
('ST00008', 'ID00008', 'PD00009', 32, 864000, 27648000, '2025-12-02 10:03:10', 'active'),
('ST00009', 'ID00009', 'PD00003', 20, 517500, 10350000, '2025-12-02 10:03:59', 'active'),
('ST00010', 'ID00010', 'PD00010', 38, 782000, 29716000, '2025-12-02 10:04:28', 'active'),
('ST00011', 'ID00011', 'PD00011', 40, 759000, 30360000, '2025-12-02 10:04:38', 'active'),
('ST00012', 'ID00012', 'PD00008', 33, 1008000, 33264000, '2025-12-02 10:05:29', 'active'),
('ST00013', 'ID00013', 'PD00012', 45, 644000, 28980000, '2025-12-02 10:06:08', 'active'),
('ST00014', 'ID00014', 'PD00013', 72, 172500, 12420000, '2025-12-02 10:06:36', 'active'),
('ST00015', 'ID00015', 'PD00001', 28, 780000, 21840000, '2025-12-05 16:54:01', 'active');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `supplier`
--

CREATE TABLE `supplier` (
  `SupplierId` varchar(10) NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `supplier`
--

INSERT INTO `supplier` (`SupplierId`, `SupplierName`, `Email`, `Address`, `IsDeleted`) VALUES
('SPU00001', 'Yonex Supplier', 'yonex@supplier.com', 'Tokyo', 0),
('SPU00002', 'Victor Supplier', 'victor@supplier.com', 'Taipei', 0),
('SPU00003', 'Li-Ning Supplier', 'lining@supplier.com', 'Beijing', 0),
('SPU00004', ' Kumpoo Supplier', 'kumpoo@supplier.com', 'Japan', 0),
('SPU00005', 'Mizuno Supplier', 'mizuno@supplier.com', 'Japan', 0),
('SPU00006', 'Adidas Supplier', 'adidas@supplier.com', 'USA', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `typeproduct`
--

CREATE TABLE `typeproduct` (
  `TypeId` varchar(10) NOT NULL,
  `TypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `typeproduct`
--

INSERT INTO `typeproduct` (`TypeId`, `TypeName`) VALUES
('TP00001', 'Racket'),
('TP00002', 'Shuttlecock'),
('TP00003', 'Grip');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`Username`),
  ADD KEY `PermissionId` (`PermissionId`),
  ADD KEY `account_ibfk_2` (`EmployeeId`);

--
-- Chỉ mục cho bảng `billbooking`
--
ALTER TABLE `billbooking`
  ADD PRIMARY KEY (`BillBookingId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `CustomerId` (`CustomerId`),
  ADD KEY `BookingId` (`BookingId`);

--
-- Chỉ mục cho bảng `billimportproductdetail`
--
ALTER TABLE `billimportproductdetail`
  ADD PRIMARY KEY (`ImportBillDetailId`),
  ADD KEY `ProductId` (`ProductId`),
  ADD KEY `billimportproductdetail_ibfk_1` (`ImportBillId`);

--
-- Chỉ mục cho bảng `billproduct`
--
ALTER TABLE `billproduct`
  ADD PRIMARY KEY (`BillProductId`),
  ADD KEY `EmployeeId` (`EmployeeId`);

--
-- Chỉ mục cho bảng `billproductdetail`
--
ALTER TABLE `billproductdetail`
  ADD PRIMARY KEY (`BillProductDetailId`),
  ADD KEY `ProductId` (`ProductId`),
  ADD KEY `BillProductId` (`BillProductId`);

--
-- Chỉ mục cho bảng `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`BookingId`),
  ADD KEY `CourtId` (`CourtId`);

--
-- Chỉ mục cho bảng `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`BrandId`);

--
-- Chỉ mục cho bảng `court`
--
ALTER TABLE `court`
  ADD PRIMARY KEY (`CourtId`),
  ADD UNIQUE KEY `CourtName` (`CourtName`);

--
-- Chỉ mục cho bảng `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerId`),
  ADD UNIQUE KEY `Phone` (`Phone`);

--
-- Chỉ mục cho bảng `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeId`),
  ADD UNIQUE KEY `Phone` (`Phone`),
  ADD KEY `RoleId` (`RoleId`);

--
-- Chỉ mục cho bảng `function`
--
ALTER TABLE `function`
  ADD PRIMARY KEY (`FunctionId`),
  ADD UNIQUE KEY `FunctionName` (`FunctionName`);

--
-- Chỉ mục cho bảng `importbill`
--
ALTER TABLE `importbill`
  ADD PRIMARY KEY (`ImportBillId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `SupplierId` (`SupplierId`);

--
-- Chỉ mục cho bảng `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentId`),
  ADD KEY `BillProductId` (`BillProductId`);

--
-- Chỉ mục cho bảng `permission`
--
ALTER TABLE `permission`
  ADD PRIMARY KEY (`PermissionId`),
  ADD UNIQUE KEY `PermissionName` (`PermissionName`);

--
-- Chỉ mục cho bảng `permissiondetail`
--
ALTER TABLE `permissiondetail`
  ADD KEY `FunctionId` (`FunctionId`);

--
-- Chỉ mục cho bảng `pricebookingdetail`
--
ALTER TABLE `pricebookingdetail`
  ADD PRIMARY KEY (`PriceRuleId`,`BillBookingId`),
  ADD KEY `BillBookingId` (`BillBookingId`);

--
-- Chỉ mục cho bảng `pricerule`
--
ALTER TABLE `pricerule`
  ADD PRIMARY KEY (`PriceRuleId`);

--
-- Chỉ mục cho bảng `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductId`),
  ADD KEY `BrandId` (`BrandId`),
  ADD KEY `TypeId` (`TypeId`),
  ADD KEY `SupplierId` (`SupplierId`);

--
-- Chỉ mục cho bảng `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`RoleId`),
  ADD UNIQUE KEY `RoleName` (`RoleName`);

--
-- Chỉ mục cho bảng `storage`
--
ALTER TABLE `storage`
  ADD PRIMARY KEY (`StorageId`),
  ADD KEY `ImportBillId` (`ImportBillDetailId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Chỉ mục cho bảng `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierId`);

--
-- Chỉ mục cho bảng `typeproduct`
--
ALTER TABLE `typeproduct`
  ADD PRIMARY KEY (`TypeId`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`PermissionId`) REFERENCES `permission` (`PermissionId`),
  ADD CONSTRAINT `account_ibfk_2` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`);

--
-- Các ràng buộc cho bảng `billbooking`
--
ALTER TABLE `billbooking`
  ADD CONSTRAINT `billbooking_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `billbooking_ibfk_2` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`),
  ADD CONSTRAINT `billbooking_ibfk_3` FOREIGN KEY (`BookingId`) REFERENCES `booking` (`BookingId`);

--
-- Các ràng buộc cho bảng `billimportproductdetail`
--
ALTER TABLE `billimportproductdetail`
  ADD CONSTRAINT `billimportproductdetail_ibfk_1` FOREIGN KEY (`ImportBillId`) REFERENCES `importbill` (`ImportBillId`),
  ADD CONSTRAINT `billimportproductdetail_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);

--
-- Các ràng buộc cho bảng `billproduct`
--
ALTER TABLE `billproduct`
  ADD CONSTRAINT `billproduct_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`);

--
-- Các ràng buộc cho bảng `billproductdetail`
--
ALTER TABLE `billproductdetail`
  ADD CONSTRAINT `billproductdetail_ibfk_1` FOREIGN KEY (`BillProductId`) REFERENCES `billproduct` (`BillProductId`),
  ADD CONSTRAINT `billproductdetail_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);

--
-- Các ràng buộc cho bảng `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`CourtId`) REFERENCES `court` (`CourtId`);

--
-- Các ràng buộc cho bảng `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`RoleId`) REFERENCES `role` (`RoleId`);

--
-- Các ràng buộc cho bảng `importbill`
--
ALTER TABLE `importbill`
  ADD CONSTRAINT `importbill_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `importbill_ibfk_2` FOREIGN KEY (`SupplierId`) REFERENCES `supplier` (`SupplierId`);

--
-- Các ràng buộc cho bảng `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`BillProductId`) REFERENCES `billproduct` (`BillProductId`);

--
-- Các ràng buộc cho bảng `pricebookingdetail`
--
ALTER TABLE `pricebookingdetail`
  ADD CONSTRAINT `pricebookingdetail_ibfk_1` FOREIGN KEY (`PriceRuleId`) REFERENCES `pricerule` (`PriceRuleId`),
  ADD CONSTRAINT `pricebookingdetail_ibfk_2` FOREIGN KEY (`BillBookingId`) REFERENCES `billbooking` (`BillBookingId`);

--
-- Các ràng buộc cho bảng `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`BrandId`) REFERENCES `brand` (`BrandId`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `typeproduct` (`TypeId`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`SupplierId`) REFERENCES `supplier` (`SupplierId`);

--
-- Các ràng buộc cho bảng `storage`
--
ALTER TABLE `storage`
  ADD CONSTRAINT `storage_ibfk_1` FOREIGN KEY (`ImportBillDetailId`) REFERENCES `billimportproductdetail` (`ImportBillDetailId`),
  ADD CONSTRAINT `storage_ibfk_2` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
