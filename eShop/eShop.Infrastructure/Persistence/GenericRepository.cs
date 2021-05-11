using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Application.Common.RepositoryInterfaces;
using eShop.Domain.Entities;

namespace eShop.Infrastructure.Persistence
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        public async Task<IEnumerable<T>> GetAll()
        {
            var product1 = new Product {Name = "PC", SKU = "asdas342", Price = 33} as T;
            var product2 = new Product {Name = "Keyboard", SKU = "sdfw234", Price = 234} as T;
            var product3 = new Product {Name = "Mouse", SKU = "ge2123", Price = 234} as T;
            var product4 = new Product {Name = "Monitor", SKU = "fw324", Price = 567} as T;

            return new List<T> {product1, product2, product3, product4};
        }

        public T GetById(object id)
        {
            throw new System.NotImplementedException(); 
        }

        public void Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}