using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;
namespace BadmintonCourtManagement.DAO
{
    public class CustomerDAO
    {
        private DBConnection db = new DBConnection();
        // create
        public bool InsertCustomer(CustomerDTO customer)
        {
            string query = "INSERT INTO customer (CustomerId, CustomerName, Phone, IsDeleted) VALUES (@CustomerId, @CustomerName, @Phone, @IsDeleted)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@Phone", customer.CustomerPhone);
                cmd.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<CustomerDTO> GetAllCustomers()
        {
            return new List<CustomerDTO>();
        }

        public CustomerDTO GetCustomerById(string id)
        {
            return new CustomerDTO();
        }

        // update
        public bool UpdateCustomer(CustomerDTO customer)
        {
            return true;
        }

        // delete
        public bool DeleteCustomer(CustomerDTO customer)
        {
            return true;
        }
    }
}
