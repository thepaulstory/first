using System.Data.Entity;
using PaulStoryCylanceCodingTest.Models;

namespace PaulStoryCylanceCodingTest.Data
{
    public class ProductsRepository : GenericRepository<Product>
    {
        public ProductsRepository(DbContext context) : base(context) { }
    }
}
