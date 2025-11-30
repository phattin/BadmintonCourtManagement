using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            return employeeDAO.GetEmployeeById(id);
        }

        //public EmployeeDTO GetEmployeeByUsername(string username)
        //{
        //    return employeeDAO.GetEmployeeByUsername(username);
        //}

        public bool InsertEmployee(EmployeeDTO employee)
        {
            return employeeDAO.InsertEmployee(employee);
        }

        public bool UpdateEmployee(EmployeeDTO employee)
        {
            return employeeDAO.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(string id)
        {
            return employeeDAO.DeleteEmployee(id);
        }

        public List<EmployeeDTO> Search(string keyword)
        {
            return employeeDAO.Search(keyword);
        }

        public string GetNextId()
        {
            return employeeDAO.GetNextId();
        }
    }
}
