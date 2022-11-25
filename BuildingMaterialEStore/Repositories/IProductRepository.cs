using BuildingMaterialEStore.Models.Product;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    public interface IProductRepository
    {
        Product FindProductById(long id);
        IEnumerable<Product> GetAllProducts();
        void SaveProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
