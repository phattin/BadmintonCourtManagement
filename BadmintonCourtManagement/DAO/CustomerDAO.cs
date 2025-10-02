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
            string query = "INSERT INTO customer (CustomerId, CustomerName, Phone, IsDeleted)"
            + " VALUES (@CustomerId, @CustomerName, @Phone, @IsDeleted)";
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
            string query = "SELECT * FROM customer WHERE IsDeleted = 0";
            List<CustomerDTO> customers = new List<CustomerDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CustomerDTO customer = new CustomerDTO
                    {
                        CustomerId = reader["CustomerId"].ToString(),
                        CustomerName = reader["CustomerName"].ToString(),
                        CustomerPhone = reader["Phone"].ToString(),
                        IsDeleted = int.Parse(reader["IsDeleted"].ToString())
                    };
                    customers.Add(customer);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return customers;
        }

        public CustomerDTO GetCustomerById(string id)
        {
            string query = "SELECT * FROM customer WHERE CustomerId = @CustomerId AND IsDeleted = 0";
            CustomerDTO customer = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // chỉ đọc 1 bản ghi
                {
                    customer = new CustomerDTO
                    {
                        CustomerId = reader["CustomerId"].ToString(),
                        CustomerName = reader["CustomerName"].ToString(),
                        CustomerPhone = reader["Phone"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])  // an toàn hơn int.Parse
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return customer; 
        }


        // search
        public List<CustomerDTO> Search(string search)
        {
            string query = "SELECT * FROM customer WHERE (CustomerName LIKE @Search OR Phone LIKE @Search) AND IsDeleted = 0";
            List<CustomerDTO> customers = new List<CustomerDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CustomerDTO customer = new CustomerDTO
                    {
                        CustomerId = reader["CustomerId"].ToString(),
                        CustomerName = reader["CustomerName"].ToString(),
                        CustomerPhone = reader["Phone"].ToString(),
                        IsDeleted = int.Parse(reader["IsDeleted"].ToString())
                    };
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return customers;
        }

        // update
        public bool UpdateCustomer(CustomerDTO customer)
        {
            string query = "UPDATE customer SET CustomerName = @CustomerName, Phone = @Phone WHERE CustomerId = @CustomerId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@Phone", customer.CustomerPhone);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteCustomer(string id)
        {
            string query = "UPDATE customer SET IsDeleted = 1 WHERE CustomerId = @CustomerId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", id);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
