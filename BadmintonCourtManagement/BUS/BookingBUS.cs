using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class BookingBUS
    {
        private BookingDAO dao =  new BookingDAO();

        public BookingDTO GetBookingById(string id)
        {
            return dao.GetBookingById(id);
        }

        public List<BookingDTO> GetAllBookings()
        {
            return dao.GetAllBookings();
        }

        public bool InsertBooking(BookingDTO booking)
        {
            // Kiểm tra xem booking đã tồn tại chưa
            var existing = dao.GetBookingById(booking.Id);
            if (existing != null)
                throw new Exception("Booking đã tồn tại!");

            return dao.InsertBooking(booking);
        }

        public bool UpdateBooking(BookingDTO booking)
        {
            var existing = dao.GetBookingById(booking.Id);
            if (existing == null)
                throw new Exception("Booking không tồn tại!");

            return dao.UpdateBooking(booking);
        }

        public bool DeleteBooking(string id)
        {
            var existing = dao.GetBookingById(id);
            if (existing == null)
                throw new Exception("Booking không tồn tại!");

            return dao.DeleteBooking(id);
        }
    }
}