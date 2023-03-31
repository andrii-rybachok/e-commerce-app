using web_api_products.DataBase;
using web_api_products.Models;

namespace web_api_products.Utils
{
    public class ProductService
    {
        private ShopDB _context;

        public ProductService(ShopDB context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {

            var res = _context.Products.Add(product);
            _context.SaveChanges();
        }
        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
