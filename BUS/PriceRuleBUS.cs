using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BadmintonCourtManagement.BUS
{
    public class PriceRuleBUS
    {
        private PriceRuleDAO dao = new PriceRuleDAO();

        public List<PriceRuleDTO> GetAllPriceRules()
        {
            return dao.GetAllPriceRules();
        }

        public bool InsertPriceRule(PriceRuleDTO priceRule)
        {
            // Kiểm tra xem PriceRule đã tồn tại chưa
            var existing = dao.GetPriceRuleById(priceRule.PriceRuleId);
            if (existing != null)
                throw new Exception("PriceRule đã tồn tại!");

            return dao.InsertPriceRule(priceRule);
        }

        public bool UpdatePriceRule(PriceRuleDTO priceRule)
        {
            // Kiểm tra xem PriceRule đã tồn tại chưa
            var existing = dao.GetPriceRuleById(priceRule.PriceRuleId);
            if (existing == null)
                throw new Exception("PriceRule không tồn tại!");

            return dao.UpdatePriceRule(priceRule);
        }

        public bool DeletePriceRule(string id)
        {
            var existing = dao.GetPriceRuleById(id);
            if (existing == null)
                throw new Exception("PriceRule không tồn tại!");

            return dao.DeletePriceRule(id);
        }

        public bool DeletePriceRule1(string id)
        {
            var existing = dao.GetPriceRuleById(id);
            if (existing == null)
                throw new Exception("PriceRule không tồn tại!");

            return dao.DeletePriceRule1(id);
        }

        public Dictionary<string, string> ValidatePriceRule(PriceRuleDTO dto)
        {
            var errors = new Dictionary<string, string>();

            if (dto.EndTime <= dto.StartTime)
                errors.Add("EndTime", "Giờ kết thúc phải lớn hơn giờ bắt đầu.");

            if (dto.EndDate < dto.StartDate)
                errors.Add("EndDate", "Ngày kết thúc phải lớn hơn ngày bắt đầu.");

            return errors;
        }

        public string GeneratePriceRuleId()
        {
            List<PriceRuleDTO> priceRules = dao.GetAllPriceRules();

            if (priceRules == null || priceRules.Count == 0)
            {
                return "PR0001";
            }

            string lastId = priceRules.OrderByDescending(r => r.PriceRuleId).FirstOrDefault().PriceRuleId;

            string numberPart = lastId.Substring(2);

            int nextNumber = int.Parse(numberPart) + 1;

            return "PR" + nextNumber.ToString("D4");
        }
    }
}