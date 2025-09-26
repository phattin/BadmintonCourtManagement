-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th9 24, 2025 lúc 10:34 AM
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
  `PermissionId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `account`
--

INSERT INTO `account` (`Username`, `Password`, `PermissionId`, `IsDeleted`) VALUES
('admin', 'admin123', 'P00001', 0);

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
  `ImportBillId` varchar(10) NOT NULL,
  `ProductId` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `Status` enum('paid','unpaid') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `billproduct`
--

CREATE TABLE `billproduct` (
  `BillProductId` varchar(10) NOT NULL,
  `EmployeeId` varchar(10) NOT NULL,
  `CustomerId` varchar(10) NOT NULL,
  `TotalPrice` double NOT NULL,
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `court`
--

CREATE TABLE `court` (
  `CourtId` varchar(10) NOT NULL,
  `CourtName` varchar(50) NOT NULL,
  `Status` enum('active','maintenance') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `function`
--

CREATE TABLE `function` (
  `FunctionId` varchar(10) NOT NULL,
  `FunctionName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `importbill`
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
  `PermissionName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `permission`
--

INSERT INTO `permission` (`PermissionId`, `PermissionName`) VALUES
('P00001', 'Quản lý');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `permissiondetail`
--

CREATE TABLE `permissiondetail` (
  `PermissionId` varchar(10) NOT NULL,
  `FunctionId` varchar(10) NOT NULL,
  `Option` enum('view','add','edit','delete') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  `Description` varchar(255) DEFAULT NULL,
  `Status` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product`
--

CREATE TABLE `product` (
  `ProductId` varchar(10) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `Producing` varchar(255) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `BrandId` varchar(10) NOT NULL,
  `TypeId` varchar(10) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `role`
--

CREATE TABLE `role` (
  `RoleId` varchar(10) NOT NULL,
  `RoleName` varchar(30) NOT NULL
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `typeproduct`
--

CREATE TABLE `typeproduct` (
  `TypeId` varchar(10) NOT NULL,
  `TypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`Username`),
  ADD KEY `PermissionId` (`PermissionId`);

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
  ADD PRIMARY KEY (`ImportBillId`,`ProductId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Chỉ mục cho bảng `billproduct`
--
ALTER TABLE `billproduct`
  ADD PRIMARY KEY (`BillProductId`),
  ADD KEY `EmployeeId` (`EmployeeId`),
  ADD KEY `CustomerId` (`CustomerId`);

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
  ADD KEY `Username` (`Username`),
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
  ADD PRIMARY KEY (`PermissionId`,`FunctionId`),
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
  ADD KEY `TypeId` (`TypeId`);

--
-- Chỉ mục cho bảng `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`RoleId`),
  ADD UNIQUE KEY `RoleName` (`RoleName`);

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
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`PermissionId`) REFERENCES `permission` (`PermissionId`);

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
  ADD CONSTRAINT `billproduct_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`),
  ADD CONSTRAINT `billproduct_ibfk_2` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`);

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
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`Username`) REFERENCES `account` (`Username`),
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
-- Các ràng buộc cho bảng `permissiondetail`
--
ALTER TABLE `permissiondetail`
  ADD CONSTRAINT `permissiondetail_ibfk_1` FOREIGN KEY (`PermissionId`) REFERENCES `permission` (`PermissionId`),
  ADD CONSTRAINT `permissiondetail_ibfk_2` FOREIGN KEY (`FunctionId`) REFERENCES `function` (`FunctionId`);

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
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `typeproduct` (`TypeId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
