using demo_dotnet_core.Models;
using System.Collections.Generic;

namespace demo_dotnet_core.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public string GetProductName()
        {
            return "Hii from TestRepository ";
        }

        public List<ProductModel> GetProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
