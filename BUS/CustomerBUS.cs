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
    }
}