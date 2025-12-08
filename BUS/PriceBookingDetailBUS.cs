using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class PriceBookingDetailBUS
    {
        private static PriceBookingDetailDAO dao = new PriceBookingDetailDAO();

        public static bool InsertPriceBookingDetail(PriceBookingDetailDTO bill)
        {
            return dao.InsertPriceBookingDetail(bill);
        }

        public static List<PriceBookingDetailDTO> GetPriceBookingDetailsByPriceBookingId(string importBillId)
        {
            return dao.GetPriceBookingDetailsByPriceBookingId(importBillId);
        }
    }
}