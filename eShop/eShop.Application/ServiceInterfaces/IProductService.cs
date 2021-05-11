using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;

namespace eShop.Application.ServiceInterfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
    }
}