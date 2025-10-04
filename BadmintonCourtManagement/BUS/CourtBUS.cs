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

        public List<CourtDTO> GetAllCourts()
        {
            return courtDAO.GetAllCourts();
        }
    }
}
