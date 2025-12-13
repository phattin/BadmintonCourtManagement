using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static Google.Protobuf.Reflection.FeatureSet.Types;

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
            return dao.InsertPriceRule(priceRule);
        }

        public bool UpdatePriceRule(PriceRuleDTO priceRule)
        {
            return dao.UpdatePriceRule(priceRule);
        }

        public bool DeletePriceRule1(string id)
        {
            return dao.DeletePriceRule1(id);
        }

        public Dictionary<string, string> ValidatePriceRule(PriceRuleDTO dto)
        {
            var errors = new Dictionary<string, string>();

            if (dto.EndTime <= dto.StartTime)
                errors.Add("EndTime", "Giờ kết thúc phải lớn hơn giờ bắt đầu.");

            if (dto.StartDate != null && dto.EndDate != null)
            {
                if (dto.EndDate < dto.StartDate)
                {
                    errors.Add("EndDate", "Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                }
            }

            return errors;
        }

        public string GeneratePriceRuleId()
        {
            List<PriceRuleDTO> priceRules = dao.GetAllPriceRules();
            if (priceRules == null || priceRules.Count == 0)
            {
                return "PR0001";
            }
            int maxNumber = 0;
            foreach (var rule in priceRules)
            {
                Match match = Regex.Match(rule.PriceRuleId, @"\d+");
                if (match.Success)
                {
                    if (int.TryParse(match.Value, out int number))
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                        }
                    }
                }
            }
            int nextNumber = maxNumber + 1;
            return "PR" + nextNumber.ToString("D4");
        }

        public PriceRuleDTO CheckOverlap(PriceRuleDTO newRule)
        {
            List<PriceRuleDTO> allRules = dao.GetAllPriceRules1();
            var overlappingRule = allRules.FirstOrDefault(r =>
                r.EndType == newRule.EndType &&
                r.PriceRuleId != newRule.PriceRuleId &&
                (newRule.StartTime < r.EndTime && newRule.EndTime > r.StartTime) &&
                (
                   (newRule.StartDate == null || r.EndDate == null || newRule.StartDate <= r.EndDate) &&
                   (newRule.EndDate == null || r.StartDate == null || newRule.EndDate >= r.StartDate)
                )
            );

            return overlappingRule;
            
        }

        public PriceRuleDTO GetPriceRuleByTime(TimeOnly startTime, TimeOnly endTime, DateOnly bookingDate)
        {
            return dao.GetPriceRuleByTime(startTime, endTime, bookingDate);
        }
    }
}