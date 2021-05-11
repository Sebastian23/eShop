using System.Data.Common;

namespace eShop.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string SKU { get; set; }

        public double Price { get; set; }
    }
}