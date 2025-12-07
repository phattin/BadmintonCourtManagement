using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class BrandBUS
    {
        private BrandDAO dao = new BrandDAO();

        public BrandDTO GetById(string id)
        {
            return dao.GetById(id);
        }

        public List<BrandDTO> GetAllBrands()
        {
            return dao.GetAllBrands();
        }

        public bool InsertBrand(BrandDTO brand)
        {
            // Kiểm tra xem brand đã tồn tại chưa
            var existing = dao.GetById(brand.BrandId);
            if (existing != null)
                throw new Exception("Brand đã tồn tại!");

            return dao.InsertBrand(brand);
        }

        public bool UpdateBrand(BrandDTO brand)
        {
            var existing = dao.GetById(brand.BrandId);
            if (existing == null)
                throw new Exception("Brand không tồn tại!");

            return dao.UpdateBrand(brand);
        }
        
        public bool DeleteBrand(string id)
        {
            var existing = dao.GetById(id);
            if (existing == null)
                throw new Exception("Brand không tồn tại!");

            return dao.DeleteBrand(id);
        }

        public List<BrandDTO> Search(string keyword)
        {
            var allBrands = dao.GetAllBrands();
            return allBrands.FindAll(b => 
                b.BrandId.Contains(keyword, System.StringComparison.OrdinalIgnoreCase) ||
                b.BrandName.Contains(keyword, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}