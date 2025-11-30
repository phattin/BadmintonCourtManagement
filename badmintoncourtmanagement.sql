-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 30, 2025 lúc 06:56 PM
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
  `TotalPrice` double DEFAULT 0,
  `PrePayment` double DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billproductdetail`
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
-- Cấu trúc bảng cho bảng `booking`
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `employee`
--

CREATE TABLE `employee` (
  `EmployeeId` varchar(10) NOT NULL,
  `EmployeeName` varchar(30) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Username` varchar(30) NOT NULL,
  `RoleId` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `employee`
--

INSERT INTO `employee` (`EmployeeId`, `EmployeeName`, `Phone`, `Address`, `Username`, `RoleId`) VALUES
('E00001', 'Admin', '0900000001', 'HCM', 'admin', 'R00001');

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
-- Cấu trúc bảng cho bảng `pricebookingdetail`
--

CREATE TABLE `pricebookingdetail` (
  `PriceRuleId` varchar(10) NOT NULL,
  `BillBookingId` varchar(10) NOT NULL,
  `PriceApplied` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  ADD PRIMARY KEY (`BillProductId`,`ProductId`),
  ADD KEY `ProductId` (`ProductId`);

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
