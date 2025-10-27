using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class ProductBUS
    { 
        private ProductDAO dao = new ProductDAO();

        public List<ProductDTO> GetAllProducts()
        {
            return dao.GetAllProducts();
        }

        public List<ProductDTO> GetProductByIds(string branchIds, string typeIds)
        {
            return dao.GetProductByIds(branchIds, typeIds);
        }

        public ProductDTO GetProductById(string productId)
        {
            return dao.GetProductById(productId);
        }

        public bool InsertProduct(ProductDTO product)
        {
            var existing = dao.GetProductById(product.ProductId);
            if (existing != null)
                throw new Exception("ProductId đã tồn tại!");

            return dao.InsertProduct(product);
        }

        public bool UpdateProduct(ProductDTO product)
        {
            var existing = dao.GetProductById(product.ProductId);
            if (existing == null)
                throw new Exception("Sản phẩm không tồn tại!");

            return dao.UpdateProduct(product);
        }

        public bool DeleteProduct(string productId)
        {
            var existing = dao.GetProductById(productId);
            if (existing == null)
                throw new Exception("Sản phẩm không tồn tại!");

            return dao.DeleteProduct(productId);
        }
    }
}