using demo_dotnet_core.Models;
using System.Collections.Generic;

namespace demo_dotnet_core.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetProducts();
        string GetProductName();
    }


}