using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Application.Common.RepositoryInterfaces;
using eShop.Application.ServiceInterfaces;
using eShop.Domain.Entities;

namespace eShop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _productRepository.GetAll();
            return products.ToList();
        }
    }
}