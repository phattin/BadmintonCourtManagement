using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class AccountBUS
    {
        private AccountDAO dao = new AccountDAO();

        public AccountDTO GetByUsername(string username)
        {
            return dao.GetByUsername(username);
        }

        public List<AccountDTO> GetAllAccount()
        {
            return dao.GetAllAccount();
        }

        public List<AccountDTO> GetAllAccount1()
        {
            return dao.GetAllAccount1();
        }

        public AccountDTO GetAccount(string username, string password)
        {
            return dao.GetAccount(username, password);
        }

        public bool InsertAccount(AccountDTO account)
        {
            // Kiểm tra username đã tồn tại chưa
            var existing = dao.GetByUsername(account.Username);
            if (existing != null)
                throw new Exception("Username đã tồn tại!");

            return dao.InsertAccount(account);
        }

        public bool UpdateAccount(AccountDTO account)
        {
            var existing = dao.GetByUsername(account.Username);
            if (existing == null)
                throw new Exception("Account không tồn tại!");

            return dao.UpdateAccount(account);
        }

        public bool DeleteAccount(string username)
        {
            var existing = dao.GetByUsername(username);
            if (existing == null)
                throw new Exception("Account không tồn tại!");

            return dao.DeleteAccount(username);
        }

        public Dictionary<string, string> ValidateAccount(AccountDTO account)
        {
            Dictionary<string, string> errors = new Dictionary<string, string>();
            if (string.IsNullOrWhiteSpace(account.Username))
            {
                errors.Add("Username", "Vui lòng nhập tên tài khoản.");
            }
            else if (string.IsNullOrWhiteSpace(account.Password))
            {
                errors.Add("Password", "Vui lòng nhập mật khẩu.");
            }
            return errors;
        }
    }
}
