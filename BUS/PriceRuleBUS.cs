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
    }
}