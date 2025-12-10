using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BadmintonCourtManagement.BUS
{
    public class BillBookingBUS
    {
        private BillBookingDAO billBookingDAO;

        public BillBookingBUS()
        {
            billBookingDAO = new BillBookingDAO();
        }

        // 🔹 Lấy danh sách tất cả hóa đơn
        public List<BillBookingDTO> GetAllBillBookings()
        {
            return billBookingDAO.GetAllBillBookings();
        }

        // 🔹 Lấy hóa đơn theo ID
        public BillBookingDTO GetBillBookingById(string id)
        {
            return billBookingDAO.GetBillBookingById(id);
        }

        // 🔹 Lấy hóa đơn theo BookingId
        public BillBookingDTO GetBillBookingByBookingId(string bookingId)
        {
            return billBookingDAO.GetBillBookingByBookingId(bookingId);
        }

        // 🔹 Thêm hóa đơn mới
        public bool InsertBillBooking(BillBookingDTO bill)
        {
            // Validation đơn giản
            if (string.IsNullOrWhiteSpace(bill.BillBookingId) ||
                string.IsNullOrWhiteSpace(bill.BookingId) ||
                bill.TotalPrice < 0 ||
                bill.PrePayment < 0 ||
                bill.PrePayment > bill.TotalPrice)
            {
                return false;
            }

            return billBookingDAO.InsertBillBooking(bill);
        }

        // 🔹 Cập nhật hóa đơn
        public bool UpdateBillBooking(BillBookingDTO bill)
        {
            // Validation đơn giản
            if (string.IsNullOrWhiteSpace(bill.BillBookingId) ||
                bill.TotalPrice < 0 ||
                bill.PrePayment < 0 ||
                bill.PrePayment > bill.TotalPrice)
            {
                return false;
            }

            return billBookingDAO.UpdateBillBooking(bill);
        }

        // 🔹 Xóa hóa đơn
        public bool DeleteBillBooking(string billBookingId)
        {
            if (string.IsNullOrWhiteSpace(billBookingId))
                return false;

            return billBookingDAO.DeleteBillBooking(billBookingId);
        }

        // 🔹 Tìm kiếm hóa đơn
        public List<BillBookingDTO> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllBillBookings();

            return billBookingDAO.Search(keyword);
        }

        // 🔹 Lấy ID tiếp theo
        public string GetNextId()
        {
            return billBookingDAO.GetNextId();
        }

        // 🔹 Lấy danh sách hóa đơn theo CustomerId
        public List<BillBookingDTO> GetBillBookingsByCustomerId(string customerId)
        {
            return billBookingDAO.GetBillBookingsByCustomerId(customerId);
        }

        // 🔹 Tính số tiền còn lại phải trả
        public double GetRemainingAmount(BillBookingDTO bill)
        {
            return bill.TotalPrice - bill.PrePayment;
        }

        // 🔹 Kiểm tra hóa đơn đã thanh toán đủ chưa
        public bool IsFullyPaid(BillBookingDTO bill)
        {
            return bill.PrePayment >= bill.TotalPrice;
        }

        // 🔹 Lấy tổng doanh thu từ tất cả hóa đơn
        public double GetTotalRevenue()
        {
            var allBills = GetAllBillBookings();
            return allBills.Sum(b => b.TotalPrice);
        }

        // 🔹 Lấy tổng tiền đã thu (PrePayment)
        public double GetTotalCollected()
        {
            var allBills = GetAllBillBookings();
            return allBills.Sum(b => b.PrePayment);
        }

        // 🔹 Lấy tổng tiền còn nợ
        public double GetTotalDebt()
        {
            var allBills = GetAllBillBookings();
            return allBills.Sum(b => b.TotalPrice - b.PrePayment);
        }
    }
}
