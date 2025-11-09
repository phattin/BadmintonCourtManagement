using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class StatisticalBUS
    {
        private StatisticalDAO dao = new StatisticalDAO();

        // Lấy sản phẩm có số lượng bán chạy cao nhất, theo khoảng thời gian
        //(DateTime startDate, DateTime endDate, bool sortDescending, string sortBy = "TotalSold")
        public List<StatisticalDAO.TopSellingProductDTO> GetTopSellingProducts(DateTime startDate, DateTime endDate,bool sortDescending, string sortBy)
        {
            return dao.GetTopSellingProducts(startDate, endDate,  sortDescending,  sortBy);
        }

        // Lấy thống kê doanh thu theo khoảng thời gian và ngày trong tuần
        public List<StatisticalDAO.CourtRevenueDTO> GetCourtRevenue(DateTime startDate, DateTime endDate, string courtNameFilter, bool sortDescending = true)
        {
            return dao.GetCourtRevenue(startDate, endDate, courtNameFilter, sortDescending);
        }
        public StatisticalDAO.RevenueSummaryDTO GetRevenueSummary(DateTime startDate, DateTime endDate)
        {
            return dao.GetRevenueSummary(startDate,endDate);
        }
    }
        
}