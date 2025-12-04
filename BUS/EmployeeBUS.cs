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

        public List<EmployeeDTO> GetAllEmployeesNotHaveAccount()
        {
            List<EmployeeDTO> employees = employeeDAO.GetAllEmployees();
            List<EmployeeDTO> employeesNotHaveAccount = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                if (string.IsNullOrEmpty(employee.Username))
                {
                    employeesNotHaveAccount.Add(employee);
                }
            }
            return employeesNotHaveAccount;
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            return employeeDAO.GetEmployeeById(id);
        }

        public EmployeeDTO GetEmployeeByUsername(string username)
        {
            return employeeDAO.GetEmployeeByUsername(username);
        }

        // 🔹 Kiểm tra tên không chứa số & ký tự đặc biệt
        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Không được chứa số
            if (name.Any(char.IsDigit))
                return false;

            // Chỉ cho phép chữ cái tiếng Việt + khoảng trắng
            string pattern = @"^[\p{L}\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(name, pattern);
        }

        public bool InsertEmployee(EmployeeDTO employee)
        {
            if (!IsValidName(employee.EmployeeName))
                throw new ArgumentException("Tên không được chứa số hoặc ký tự đặc biệt");
            if (employee.EmployeePhone.Length != 10 || !employee.EmployeePhone.All(char.IsDigit))
                throw new ArgumentException("Số điện thoại phải là 10 chữ số");
            string[] validPrefixes = { "09", "03", "07", "08", "06", "02" };
            if (!validPrefixes.Any(prefix => employee.EmployeePhone.StartsWith(prefix)))
                throw new ArgumentException("Số điện thoại phải bắt đầu bằng 09, 03, 07, 08, 06, 02");
            if (employeeDAO.isPhoneExists(employee.EmployeePhone))
                throw new ArgumentException("Số điện thoại đã tồn tại");

            return employeeDAO.InsertEmployee(employee);
        }

        public bool UpdateEmployee(EmployeeDTO employee)
        {
            if (!IsValidName(employee.EmployeeName))
                throw new ArgumentException("Tên không được chứa số hoặc ký tự đặc biệt");
            if (employee.EmployeePhone.Length != 10 || !employee.EmployeePhone.All(char.IsDigit))
                throw new ArgumentException("Số điện thoại phải là 10 chữ số");
            string[] validPrefixes = { "09", "03", "07", "08", "06", "02" };
            if (!validPrefixes.Any(prefix => employee.EmployeePhone.StartsWith(prefix)))
                throw new ArgumentException("Số điện thoại phải bắt đầu bằng 09, 03, 07, 08, 06, 02");
            if (employeeDAO.isPhoneExistsUpdate(employee.EmployeePhone, employee.EmployeeId))
                throw new ArgumentException("Số điện thoại đã tồn tại");
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
