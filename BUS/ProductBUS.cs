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
            try 
            {
                return dao.GetAllProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return new List<ProductDTO>();
            }
        }

        public List<ProductDTO> GetProductByIds(string branchIds, string typeIds, bool onlyStock)
        {
            try
            {
                return dao.GetProductByIds(branchIds, typeIds, onlyStock);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return new List<ProductDTO>();
            }
        }

        public ProductDTO GetProductById(string productId)
        {
            try
            {
                return dao.GetProductById(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return new ProductDTO();
            }
        }

        public List<ProductDTO> GetProductByName(string name)
        {
            try
            {
                return dao.GetProductByName(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return new List<ProductDTO>();
            }
        }

        public bool InsertProduct(ProductDTO product)
        {
            try
            {
                var existing = dao.GetProductById(product.ProductId);
                if (existing != null)
                    throw new Exception("ProductId đã tồn tại!");
                return dao.InsertProduct(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return false;
            }
        }

        public bool UpdateProduct(ProductDTO product)
        {
            try
            {
                var existing = dao.GetProductById(product.ProductId);
                if (existing == null)
                    throw new Exception("Sản phẩm không tồn tại!");

                return dao.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return false;
            }
        }

        public bool DeleteProduct(string productId)
        {
            try
            {
                var existing = dao.GetProductById(productId);
                if (existing == null)
                    throw new Exception("Sản phẩm không tồn tại!");

                return dao.DeleteProduct(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return false;
            }
        }
        public bool HasTransactions(string productId)
        {
            try
            {
                return dao.HasTransactions(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return false;
            }
        }
        public bool DatabaseDeleteProduct(string productId)
        {
            try
            {
                var existing = dao.GetProductById(productId);
                if (existing == null)
                    throw new Exception("Sản phẩm không tồn tại!");

                return dao.DatabaseDeleteProduct(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return false;
            }
        }
       
        public string GenerateNextProductId()
        {
            try
            {
                return dao.GenerateNextProductId();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductBUS\n" + ex);
                return string.Empty;
            }
        }
    }
}
