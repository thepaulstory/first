using PaulStoryCylanceCodingTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace PaulStoryCylanceCodingTest.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.ProductID).IsRequired();
            Property(p => p.ProductName).IsRequired().HasMaxLength(40);
            Property(p => p.QuantityPerUnit).HasMaxLength(20);
            Property(p => p.Discontinued).IsRequired();
        }
    }
}
