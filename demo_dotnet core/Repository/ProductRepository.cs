using demo_dotnet_core.Models;
using System.Collections.Generic;

namespace demo_dotnet_core.Repository
{
    public class ProductRepository : IProductRepository
    {

        private List<ProductModel> products = new List<ProductModel>();

        public int AddProduct(ProductModel product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return product.Id;

        }

        public string GetProductName()
        {
            return "Hii from ProductRepository ";
        }

        public List<ProductModel> GetProducts()
        {

            return products;
        }
    }
}
