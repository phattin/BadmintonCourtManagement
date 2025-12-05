using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class CustomerBUS
    {
        private CustomerDAO dao = new CustomerDAO();

        public List<CustomerDTO> Search(string search)
        {
            return dao.Search(search);
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return dao.GetAllCustomers();
        }

        public CustomerDTO GetCustomerById(string id)
        {
            return dao.GetCustomerById(id);
        }

        public bool InsertCustomer(CustomerDTO customer)
        {
            // Kiểm tra CustomerId đã tồn tại chưa
            var existing = dao.GetCustomerById(customer.CustomerId);
            if (existing != null)
                throw new Exception("CustomerId đã tồn tại!");

            return dao.InsertCustomer(customer);
        }

        public bool UpdateCustomer(CustomerDTO customer)
        {
            var existing = dao.GetCustomerById(customer.CustomerId);
            if (existing == null)
                throw new Exception("Customer không tồn tại!");

            return dao.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(string id)
        {
            var existing = dao.GetCustomerById(id);
            if (existing == null)
                throw new Exception("Customer không tồn tại!");

            return dao.DeleteCustomer(id);
        }

              // Lấy ID kế tiếp
        public string GetNextId()
        {
            return dao.GetNextId();
        }
        public CustomerDTO GetCustomerByPhone(string phone)
        {
            return dao.GetCustomerByPhone(phone);
        }

        public static bool IsValidVietnamesePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Loại bỏ khoảng trắng, dấu gạch ngang, dấu chấm...
            string cleaned = System.Text.RegularExpressions.Regex.Replace(phone.Trim(), @"[^0-9]", "");

            // Phải đúng 10 chữ số
            if (cleaned.Length != 10)
                return false;

            // Danh sách đầu số hợp lệ (cập nhật đến 2025)
            string[] validPrefixes = new string[]
            {
                "02",  // cố định một số tỉnh
                "03", "05", "07", "08", "09"  // các đầu số di động phổ biến
                // Nếu muốn chi tiết hơn có thể thêm: 032,033,034,...,089,090,...
                // nhưng để đơn giản và bao quát thì chỉ cần kiểm tra 2 chữ số đầu
            };

            string prefix = cleaned.Substring(0, 2);
            return validPrefixes.Contains(prefix);
        }

    }
}