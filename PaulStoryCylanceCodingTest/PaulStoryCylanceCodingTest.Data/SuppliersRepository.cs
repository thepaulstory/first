using System.Data.Entity;
using PaulStoryCylanceCodingTest.Models;

namespace PaulStoryCylanceCodingTest.Data
{
    public class SuppliersRepository : GenericRepository<Supplier>
    {
        public SuppliersRepository(DbContext context) : base(context) { }
    }
}
