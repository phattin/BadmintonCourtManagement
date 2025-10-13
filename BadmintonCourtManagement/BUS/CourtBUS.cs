using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.BUS
{
    internal class CourtBUS
    {
        private CourtDAO courtDAO;

        public CourtBUS()
        {
            courtDAO = new CourtDAO();
        }

        // Lấy danh sách tất cả sân
        public List<CourtDTO> GetAllCourts()
        {
            return courtDAO.GetAllCourts();
        }

        // Lấy sân theo ID
        public CourtDTO GetCourtById(string courtId)
        {
            return courtDAO.GetCourtById(courtId);
        }

        // Thêm sân mới
        public bool InsertCourt(CourtDTO court)
        {
            if (court.CourtName.Length > 50)
            {
                MessageBox.Show("Tên sân không được vượt quá 50 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (courtDAO.CheckNameExists(court.CourtName))
            {
                MessageBox.Show("Tên sân đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return courtDAO.InsertCourt(court);
        }

        // Cập nhật sân
        public bool UpdateCourt(CourtDTO court)
        {
            if (court.CourtName.Length > 50)
            {
                MessageBox.Show("Tên sân không được vượt quá 50 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (courtDAO.CheckNameExistsUpdate(court.CourtId, court.CourtName))
            {
                MessageBox.Show("Tên sân đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return courtDAO.UpdateCourt(court);
        }

        // Xóa sân
        public bool DeleteCourt(string courtId)
        {
            return courtDAO.DeleteCourt(courtId);
        }

        // Tìm kiếm sân theo từ khóa
        public List<CourtDTO> Search(string keyword)
        {
            return courtDAO.Search(keyword);
        }

        // Lấy ID kế tiếp
        public string GetNextId()
        {
            return courtDAO.GetNextId();
        }

        public List<CourtDTO> FilterByStatus(string status)
        {
            return courtDAO.FilterByStatus(status);
        }

    }
}
